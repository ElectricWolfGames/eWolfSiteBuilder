using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;
using System;
using eWolfSiteBuilder.SiteDetails.Configuration;

namespace eWolfSiteBuilder._Site.Unity.SkyboxesVariety
{
    [PageTitle("SkyboxesVariety.html")]
    internal class SkyboxesVariety : PageDetails, IHomePagePreview, IUnityList
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
            WebPage.AddNavigation(NavigationTypes.Main);
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Index", CreateIndex));
            items.Add(new HTMLIndexedItems("Previews", CreatePreviews));
            //items.Add(new HTMLIndexedItems("Inspector Actions", CreateInspector));
            //items.Add(new HTMLIndexedItems("Floor Objects", CreateFloorObjects));
            //items.Add(new HTMLIndexedItems("Randomize Scene", CreateRandomizeScene));
            //items.Add(new HTMLIndexedItems("Other Objects", CreateOtherObjects));
            //items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            //items.Add(new HTMLIndexedItems("More Images", CreateMoreImages));
            //items.Add(new HTMLIndexedItems("Project Layout", CreateProjectLayout));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.CreateSupport));

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
                ImagePath = @$"{WebPage.HtmlPath}\Images\SkyboxesA.png",
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

            options.Text(@"That you can get from Unity3D asset store");
            options.NewLine();
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

            HTMLSection a = new HTMLSection("col-md-8");
            HTMLSection b = new HTMLSection("col-md-4");
            options.SetTwoSections(a, b);

            a.TextBoldText("", name, "");
            a.NewLine();
            a.Images(23, $"{skyBox}\\{skyBox}_Back.PNG", $"{skyBox}\\{skyBox}_Right.PNG", $"{skyBox}\\{skyBox}_Front.PNG", $"{skyBox}\\{skyBox}_Left.PNG");
            b.NewLine();
            b.ImageCenter($"{skyBox}\\{skyBox}_Up.PNG", 45);

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "High quality panoramic scenes that can be used in your game." +
                "All textures (6 of them) are 1024 by 1024 resolution.");

            return options.Output();
        }

        private string CreateIndex(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.Text("This collection contains 10 Skyboxes that you can use in any Unity 3D scene.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Just add the SkyBox component to the camera and then just drag one of my martials on it.");
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
            outer.Text("Red planet");
            outer.NewLine();
            outer.Text("Gray world");
            outer.NewLine();
            outer.Text("Water");
            outer.NewLine();
            outer.Text("Water 2");

            outer.NewLine();
            outer.NewLine();
            outer.Text(AddSkyImages("AlienGrey", "Alien Planet Grey"));
            outer.NewLine();
            outer.Text(AddSkyImages("AsteroidBelt", "Asteroid Belt"));

            return outer.Output();
        }
    }
}