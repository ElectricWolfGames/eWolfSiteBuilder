using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using System.Collections.Generic;
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

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("People", AddSectionItems));
            HTMLBuilder options = new HTMLBuilder();

            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();

            WebPage.EndBody();
            WebPage.Output();
        }

        private string AddSectionItems(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            string unity3dDllPath = "C:\\Unity3d\\SpaceSalvager\\SpaceSalvager_UD\\Library\\ScriptAssemblies\\Assembly-CSharp.dll";

            Assembly unityAssembly = Assembly.LoadFrom(unity3dDllPath);

            dynamic ph = unityAssembly.CreateInstance("eWolf.SpaceSalvager.Story.Email.EmailHolder");

            var emails = ph.Emails;

            foreach (dynamic person in emails)
            {
                outer.InspectorDetails("Title", person.Title);
                outer.InspectorDetails("From", person.From.ToString());
                outer.InspectorDetails("To", string.Join("; ", person.To));
                outer.InspectorDetails("Body", person.Body);
                outer.InspectorDetails("Part", person.Part.ToString());

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