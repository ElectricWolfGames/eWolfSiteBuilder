using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace eWolfSiteBuilder._Site.Games.SpaceSalvager
{
    [PageTitle("SpaceSalvagerEmails.html")]
    public class SpaceSalvagerEmails : PageDetails
    {
        public SpaceSalvagerEmails()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Space Salvager Emails";
            MenuTitle = "Space Salvager Emails";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");
            HTMLBuilder options = new HTMLBuilder();
            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            AddAllEmails(options, items);

            options = new HTMLBuilder();
            options.CreateIndexItems(items);

            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();

            WebPage.EndBody();
            WebPage.Output();
        }

        private void AddAllEmails(HTMLBuilder options, List<HTMLIndexedItems> items)
        {
            //items.Add(new HTMLIndexedItems("People", AddSectionItems));
            //options.CreateIndex(items);
            //WebPage.Append(options.Output());
            string unity3dDllPath = "C:\\Unity3d\\SpaceSalvager\\SpaceSalvager_UD\\Library\\ScriptAssemblies\\Assembly-CSharp.dll";
            Assembly unityAssembly = Assembly.LoadFrom(unity3dDllPath);
            dynamic ph = unityAssembly.CreateInstance("eWolf.SpaceSalvager.Story.Email.EmailHolder");
            var emails = ph.Emails;

            List<string> ids = new List<string>();
            foreach (dynamic email in emails)
            {
                ids.Add(email.EmailIds.ToString());
            }

            ids = ids.Distinct().ToList();

            foreach (string id in ids)
            {
                List<dynamic> emailGroup = new List<dynamic>();

                foreach (dynamic email in emails)
                {
                    if (email.EmailIds.ToString() == id)
                    {
                        emailGroup.Add(email);
                    }
                }

                items.Add(new HTMLIndexedItems(TextHelper.ToSentenceCase(id), AddSectionEmail(emailGroup)));
            }
            options.CreateIndex(items);
            WebPage.Append(options.Output());
        }

        private string AddSectionEmail(List<dynamic> enails)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            foreach (var email in enails)
            {
                outer.InspectorDetails("ID", email.EmailIds.ToString());
                outer.InspectorDetails("Title", email.Title);
                outer.InspectorDetails("From", TextHelper.ToSentenceCase(email.From.ToString()));
                outer.InspectorDetails("To", string.Join("; ", TextHelper.ToSentenceCase(email.To.ToString())));
                outer.InspectorDetails("Body", email.Body);
                outer.InspectorDetails("Part", email.Part.ToString());

                outer.NewLine();
                outer.NewLine();
            }
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Space Salvager Items");
            return options.Output();
        }
    }
}