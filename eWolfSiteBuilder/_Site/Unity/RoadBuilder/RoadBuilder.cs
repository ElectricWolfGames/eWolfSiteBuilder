using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.RoadBuilder
{
    [PageTitle("RoadBuilder.html")]
    public class RoadBuilder : PageDetails, IHomePagePreview, IUnityList
    {
        public RoadBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Road Builder";
            MenuTitle = "Road Builder";
        }

        public int UnityListOrder { get; set; } = 1;

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
            items.Add(new HTMLIndexedItems("Creating your first road", CreateCreatingYourFirstRoad));
            items.Add(new HTMLIndexedItems("Modifying existing roads", CreateModifyingExistingRoads));
            items.Add(new HTMLIndexedItems("Materials Frequency", CreateMaterialsFrequency));
            items.Add(new HTMLIndexedItems("Defining the look of the roads", CreateDefiningTheLookOfTheRoads));
            items.Add(new HTMLIndexedItems("Dynamic road widths", CreateDynamicRoadWidths));
            items.Add(new HTMLIndexedItems("Override road materials", CreateOverrideRoadMaterials));
            items.Add(new HTMLIndexedItems("Rounded inner corners", CreateRoundedInnerCorners));
            items.Add(new HTMLIndexedItems("Baked Light map support", CreateBakedLightMapSupport));
            items.Add(new HTMLIndexedItems("Modify terrain", CreateModifyTerrain));
            items.Add(new HTMLIndexedItems("Closer nodes and 5 or 6 road junctions", CreateCloserModesAnd5or6RoadJunctions));
            items.Add(new HTMLIndexedItems("Faster mesh creation and AutoBuild", CreateFasterMeshCreationAndAutoBuild));
            items.Add(new HTMLIndexedItems("Render underside of the road", CreateRenderUndersideOfTheRoad));
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
                ImagePath = @$"{WebPage.HtmlPath}\Images\Unity3d_Road_Builder_Basic_road.gif",
                Description = "Road Builder Lets you create non-linear roads easily by using a network of nodes. With easy to use buttons to extrude, join, insert nodes and create mesh. Building new roads has never been so easy.",
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"This package has all you need to create 7 different road types from normal (with and with-out pavement), grass, sandy, race track and even a rail track. And you can add more road textures/materials as you need. You don’t need any programming skills to create amazing looking roads.");
            outer.NewLine();
            outer.NewLine();
            outer.Unity3DLink(Unity3DSetting.RoadBuilder);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateBakedLightMapSupport(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCloserModesAnd5or6RoadJunctions(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCreatingYourFirstRoad(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();

            outer.NewLine();

            outer.TextBoldText("In your scene add the prefab", " 'RoadNetwork_Main_pf' ", "from Assets->eWolfRoadBuilder->PreFabs folder.");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("1-3-FirstRoad.PNG", 65);

            right.StartTextCenterLeft();
            right.StartTextMiddel(350);
            right.Text("With this prefab selected, click on the Start new road button in the inspector. This adds a new road node to the scene as a child of the network node.");
            right.NewLine();
            right.NewLine();
            right.Text("Now select This new node and click the 'Extrude road' button. this is your first (and the smallest) road. Click on the 'Create Mesh' button from any node and it will create your road.");
            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());
            outer.NewLine();
            outer.YouTubeLinkBig("1JliMx_Rbqs");

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("1-4-MoreRoads.PNG", 65);

            left.StartTextCenterLeft();
            left.StartTextMiddel(350);
            left.Text("From here you can Extrude from any node, just select the node and press Extrude, Each node has a type (Union)");
            left.NewLine();
            left.NewLine();
            left.InspectorDetails("End", "One connection");
            left.InspectorDetails("Corner", "Two connection");
            left.InspectorDetails("Junction", "Three connection");
            left.InspectorDetails("Cross Roads", "Four connection");
            left.NewLine();
            left.NewLine();
            left.Text("You can't extrude from a node with 4 connections.");
            left.NewLine();
            left.NewLine();
            left.TextBoldText("Just press on the ", "'Create Mesh'", " to check your final mesh.");
            left.EndTextMiddel();
            left.EndTextCenterLeft();

            outer.Text(options.Output());
            outer.NewLine();
            outer.YouTubeLinkBig("jmNsxLSx4jY");

            return outer.Output();
        }

        private string CreateDefiningTheLookOfTheRoads(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("The look (contour) of the cross section of the road is customizable. With the options below");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("CrossSectionDetails.PNG", 75);

            right.StartTextCenterLeft();
            right.StartTextMiddel(300);
            right.InspectorDetails("Road Width", "The width of the road");
            //right.NewLine();
            right.InspectorDetails("With Curb", "If ticked will create a Curb");
            //right.NewLine();
            right.InspectorDetails("Curb Height", "How high the curb will be above the road");
            //right.NewLine();
            right.InspectorDetails("Curb Slope", "How far back the curb starts");
            //right.NewLine();
            right.InspectorDetails("Curb Width", "How wide the pavement section is");
            //right.NewLine();
            right.InspectorDetails("Curb Edge Drop", "If the curb is raised, then this can be used to fill the gap at the far side of the road");
            //right.NewLine();
            //right.NewLine();

            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());

            options = new HTMLBuilder();
            var a = new HTMLSection("col-md-4");
            var b = new HTMLSection("col-md-4");
            var c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("Cross_A.PNG", 85);
            b.ImageCenter("Cross_B.PNG", 85);
            c.ImageCenter("Cross_C.PNG", 85);

            outer.NewLine();
            outer.Text(options.Output());
            outer.NewLine();

            outer.YouTubeLinkBig("_duWhzp-VAk");
            outer.NewLine();
            outer.NewLine();

            outer.InspectorDetails("Create Collision", "Whether or not you need mesh collision on the road mesh object.");
            outer.InspectorDetails("Mesh Per Node", "If ticked this will separate the mesh and create it on each of the nodes. This is to help will object culling. if not set it will just add the roads as one mesh on the base object.");
            outer.InspectorDetails("Drop To Ground", "If ticked will drop the road to any object with layer set to 'Ground'. Note this could be slow for large roads.");
            outer.InspectorDetails("UV Set", "The main textures used for the roads have the road and pavements, 'ROAD_PAVEMENT' But if you are not using the Curb/Pavement this is wasteful and you should select the 'ROAD_ONLY' option that will use the full width of the texture as the road.");

            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Road_Main.PNG", 35);

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("Road_RoadOnly.PNG", 65);
            b.ImageCenter("Road_Grass.PNG", 65);
            c.ImageCenter("Road_Clean.PNG", 65);
            outer.NewLine();
            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("Road_Sandy.PNG", 65);
            b.ImageCenter("Road_RaceTrack.PNG", 65);
            c.ImageCenter("Road_RailTrack.PNG", 65);

            outer.NewLine();
            outer.Text(options.Output());

            return outer.Output();
        }

        private string CreateDynamicRoadWidths(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("With the release of Version 1.1 you can now set the Cross Section details per node. Allowing you to change the width of the road and the curb settings.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("RoadDifferentWidth.PNG", 65);
            outer.NewLine();
            outer.TextBoldText("Each Road Network Node now has the option to", " Override Cross Section", "");
            outer.NewLine();
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("SectionSetting.PNG", 65);
            right.ImageLeft("CrossSectionDetailsRemove.PNG", 65);
            outer.Text(options.Output());
            outer.NewLine();
            outer.TextBoldText("Just Click on the Add", " Override Cross Section ", "to override the settings");
            outer.NewLine();

            outer.Text("And the new script will be add to the object, that will let you set your Cross Sections Details.");
            outer.NewLine();
            outer.TextBoldText("If you need to remove the Cross sections Details just click on the", " Remove Cross Section ", "Button");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("qAS2fC5gw8o");

            return outer.Output();
        }

        private string CreateFasterMeshCreationAndAutoBuild(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.JumbotronImage(DisplayTitle, "Road Builder Lets you create non-linear roads easily by using a network of nodes. With easy to use buttons to extrude, join, insert nodes and create mesh. Building new roads has never been so easy.", "RoadBuilderLogo.PNG", 35);
            return outer.Output();
        }

        private string CreateMaterialsFrequency(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("On the Road Builder Script we have the Details section that lets you define how the different materials are applied to each road.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("For this example I'm just using 3 different textures/materials.");
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-4");
            HTMLSection b = new HTMLSection("col-md-4");
            HTMLSection c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("DevRoadA.PNG", 45);
            b.ImageCenter("DevRoadB.PNG", 45);
            c.ImageCenter("DevRoadC.PNG", 45);

            outer.NewLine();
            outer.Text(options.Output());

            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("3-Once.PNG", 65);
            outer.NewLine();
            outer.Text("The look of the road is defined from the set of material frequency items.");
            outer.NewLine();
            outer.TextBoldText("The first frequency you should always have set is the ", "Main Texture", " This applies the material to all of the road.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Once per road", "will set the material to just once section per road. you can see in the above example as the green section on the road.");
            outer.Text("This option is ideal for one off details like Manhole covers, drains, etc..");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Random 50 Percent", "Will replace the current material about 50 percent of the time.");
            outer.NewLine();
            outer.ImageCenter("3-50p.PNG", 65);
            outer.NewLine();
            outer.Text("This option is ideal for more common details like road damage etc..");
            outer.NewLine();
            outer.NewLine();
            outer.Text("All the options here can be stacked, adding a new 'Once per road' to our example will always set the once material on top of the other settings.");
            outer.NewLine();
            outer.ImageCenter("3-50pOnce.PNG", 65);
            outer.NewLine();
            outer.Text("So here you will get the Blue material on each road (Once per road), but you will get a mix of Yellow (Main) and Green (Random 50%)");
            outer.NewLine();
            outer.NewLine();

            outer.Text("The current list of options are listed below.");
            outer.NewLine();
            outer.NewLine();
            outer.InspectorDetails("Main Texture", "Base texture for the road");
            outer.InspectorDetails("Once Per Road", "Will only appear once per road");
            outer.InspectorDetails("Random 50 percent", "Will randomly appear about 50% of the time");
            outer.InspectorDetails("Random 25 percent", "Will randomly appear about 25% of the time");
            outer.InspectorDetails("Middle of Road", "Will appear in the middle of the road");

            outer.NewLine();
            outer.TextBoldText("You can add more by updating the code in the method SetMaterialsArray in the file ", "RoadConstructorHelper.cs", "");
            outer.NewLine();
            outer.NewLine();

            return outer.Output();
        }

        private string CreateModifyingExistingRoads(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"The options on the selected nodes will change if you have one or two nodes selected.");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            var options = new HTMLBuilder();
            var left = new HTMLSection("col-md-6");
            var right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.Text("Single Node selected");
            left.ImageRight("2-1-SingleNode.PNG", 65);

            right.Text("Double Node selected");
            right.ImageLeft("2-1-DoubleNode.PNG", 65);
            outer.Text(options.Output());

            outer.NewLine();
            outer.OtherDetails("Delete Node :-", "Select the node and use the 'Delete Node' button in the inspector to remove any nodes you no longer need. It's best to use the delete button as it updates the linked nodes");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Connect Nodes :-", "Select two nodes that are not connected, and press 'Connect nodes' to connect them.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Insert new Node :-", "Select two nodes that are connected, and press 'Insert new Node' to create a new node in between them.");
            outer.NewLine();

            return outer.Output();
        }

        private string CreateModifyTerrain(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateOverrideRoadMaterials(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateRenderUndersideOfTheRoad(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateRoundedInnerCorners(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}