using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.GardenFlowers
{
    [PageTitle("GardenFlowers.html")]
    public class GardenFlowers : PageDetails, IHomePagePreview, IUnityList
    {
        public GardenFlowers()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Garden Flowers";
            MenuTitle = "Garden Flowers";
        }

        public int UnityListOrder { get; set; } = 10;

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
            // items.Add(new HTMLIndexedItems("Examples", CreateExamples));
            // items.Add(new HTMLIndexedItems("Shelves", CreateShelves));
            // items.Add(new HTMLIndexedItems("Inspector Actions", CreateInspector));
            // items.Add(new HTMLIndexedItems("Floor Objects", CreateFloorObjects));
            // items.Add(new HTMLIndexedItems("Randomize Scene", CreateRandomizeScene));
            // items.Add(new HTMLIndexedItems("Other Objects", CreateOtherObjects));
            // items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            // items.Add(new HTMLIndexedItems("More Images", CreateMoreImages));
            // items.Add(new HTMLIndexedItems("Project Layout", CreateProjectLayout));
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
                ImagePath = @$"{WebPage.HtmlPath}\Images\GardenFlowers.png",
                Description = "A collection of low poly garden flowers for Unity3D. Flowers have individual prefabs and also a collection of Flower Beds prefabs with pre-arranged groups of flowers for easy placement"
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
            options.Unity3DLink(Unity3DSetting.GardenFlowers);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "A collection of low poly garden flowers for Unity3D. Flowers have individual prefabs and also a collection of Flower Beds prefabs with pre-arranged groups of flowers for easy placement");
            return options.Output();
        }
    }
}