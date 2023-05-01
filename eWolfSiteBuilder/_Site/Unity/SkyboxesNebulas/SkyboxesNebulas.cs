using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SkyboxesNebulas
{
    [PageTitle("SkyboxesNebulas.html")]
    public class SkyboxesNebulas : PageDetails, IHomePagePreview, IUnityList
    {
        public SkyboxesNebulas()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Skyboxes Nebulas";
            MenuTitle = "Skyboxes Nebulas";
        }

        public int UnityListOrder { get; set; } = 20;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");

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
                ImagePath = @$"{WebPage.HtmlPath}\images\SkyboxesC.png",
                Description = "Section of 5 Variety skyboxes all Space Nebulas, " +
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

            options.Unity3DLink(Unity3DSetting.SkyboxesNebulas);
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
            outer.Text("This collection contains 5 Space Nebulas Skyboxes that you can use in any Unity 3D scene.");
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

            outer.Text(AddSkyImages("Nebula-B", "Nebula A"));
            outer.Text(AddSkyImages("Nebula-C", "Nebula B"));
            outer.Text(AddSkyImages("Nebula-D", "Nebula C"));
            outer.Text(AddSkyImages("Nebula-E", "Nebula D"));
            outer.Text(AddSkyImages("Nebula-F", "Nebula E"));

            return outer.Output();
        }
    }
}