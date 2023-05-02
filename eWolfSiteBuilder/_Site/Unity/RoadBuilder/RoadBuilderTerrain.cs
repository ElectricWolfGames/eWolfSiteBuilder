using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.RoadBuilder
{
    [PageTitle("RoadBuilderTerrain.html")]
    public class RoadBuilderTerrain : PageDetails
    {
        public RoadBuilderTerrain()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Road Builder Terrain";
            MenuTitle = "Road Builder Terrain";
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
            items.Add(new HTMLIndexedItems("Terrain Modifier", CreateTerrainModifier));
            items.Add(new HTMLIndexedItems("Terrain Actions", CreateTerrainActions));
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

            outer.Text(@"This package has all you need to create 7 different road types from normal (with and with-out pavement), grass, sandy, race track and even a rail track. And you can add more road textures/materials as you need. You don't need any programming skills to create amazing looking roads.");
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

        private string CreateHero()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.JumbotronImage(DisplayTitle,
                    "Road Builder Lets you create non-linear roads easily by using a network of nodes. With easy to use buttons to extrude, join, insert nodes and create mesh. Building new roads has never been so easy.",
                    "RoadBuilderLogo.png", 35);
            return outer.Output();
        }

        private HTMLBuilder CreateIndexItems(HTMLBuilder options, List<HTMLIndexedItems> items)
        {
            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();
            return options;
        }

        private string CreateTerrainActions(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            left.NewLine();
            left.Text("When you have your roads system just as you need it");
            left.NewLine();
            left.TextBoldText("Click on the ", "Modify Terrain to match road", " To updated the terrain.");
            left.NewLine();
            left.TextBoldText("If you are not happy with the terrain you can press on ", "Restore previous terrain", " to undo the modification.");
            right.ImageLeft("TerrainModifierActions.png", 65);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();
            outer.Text("Terrain Options");
            outer.NewLine();
            outer.InspectorDetails("Plateau", "The amount to level off on both side of the road");
            outer.NewLine();
            outer.InspectorDetails("Slope", "The amount to smooth out to match the existing terrain");
            outer.NewLine();
            outer.InspectorDetails("Flatten Terrain", "Flatten the terrain before modifying");
            outer.NewLine();
            outer.InspectorDetails("Details-Off Set", "Off set the height of the terrain from the road (reduces the chances of the terrain clipping the road)");
            outer.NewLine();
            outer.InspectorDetails("Details-Divider", "The higher the details on the terrain, the higher this number will need to be.");
            outer.NewLine();

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateTerrainModifier(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Using terrain modifier on any road");
            outer.NewLine();
            outer.YouTubeLinkBig("TZxMWKg8Qgg");
            outer.NewLine();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            left.ImageRight("AddTerrainModifier.png", 65);
            right.Text("Select the main RoadNetwork_Main_pf (the root object of the road system)");
            right.NewLine();
            right.Text("And click on the 'Add Terrain modifier' button to add the terrain modifier");

            outer.Text(options.Output());

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            right.ImageLeft("TerrainModifierDefault.png", 65);
            left.NewLine();
            left.NewLine();
            left.Text("Now assign our terrain game object to the Terrain field in the new terrain modifier");
            left.NewLine();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            right.ImageLeft("ShowTerrainPlateauA.png", 65);
            left.NewLine();
            left.NewLine();
            left.Text("Now you can press the 'Modify Terrain to match road' button to modify the terrain.");
            left.NewLine();
            left.TextBoldText("The ", "Plateau", " is set to 8 in this example");
            left.NewLine();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            right.ImageLeft("ShowTerrainPlateauB.png", 65);
            left.NewLine();
            left.NewLine();
            left.TextBoldText("The ", "Plateau", " is set to 0 in this example.");
            left.NewLine();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);
            right.ImageLeft("ShowTerrainPlateauC.png", 65);
            left.NewLine();
            left.NewLine();
            left.TextBoldText("The ", "Plateau", " is set to 8");
            left.NewLine();
            left.TextBoldText("The ", "Slope", " is set to 16");
            left.NewLine();

            outer.Text(options.Output());
            outer.NewLine();

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}