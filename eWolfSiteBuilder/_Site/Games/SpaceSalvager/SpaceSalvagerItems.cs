using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWolfSiteBuilder._Site.Games.SpaceSalvager
{
    [PageTitle("SpaceSalvagerItems.html")]
    public class SpaceSalvagerItems : PageDetails
    {
        public SpaceSalvagerItems()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Space Salvager Items";
            MenuTitle = "Space Salvager Items";
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

            items.Add(new HTMLIndexedItems("Items", AddSectionItems));
            /*items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Inspector Options", CreateInspectorOptions));
            items.Add(new HTMLIndexedItems("How to use", CreateHowToUse));
            items.Add(new HTMLIndexedItems("Interface options", CreateInterfaceOptions));
            items.Add(new HTMLIndexedItems("Project Layout", CreateProjectLayout));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));
*/
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

            outer.InspectorDetails($"Red Key Card", "Door pass");
            outer.ImageCenter("PersonPassRed.PNG", 16);

            outer.InspectorDetails($"Cyan Key Card", "Door pass");
            outer.ImageCenter("PersonPassCyan.PNG", 16);

            outer.InspectorDetails($"Green Key Card", "Door pass");
            outer.ImageCenter("PersonPassGreen.PNG", 16);

            outer.InspectorDetails($"Purple Key Card", "Door pass");
            outer.ImageCenter("PersonPassPurple.PNG", 16);

            outer.InspectorDetails($"PowerBoard", "no value");
            outer.ImageCenter("PowerBoard.PNG", 16);
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