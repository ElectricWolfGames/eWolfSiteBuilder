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

            WebPage.StartDiv("<div class='container mt-12'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Create First Building", CreateCreateFirstBuilding));
            items.Add(new HTMLIndexedItems("House Style", CreateHouseStyle));
            items.Add(new HTMLIndexedItems("Randomization", CreateRandomization));
            items.Add(new HTMLIndexedItems("Setting Textures", CreateSettingTextures));
            items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            items.Add(new HTMLIndexedItems("Baked Light Map Support", CreateBakedLightMapSupport));
            items.Add(new HTMLIndexedItems("Textures Templates", CreateTexturesTemplates));
            items.Add(new HTMLIndexedItems("Custom Build example", CreateCustomBuildExample));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));

            AddIndexItemsWithSideBar(items);

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
                ImagePath = @$"{WebPage.HtmlPath}\images\Builder_Creating_your_first_Buildin.gif",
                Description = "Building Builder lets you create a variety of Low-poly buildings from a defined list of settings. Each building is created by a collection of options that can easily be changed or set to use a random set of values"
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

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.StartTextCenterLeft();
            left.StartTextMiddel(300);
            left.NewLine();
            left.NewLine();
            left.Text("With the release of Version 1.2 (June 2017) you can now use the building with Baked lighting. Just enable the new Baked Lighting option and adjust the unwrapping options.");
            left.NewLine();
            left.NewLine();
            left.Text("The Unwrapping options are the current default import options on normal mesh import.");
            left.EndTextMiddel();
            left.EndTextCenterLeft();
            right.ImageLeft("BakedLightingOptions.png", 55);

            outer.Text(options.Output());
            outer.NewLine();
            outer.ImageCenter("BakedLightsTest.png", 55);

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
            outer.OtherDetails("Town house", "(basic)");
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
            outer.ImageCenter("ShowScale.png", 65);
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

            outer.Text("Here is an example of using a few building together to make one large building.");
            outer.NewLine();
            outer.YouTubeLinkBig("7fqrVVaMljw");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Building Builder lets you create a variety of Low-poly buildings from a defined list of settings. Each building is created by a collection of options that can easy be changed or set to use a random set of values.");
            return options.Output();
        }

        private string CreateHouseStyle(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.NewLine();

            outer.Text("To help you quickly set-up different styles of building you have the House Style options");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Here you can select the kind of building you wish to create like ");
            outer.NewLine();
            outer.Text("Village House");
            outer.NewLine();
            outer.Text("Town House");
            outer.NewLine();
            outer.Text("Tower Block");
            outer.NewLine();
            outer.NewLine();
            outer.Text("This will set-up all the randomization details for that type of building. But it will not change the materials you have defined.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private void CreateIndexedItems(List<HTMLIndexedItems> items)
        {
            HTMLBuilder options = new HTMLBuilder();

            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();
        }

        private string CreateMaterials(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("When a building is created / randomized it will pick one of the materials from this list. For most building you may only have one material, but for others you may wish to make the building look differently. So just add as many variations as you need to this list. And the randomiser will pick one for you. If you wanted to make 1 out of ten build look like it’s made of stone and not brick, you will need to add 10 materials to this list, 9 of them redbrick, and 1 stone. This will let the randomization pick 1 out of ten building could like it’s made of stone. See the 'VillageHouse(Variety)_pf' prefab for an example of this.");

            outer.NewLine();
            outer.NewLine();
            outer.Text("You can add / use materials, textures and shaders as you need. Because Building builder will assign the material form the list it lets you set-up any normal maps and specular maps as you would for a normal asset.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("You just set the style of house to use and then let the randomiser create a build within the parameters of your chosen building style. After you have created you random building you can tweak the options to make is just as you need it.");
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

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("Randomization.png", 45);

            right.StartTextCenterLeft();
            right.StartTextMiddel(400);
            right.NewLine();
            right.NewLine();
            right.Text("When you have a building or group of buildings selected you should see all the randomization options in the inspector. This area can be used to help define the look of the house when you press the randomize building options.");
            right.NewLine();
            right.NewLine();
            right.Text("If you don't want an option to be randomized just un-tick the option.");
            right.NewLine();
            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateSettingTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.StartTextCenterLeft();
            left.StartTextMiddel(300);
            left.NewLine();
            left.NewLine();
            left.Text("You can re-randomise the arrangement of textures by using the “Randomize Textures” button. You can also edit them manually by changing the letters in the Textures Details section. Here each texture used is represented with a letter.");
            left.NewLine();
            left.NewLine();
            left.OtherDetails("W", "Wall");
            left.OtherDetails("D", "Door");
            left.OtherDetails("G", "Window (Glass)");
            left.EndTextMiddel();
            left.EndTextCenterLeft();
            right.ImageLeft("TextureDetails.png", 65);

            outer.Text(options.Output());

            outer.Text("Letter are arranged by each wall and then the floor. so...");
            outer.NewLine();
            outer.Bold("GD,WW,GG,WW");
            outer.NewLine();
            outer.Text("Is for a single floor building with the with of 2 and the depth of 2.");
            outer.NewLine();

            outer.NewLine();
            outer.Text("The front of the building will have a door and a window [GD]");
            outer.NewLine();
            outer.Text("The side has just walls [WW]");
            outer.NewLine();
            outer.Text("The back has two windows [GG]");
            outer.NewLine();
            outer.Text("The other side has two walls [WW]");
            outer.NewLine();
            outer.NewLine();

            outer.YouTubeLinkBig("Z4SgXE8BxRU");
            outer.NewLine();
            outer.Text("Note : If you now change the size of the house this list will have to be recreated and you will lose your changes.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateTexturesTemplates(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.Text("The each building will only need one texture, and it use different parts of that texture for the different features of the building.");
            outer.NewLine();
            outer.NewLine();

            outer.Text("So each texture is split-up into a 4 by 4 grid and each cell represents a different type of wall. When you have the Building style as 'Village House' or 'Town House' The texture maps is as follows.");
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("TableA.PNG", 65);

            outer.NewLine();

            outer.Text("When you have the Building style as 'Tower Block' The texture maps is as follows. (Tower block us a flat roof style.)");
            outer.NewLine();
            outer.ImageCenter("TableB.PNG", 65);
            outer.NewLine();
            outer.NewLine();

            outer.Text("Note : You can create textures of any size, just as long as the textures follow the template above. And all the empty sections have been left for future additions.");

            outer.EndTextCenter();
            return outer.Output();
        }
    }
}