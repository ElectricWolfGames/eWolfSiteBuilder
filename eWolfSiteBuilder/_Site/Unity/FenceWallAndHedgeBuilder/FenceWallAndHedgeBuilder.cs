using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.FenceWallAndHedgeBuilder
{
    [PageTitle("SciFiObjectsIndex.html")]
    internal class FenceWallAndHedgeBuilder : PageDetails, IHomePagePreview, IUnityList
    {
        public FenceWallAndHedgeBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Fence, Wall and Hedge Builder";
            MenuTitle = "Fence, Wall and Hedge Builder";
        }

        public int UnityListOrder { get; set; } = 5;

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

            //items.Add(new HTMLIndexedItems("Download", CreateDownload));
            //items.Add(new HTMLIndexedItems("Examples", CreateExamples));
            //items.Add(new HTMLIndexedItems("Shelves", CreateShelves));
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
                PreviewItemType = PreviewItemType.Builders,
                ImagePath = @$"{WebPage.HtmlPath}\Images\FenceWallAndHedgeBuilder.gif",
                Description = "Fence Wall And Hedge Builder Lets you quickly place walls in your game, using a user-friendly UI from within the scene editor or the inspector, Select from a list defined wall types and then select the style of that type"
            };

            return pi;
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Fence, Wall and Hedge Builder Lets you quickly place walls in you game, using a user friendly UI from within the scene editor or the inspector, Select from a list of defined wall types and then select the style for that type.");
            return options.Output();
        }
    }
}