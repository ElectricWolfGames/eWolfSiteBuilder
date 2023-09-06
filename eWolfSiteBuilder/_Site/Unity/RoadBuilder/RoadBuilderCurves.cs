using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
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
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            HTMLBuilder options = new HTMLBuilder();
            options.PageLink("You can find the full documentation for Road Builder", "here", "RoadBuilder.html");
            options.NewLine();
            options.NewLine();
            WebPage.Append(options.Output());

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Curve Styles", CreateCurveStyles));
            items.Add(new HTMLIndexedItems("Prefabs selection", CreatePrefabsSelection));
            items.Add(new HTMLIndexedItems("Settings", CreateSettings));
            items.Add(new HTMLIndexedItems("Converting Existing Roads", CreateConvertingExistingRoads));
            items.Add(new HTMLIndexedItems("Creating your own textures", CreateCreatingYourOwnTextures));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport));

            AddIndexItemsWithSideBar(items);

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

            outer.Text("If you all ready have a roads system and need to update it to use the new curves, just decide on the curve you would like.");
            outer.NewLine();
            outer.TextBoldText("Then select the main ", "RoadNetwork_Main_pf", " (the root object of the road system),");
            outer.NewLine();
            outer.Text("and change the all the materials sets to use the curve materials (All names as CurveA, CurveB, CurveC and Extended),");
            outer.NewLine();
            outer.Text("Then update the UV set drop down list to match for choice of curve. Then just create the road mesh again.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Select RoadNetwork_*_pf");
            outer.ImageCenter("Convert_01.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("Change all the materials to use the curve sets");
            outer.ImageCenter("Convert_02.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("Change the UV set to use the new curve code");
            outer.ImageCenter("Convert_03.png", 65);

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCreatingYourOwnTextures(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.TextBoldText("In the package you will find 4 template textures. at", @" Assets\eWolfRoadBuilder\Textures\TemplateExtended ", "");
            outer.NewLine();
            outer.Text("Each Texture is a template for how the road will look.");
            outer.NewLine();
            outer.Text("One for each type CurveA, CurveB, CurveC or Extended.");
            outer.NewLine();
            outer.ImageCenter("TemplateRoadACurveA.png", 45);
            outer.NewLine();
            outer.NewLine();
            outer.Text("The template is ideal for when you need to create a new look for your road.");
            outer.NewLine();
            outer.Text("You can also take any of the over textures and just modify them as you need.");
            outer.NewLine();
            outer.ImageCenter("RoadMainCurveA_Diffused.png", 45);

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCurveStyles(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("From user feedback, I've now added rounded inner corners to the Junctions and CrossRoads");
            outer.NewLine();
            outer.Text("Road Builder now has 4 different UV mapping options for Junctions and cross roads");
            outer.NewLine();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            left.Text("Curve A");
            left.ImageRight("InnerCornerA.png", 65);
            right.Text("Curve B");
            right.ImageLeft("InnerCornerB.png", 65);
            outer.Text(options.Output());

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            left.Text("Curve C");
            left.ImageRight("InnerCornerC.png", 65);
            right.Text("Extended");
            right.ImageLeft("ExtendedUVs.png", 65);
            outer.Text(options.Output());

            outer.NewLine();
            outer.Text("Letting crossroads and junctions have better looking textures.");
            outer.ImageCenter("CrossRoadCorners.png", 45);
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
                    "RoadBuilderLogo.png", 35);
            return outer.Output();
        }

        private HTMLBuilder CreateIndexItems(List<HTMLIndexedItems> items)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();
            return options;
        }

        private string CreatePrefabsSelection(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.TextBoldText("A new folder at ", @"Assets\eWolfRoadBuilder\Prefabs\Extended", " has been added with all the new prefabs for the extended UVs sets.");
            outer.NewLine();
            outer.Text("This is to make sure nothing breaks for legacy users.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Each prefab has been names in 3 parts separated by the an underscore.");
            outer.NewLine();
            outer.InspectorDetails("RoadNetwork", "is the type of prefab - the main network systems");
            outer.InspectorDetails("Main", "The type of road, Clean, main, main with damage");
            outer.InspectorDetails("CurveA", "This is the type of curve it's using - CurveA, CurveB, CurveC or Extended");
            outer.NewLine();
            outer.NewLine();

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateSettings(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            left.Text("The default detail level on a Crossroad or Junction can be changed. Just change the section value and press on Create Mesh to see the results.");
            right.ImageLeft("SectionSetting.png", 65);
            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            left.Text("Here show two different setting of 5");
            left.ImageRight("CornerSetting_5.png", 65);
            right.Text("and 20");
            right.ImageLeft("CornerSetting_20.png", 65);
            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();
            outer.Text("Remember you can select more that on node to change some settings. Below is two nodes selected.");
            outer.NewLine();
            outer.ImageCenter("MultiEdit.png", 65);

            outer.NewLine();

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}