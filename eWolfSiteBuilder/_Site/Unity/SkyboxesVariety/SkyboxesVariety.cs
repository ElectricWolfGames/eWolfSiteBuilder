using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SkyboxesVariety
{
    [PageTitle("SkyboxesVariety.html")]
    public class SkyboxesVariety : PageDetails, IHomePagePreview, IUnityList
    {
        public SkyboxesVariety()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Skyboxes Variety";
            MenuTitle = "Skyboxes Variety";
        }

        public int UnityListOrder { get; set; } = 20;

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
            items.Add(new HTMLIndexedItems("How to Use", CreateHowToUse));
            items.Add(new HTMLIndexedItems("Previews", CreatePreviews));
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
                PreviewItemType = PreviewItemType.Skyboxes,
                ImagePath = @$"{WebPage.HtmlPath}\images\SkyboxesA.png",
                Description = "Section of 10 Variety skyboxes, " +
                "High quality panoramic scenes that can be used in your game." +
                "All textures (6 of them) are 1024 by 1024 resolution."
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.SkyboxesVariety);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string AddSkyImages(string skyBox, string name)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.NewLine();
            options.NewLine();

            HTMLSection a = new HTMLSection("col-md-8");
            HTMLSection b = new HTMLSection("col-md-4");
            options.SetTwoSections(a, b);

            a.TextBoldText("", name, "");
            a.NewLine();
            a.Images(23, $"{skyBox}\\{skyBox}_Back.png", $"{skyBox}\\{skyBox}_Right.png", $"{skyBox}\\{skyBox}_Front.png", $"{skyBox}\\{skyBox}_Left.png");
            b.NewLine();
            b.ImageCenter($"{skyBox}\\{skyBox}_Up.png", 45);

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "High quality panoramic scenes that can be used in your game." +
                "All textures (6 of them) are 1024 by 1024 resolution.");

            return options.Output();
        }

        private string CreateHowToUse(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.Text("This collection contains 10 Skyboxes that you can use in any Unity 3D scene.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Just add the SkyBox component to the camera and then just drag one of my materials on it.");
            outer.NewLine();
            outer.NewLine();
            return outer.Output();
        }

        private string CreatePreviews(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.Text("The Skyboxes included are");
            outer.NewLine();
            outer.NewLine();

            outer.Text("Alien Grey Planet");
            outer.NewLine();
            outer.Text("Green Hills");
            outer.NewLine();
            outer.Text("Snowy mountains");
            outer.NewLine();
            outer.Text("Space Station");
            outer.NewLine();
            outer.Text("Asteroid Belt");
            outer.NewLine();
            outer.Text("Nebula");
            outer.NewLine();
            outer.Text("Alien Red planet");
            outer.NewLine();
            outer.Text("Gray world");
            outer.NewLine();
            outer.Text("Water");
            outer.NewLine();
            outer.Text("Water 2");

            outer.Text(AddSkyImages("AlienGrey", "Alien Grey Planet"));
            outer.Text(AddSkyImages("AsteroidBelt", "Asteroid Belt"));
            outer.Text(AddSkyImages("GreenHills", "Green Hills"));
            outer.Text(AddSkyImages("Nebula", "Nebula"));
            outer.Text(AddSkyImages("RedPlanet", "Alien Red Planet"));
            outer.Text(AddSkyImages("Sand", "Sand"));
            outer.Text(AddSkyImages("Snow", "Snow"));
            outer.Text(AddSkyImages("SpaceStation", "Space Station"));
            outer.Text(AddSkyImages("Water", "Water"));
            outer.Text(AddSkyImages("Water2", "Water 2"));

            return outer.Output();
        }
    }
}