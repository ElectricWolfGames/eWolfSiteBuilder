using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.RoadBuilder
{
    [PageTitle("RoadBuilderCurves.html")]
    public class RoadBuilderCurves : PageDetails
    {
        public RoadBuilderCurves()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Road Builder Curves";
            MenuTitle = "Road Builder Curves";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main);
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            HTMLBuilder options = new HTMLBuilder();
            options.PageLink("You can find the full documentation for Road Builder", "here", "RoadBuilder.html");
            options.NewLine();
            WebPage.Append(options.Output());

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Curve Styles", CreateCurveStyles));
            items.Add(new HTMLIndexedItems("Prefabs selection", CreatePrefabsSelection));
            items.Add(new HTMLIndexedItems("Settings", CreateSettings));
            items.Add(new HTMLIndexedItems("Converting Existing Roads", CreateConvertingExistingRoads));
            items.Add(new HTMLIndexedItems("Dynamic road widths", CreateDynamicRoadWidths));
            items.Add(new HTMLIndexedItems("Creating your own textures", CreateCreatingYourOwnTextures));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.CreateSupport));

            options = new HTMLBuilder();

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

        private static string CreateDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"This package has all you need to create 7 different road types from normal (with and with-out pavement), grass, sandy, race track and even a rail track. And you can add more road textures/materials as you need. You don’t need any programming skills to create amazing looking roads.");
            outer.NewLine();
            outer.NewLine();
            outer.PageLink("To see the full documentation", "Road builder", "RoadBuilder.html");
            outer.NewLine();
            outer.NewLine();

            outer.Unity3DLink(Unity3DSetting.RoadBuilder);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateConvertingExistingRoads(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"");

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCreatingYourOwnTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"");

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCurveStyles(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"");

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateDynamicRoadWidths(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"");

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.JumbotronImage(DisplayTitle,
                    "Road Builder Lets you create non-linear roads easily by using a network of nodes. With easy to use buttons to extrude, join, insert nodes and create mesh. Building new roads has never been so easy.",
                    "RoadBuilderLogo.PNG", 35);
            return outer.Output();
        }

        private string CreatePrefabsSelection(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"");

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateSettings(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"");

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}