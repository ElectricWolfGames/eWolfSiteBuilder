using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.TrafficAndRoadsideObjects
{
    [PageTitle("TrafficRoadSideObjects.html")]
    public class TrafficRoadSideObjects : PageDetails, IHomePagePreview, IUnityList
    {
        public TrafficRoadSideObjects()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Traffic and Roadside objects";
            MenuTitle = "Traffic and Roadside objects:";
        }

        public int UnityListOrder { get; set; } = 15;

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

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Details", CreateDetails));

            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));

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

        public PreviewItem GetHomePagePreview()
        {
            PreviewItem pi = new PreviewItem()
            {
                HRef = $"{WebPage.HtmlPath}\\{WebPage.HtmlTitle}",
                Name = DisplayTitle,
                PreviewItemType = PreviewItemType.Models,
                ImagePath = @$"{WebPage.HtmlPath}\images\TrafficObjectsAd.png",
                Description = "A Collection of 42 traffic and roadside objects prefabs, Ideal for any city.</br>" +
                "<strong>Contains:</strong> Traffic Barriers, Road Barriers, Traffic Cones, Traffic lights (Animated), Crossing lights (Animated), Benches, Bins"
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text(@"A Collection of 42 traffic and roadside objects prefabs, Ideal for any city.");
            options.NewLine();
            options.Unity3DLink(Unity3DSetting.TrafficAndRoadsideObjects);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private static string CreateOverview()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text(@"A Collection of 42 prefabs for Unity3D, All with collision");
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.TrafficAndRoadsideObjects);
            options.NewLine();

            options.Text(@"");
            options.NewLine();

            options.EndTextCenter();

            return options.Output();
        }

        private string CreateDetails(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text("The package includes");
            options.NewLine();
            options.Text("Traffic Barriers");
            options.NewLine();
            options.Text("Road Barriers");
            options.NewLine();
            options.Text("Traffic Cones");
            options.NewLine(); options.Text("Traffic lights (Animated)");
            options.Text("Crossing lights (Animated)");
            options.NewLine();
            options.Text("Benches");
            options.NewLine();
            options.Text("Bins");
            options.NewLine();
            options.NewLine();

            options.YouTubeLinkBig("Y0xcCifv8ZA");

            options.ImageCenter("ShowAll.png", 80);

            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("TrafficLights.png", "TrafficLights-Chained.png"));
            options.NewLine();

            options.YouTubeLinkBig("mEwTMT2C25Y");
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("BarriersInGameC.png", "BarriersInGame.png"));
            options.NewLine();
            options.ImageCenter("BarriersInGameB.png", 40);
            options.NewLine();

            options.EndTextCenter();

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "A Collection of 42 prefabs for Unity3D, All with collision");
            return options.Output();
        }
    }
}