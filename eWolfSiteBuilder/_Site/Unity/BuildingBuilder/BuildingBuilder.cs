using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.BuildingBuilder
{
    [PageTitle("BuildingBuilder.html")]
    public class BuildingBuilder : PageDetails, IHomePagePreview, IUnityList
    {
        public BuildingBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Building Builder";
            MenuTitle = "Building Builder";
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
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Create Create First Building", CreateCreateFirstBuilding));
            items.Add(new HTMLIndexedItems("House Style", CreateHouseStyle));
            items.Add(new HTMLIndexedItems("Randomization", CreateRandomization));
            items.Add(new HTMLIndexedItems("Setting Textures", CreateSettingTextures));
            items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            items.Add(new HTMLIndexedItems("Baked Light Map Support", CreateBakedLightMapSupport));
            items.Add(new HTMLIndexedItems("Textures Templates", CreateTexturesTemplates));
            items.Add(new HTMLIndexedItems("Custom Build example", CreateCustomBuildExample));
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
                ImagePath = @$"{WebPage.HtmlPath}\Images\Builder_Creating_your_first_Buildin.gif",
                Description = "Building Builder lets you create a variety of Lowpoly buildings from a defined list of settings. Each building is created by a collection of options that can easily be changed or set to use a random set of values"
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.BuildingBuilder);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateBakedLightMapSupport(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateCreateFirstBuilding(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("To start creating random building you just need add the prefab of your chosen building type From the selection in the prefab folder.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Building builder is ideal for any low poly games that need a lot of buildings, or just as a background building for higher details games.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Village house", "(basic)");
            outer.OtherDetails("Townhouse", "(basic)");
            outer.OtherDetails("Town Block", "(basic)");
            outer.OtherDetails("Village house", "(variety)");
            outer.OtherDetails("Tudor house", "(variety)");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("And then just click on the ", "'Randomize Building'", " button.");
            outer.NewLine();
            outer.TextBoldText("That’s you first house created. You can continue to click on the ", "'Randomize Building'", " button if you need something different.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("sE88PriFNsc");
            outer.NewLine();
            outer.NewLine();
            outer.TextBold("After you have created you building, you can still customize it, so maybe you like the building but you just need it a bit wider, or you need to add a garage - you can just modify the setting and click on the ", "'Create Building'");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("NTOVUlW3S5Y");
            outer.NewLine();
            outer.NewLine();
            outer.TextBold("You can set the size of each building sections by changing the", " Building Units.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("ShowScale.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("This means you don't need to change the transform scale size so it's more likely to get batched when rendering.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateCustomBuildExample(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Building Builder lets you create a variety of Lowpoly buildings from a defined list of settings. Each building is created by a collection of options that can easy be changed or set to use a random set of values.");
            return options.Output();
        }

        private string CreateHouseStyle(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateMaterials(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("You just set the style of house to use and then let the randomizer create a build within the parameters of your chosen building style. After you have created you random building you can tweak the options to make is just as you need it.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Building builder is ideal for any low poly games that need a lot of buildings, or just as a background building for higher details games.");
            outer.NewLine();
            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateRandomization(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateSettingTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateTexturesTemplates(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.EndTextCenter();
            return outer.Output();
        }
    }
}