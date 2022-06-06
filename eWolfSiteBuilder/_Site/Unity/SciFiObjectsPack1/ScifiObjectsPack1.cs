using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SciFiObjectsPack1
{
    [PageTitle("SciFiObjectsIndex.html")]
    public partial class ScifiObjectsPack1 : PageDetails, IHomePagePreview, IUnityList
    {
        public ScifiObjectsPack1()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Sci-Fi Objects Pack 1";
            MenuTitle = "Sci-fi Pack1";
        }

        public int UnityListOrder { get; set; } = 10;

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
            items.Add(new HTMLIndexedItems("Examples", CreateExamples));
            items.Add(new HTMLIndexedItems("Shelves", CreateShelves));
            items.Add(new HTMLIndexedItems("Inspector Actions", CreateInspector));
            items.Add(new HTMLIndexedItems("Floor Objects", CreateFloorObjects));
            items.Add(new HTMLIndexedItems("Randomize Scene", CreateRandomizeScene));
            items.Add(new HTMLIndexedItems("Other Objects", CreateOtherObjects));
            items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            items.Add(new HTMLIndexedItems("More Images", CreateMoreImages));
            items.Add(new HTMLIndexedItems("Project Layout", CreateProjectLayout));
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
                PreviewItemType = PreviewItemType.Models,
                ImagePath = @$"{WebPage.HtmlPath}\Images\SciFiObjectsPack1Ad.png",
                Description = "Collection of game ready objects you can just use in any sci-fi style game <br/>" +
                "Shelves are placed into the map empty, Then by clicking on the <strong>Fill All Shelves</strong> Button will populate all the shelves.</br>" +
                "The prefab <strong>ObjectsOnFloor_pf</strong> will let you place lots of random objects on the floor quickly."
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"Sci-Fi Objects pack 1 is a collection of game ready objects you can just use in any sci-fi style game.");
            outer.NewLine();
            outer.Text(@"That you can get from Unity3D asset store");
            outer.NewLine();
            outer.NewLine();
            outer.Unity3DLink(Unity3DSetting.ScifiObjectsPack1);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private static string CreateOtherObjects(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.Text("22 Other sci-fi objects can be placed in the scene");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Objects//AllObjects.png", 75);
            outer.NewLine();
            outer.TextBoldText("Most object also have the random colour option, By using the", " Controller_pf ", "to randomize all, or use the Randomize colour option on each object.");

            return outer.Output();
        }

        private static string CreateShelves(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Text("Shelves are placed in to the map empty, But by clicking on the");

            options.Bold(" Fill All Shelves");
            options.Text(" Button will populate all the shelves");
            options.NewLine();
            options.NewLine();
            options.YouTubeLinkBig("b-TmqGNFiLE");
            options.NewLine();
            return options.Output();
        }

        private string CreateExamples(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.NewLine();
            options.ImageCenter("RoomTests.png", 60);
            options.NewLine();
            options.ImageCenter("DarkRoomTest.png", 60);
            options.NewLine();
            return options.Output();
        }

        private string CreateFloorObjects(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.TextBoldText("The prefab", " ObjectsOnFloor_pf", " will let you place lots of random objects on the floor quickly.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("<div class='col-md-12'>");
            outer.YouTubeLinkBig("QBdR65Q5nkg");
            outer.Text("</div>");
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("ObjectsOnFloor-Inspector.PNG", 45);

            right.StartTextCenterLeft();
            right.StartTextMiddel(400);
            right.InspectorDetails("Count", "The number of objects to try and place in the zone");
            right.InspectorDetails("Locked ", "When you are happy with the objects on the floor, you can lock it so it will never get replaced.");
            right.InspectorDetails("Random Material Holder", "Holds the selection of materials to use when randomizing the objects and colour.");
            right.NewLine();
            right.TextBoldText("The collections have", " Boxes, Controllers, Jars, Junk and Tools", " The tick boxes allow you to have any arrangement of objects.");
            right.NewLine();
            right.InspectorDetails("Size", "The size of the zone to place the objects in.");
            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Sci-Fi Objects is a collection of game ready objects you can just use in any sci-fi style game.");
            return options.Output();
        }

        private string CreateInspector(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");

            options.SetTwoSections(left, right);

            left.ImageRight("Self-Inspector.PNG", 65);

            right.StartTextCenterLeft();
            right.StartTextMiddel(450);
            right.InspectorDetails("Clear Shelf", "Remove all objects from the shelfs");
            right.InspectorDetails("Fill all Shelves", "Replace objects to all shelf");
            right.InspectorDetails("Update Shelf 1", "Replace objects just to level 1");
            right.InspectorDetails("Update Shelf 2", "Replace objects just to level 2");
            right.InspectorDetails("Update Shelf 3", "Replace objects just to level 3");
            right.InspectorDetails("Update Shelf 4", "Replace objects just to level 4");
            right.InspectorDetails("Clear Shelf 1", "Clear objects just to level 1");
            right.InspectorDetails("Clear Shelf 2", "Clear objects just to level 2");
            right.InspectorDetails("Clear Shelf 3", "Clear objects just to level 3");
            right.InspectorDetails("Clear Shelf 4", "Clear objects just to level 4");
            right.InspectorDetails("Randomize Colour", "Randomize the colour only");
            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            outer.Text("The selection of objects in the shelf can be changed by using the <strong>Shelf Object Collection Options</strong>");
            outer.NewLine();
            outer.NewLine();

            outer.YouTubeLinkBig("ikaxhbyIDts");
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-4");
            right = new HTMLSection("col-md-8");
            options.SetTwoSections(right, left);

            left.ImageLeft("Shelf-Collections.PNG", 65);

            right.StartTextCenterRight();
            right.NewLine();
            right.NewLine();
            right.Text("The collections has Boxes, Controllers, Jars, Junk and Tools The tick boxes allow you to have any arrangement of objects.");
            right.NewLine();
            right.NewLine();
            right.Text("And by using the Update Shelf 1-4 options you can select a object type per level of the shelf");
            right.EndTextCenterRight();

            outer.Text(options.Output());

            outer.Title("Other Options");

            options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-2");
            HTMLSection b = new HTMLSection("col-md-10");
            HTMLSection c = new HTMLSection("col-md-2");
            options.SetThreeSections(a, b, c);

            b.NewLine();
            b.NewLine();
            b.StartTextCenterLeft();
            b.InspectorDetails("Levels On Shelf", "How many levels to use for this shelf. Some Shelves have fewer levels");
            b.InspectorDetails("Locked", " When you are happy with the objects on the shelf, you can lock it so it will never get replaced.");
            b.InspectorDetails("Random Material Holder", "Holds the selection of materials to use when randomizing the objects and colour.");
            b.InspectorDetails("Shelf Capacity", "How full to make the shelf");
            b.InspectorDetails("Shelf Collision Style", "'Quick' for just a simple box collision, 'Full' for more details collision");
            b.EndTextCenterLeft();

            outer.Text(options.Output());
            return outer.Output();
        }

        private string CreateMaterials(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.Text("All Objects just use one material *(apart from the colour versions)");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Materials.png", 55);
            outer.NewLine();
            outer.Text("* Apart from the Jars, Jars use a double sided version of the material and a Slime/Glass material.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("The 4 different colour version look like");
            outer.NewLine();
            outer.ImageCenter("Objects//Colours.png", 65);
            return outer.Output();
        }

        private string CreateMoreImages(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.Text("Here are all the shelf and floor objects.");
            outer.NewLine();
            outer.ImageCenter("Objects//AllShelfObjects.png", 75);
            outer.Text("And all the other objects");
            outer.NewLine();
            outer.NewLine();

            List<string> images = new List<string>
            {
                "Box_01_pf.png",
                "Box_02_pf.png",
                "Box_03_pf.png",
                "Box_04_pf.png",
                "Box_05_pf.png",

                "Canisters_01_pf.png",
                "Canisters_02_pf.png",
                "Canisters_03_pf.png",
                "Canisters_04_pf.png",
                "Canisters_05_pf.png",

                "CargoBox_01_pf.png",
                "CargoBox_02_pf.png",

                "ControlPost_01_pf.png",

                "Generator_01_pf.png",
                "Generator_02_pf.png",
                "Generator_03_pf.png",

                "Stair_01_pf.png",
                "Stair_02_pf.png",

                "WallPanel_01_pf.png",
                "WallPanel_02_pf.png",
                "WallPanel_03_pf.png",
                "WallPanel_04_pf.png"
            };

            outer.Text("<div class='row'>");

            foreach (string filename in images)
            {
                outer.ImageCard($"Objects//{filename}", 85);
            }

            outer.Text("</div>");

            outer.NewLine();
            outer.YouTubeLinkBig("VP784HWtojE");

            return outer.Output();
        }

        private string CreateProjectLayout(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.TextBoldText("All of the objects, scripts and prefabs are under the", " eWolf ", "folder");
            outer.NewLine();
            outer.ImageCenter("Folders.png", 30);
            outer.Text("And all the scripts are contained with in the two namespace's");
            outer.NewLine();
            outer.Bold("eWolf.Common");
            outer.Text(" and ");
            outer.Bold("eWolf.SciFiObjects");
            outer.NewLine();
            outer.NewLine();
            outer.NamedUnity3DLink("Sci-Fi objects pack 1", Unity3DSetting.ScifiObjectsPack1);

            return outer.Output();
        }

        private string CreateRandomizeScene(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.TextBoldText("The prefab", " Controller_pf ", "from the common folder, will let you randomize all the objects in the scene with just one button.");
            outer.EndTextCenter();
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("LVIEtjA7NiA");
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("Controller-Inspector.PNG", 65);

            right.InspectorDetails("Randomize All", "Randomize all the object in the scene, unless they have been locked");
            right.InspectorDetails("Randomize Visual", "Randomize the colour or look of all the objects in the scene, unless they have been locked");

            outer.Text(options.Output());
            return outer.Output();
        }
    }
}