using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using System.Collections.Generic;
using System.Reflection;

namespace eWolfSiteBuilder._Site.Games.SpaceSalvager
{
    [PageTitle("SpaceSalvagerQuests.html")]
    public class SpaceSalvagerQuests : PageDetails
    {
        public SpaceSalvagerQuests()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Space Salvager Quests";
            MenuTitle = "Space Salvager Quests";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());
            WebPage.Append(SpaceSalvagerEmails.CreateLinks());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Quests", AddSectionItems));
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

            dynamic qh = unityAssembly.CreateInstance("eWolf.SpaceSalvager.Story.Quests.QuestHolder");

            var quests = qh.Quests;

            foreach (dynamic quest in quests)
            {
                outer.InspectorDetails("Name", quest.Name);
                outer.InspectorDetails("Description", quest.Description);
                outer.InspectorDetails("Level", quest.Level);
                outer.InspectorDetails("QuestIds", quest.QuestIds.ToString());

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
            options.Jumbotron(DisplayTitle, "Space Salvager Quests");
            return options.Output();
        }
    }
}