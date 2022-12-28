using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using System.Collections.Generic;
using System.Reflection;

namespace eWolfSiteBuilder._Site.Games.SpaceSalvager
{
    [PageTitle("SpaceSalvagerPeople.html")]
    public class SpaceSalvagerPeople : PageDetails
    {
        public SpaceSalvagerPeople()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Space Salvager People";
            MenuTitle = "Space Salvager People";
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

            dynamic ph = unityAssembly.CreateInstance("eWolf.SpaceSalvager.Story.People.PeopleHolder");

            var people = ph.People;

            foreach (dynamic person in people)
            {
                outer.InspectorDetails("Name", person.Name);
                outer.InspectorDetails("Department", person.Department.ToString());
                outer.InspectorDetails("Role", person.Department.ToString());
                outer.InspectorDetails("Emails", person.Email.ToString());
                outer.InspectorDetails("Ship", person.ShipID.ToString());
                outer.InspectorDetails("Class", person.Class.ToString());

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