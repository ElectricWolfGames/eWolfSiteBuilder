using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SciFiModularRooms
{
    // TODO : Talk about the materials being standard

    [PageTitle("SciFiModularRooms.html")]
    public class SciFi_Rooms_Pack1_eWolf : PageDetails /*IHomePagePreview, IUnityList*/
    {
        public SciFi_Rooms_Pack1_eWolf()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Sci-Fi Modular Rooms";
            MenuTitle = "Sci-Fi Modular Rooms";
        }

        public int UnityListOrder { get; set; } = 1;

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

            items.Add(new HTMLIndexedItems("Overview", AddSectionOverview));
            items.Add(new HTMLIndexedItems("Download", AddSectionDownload));
            items.Add(new HTMLIndexedItems("Create First Rooms", AddSectionCreateFirstRooms));
            items.Add(new HTMLIndexedItems("Player set-up", AddSectionPlayerSetUp));

            items.Add(new HTMLIndexedItems("Connection Types", AddSectionConnectionTypes));
            items.Add(new HTMLIndexedItems("Doors", AddSectionDoors));

            items.Add(new HTMLIndexedItems("Lighting", AddSectionLighting));
            items.Add(new HTMLIndexedItems("Randomize All Fillers", AddSectionRandomizeAllFillers));
            items.Add(new HTMLIndexedItems("Adding you own Rooms", AddSectionAddYouOwnRoom));
            items.Add(new HTMLIndexedItems("Adding you own Wall Fillers", AddSectionAddYouOwnWallFillers));
            items.Add(new HTMLIndexedItems("Project layout", AddSectionProjectLayout));

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

        private static string AddSectionConnectionTypes(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("Currently this package has 4 different connection types.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("R01_Door", "Single width door - places small door on connection");
            outer.OtherDetails("R01_Corridor", "Corridor connection (No door)");
            outer.OtherDetails("R01_Window", "Window connection - places window on connection");
            outer.OtherDetails("R01_CorridorBlastDoor", "Blast door Corridor connection - places Blast door on connection");
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("Room2Links.PNG", 30);
            outer.NewLine();
            outer.Text("Rooms links will only allow you to add a room/corridor with the same connection type.");
            outer.NewLine();
            outer.NewLine();
            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.Text("Small door");
            left.ImageRight("DoorType-Small.PNG", 65);
            right.Text("Blast door");
            right.ImageLeft("DoorType-Blast.PNG", 70);
            outer.Text(options.Output());

            outer.Text("Window");
            outer.ImageCenter("DoorType-Window.PNG", 45);

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.Text("Door list");
            left.ImageRight("Item_List-Door.PNG", 50);
            right.Text("Corridor list");
            right.ImageLeft("Item_List-Corridors.PNG", 50);

            outer.Text(options.Output());

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.Text("Blast Door list");
            left.ImageRight("Item_List-BlastDoor.PNG", 50);
            right.Text("Windows list");
            right.ImageLeft("Item_List-Window.PNG", 50);

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();
            outer.Text("All doors have two different versions, Normal and Fake.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("Normal Doors", "Have a green light on them and will open.");
            outer.NewLine();
            outer.OtherDetails("Fake Doors", "Are added when the door leads nowhere.");
            outer.Text("They can't open and have no green light");
            outer.ImageCenter("FakeAndNormalDoors.PNG", 65);

            outer.EndTextCenter();

            return outer.Output();
        }

        private static string AddSectionLighting(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("The prefabs in this package are all using Baked Lights");
            outer.NewLine();
            outer.NewLine();
            outer.Text("I wouldn't try to give expert light advice here, But I would like to show how to create a basic set-up in you scene.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("First, remove any default lights from the scene.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Open the Lighting Window.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Lighting-Create.PNG", 65);
            outer.NewLine();
            outer.Text("And create a new lightmap setting file.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Make sure you have Mixed Lighting - Baked Global Illumination - ticked");
            outer.NewLine();
            outer.Text("And the LightMapper should be Progressive CPU.");
            outer.NewLine();
            outer.Text("And also tick the Ambient Occlusion.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Lighting-Settings.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("Other options here can be used to change the speed/detail of the bake.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("And then to add a light fog, Click on the Environment tab.");
            outer.NewLine();
            outer.Text("Then just set the Fog Colour and Density.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Lighting-SettingsFog.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("And that should be all you need, Now you can click on the Generate lighting.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("I've added some simple lighting setting that you can use.");
            outer.NewLine();
            outer.Bold("BasicFast");
            outer.NewLine();
            /*outer.Bold("BasicLightFog");
            outer.NewLine();
            outer.Bold("BasicDeepFog");
            outer.NewLine();*/
            outer.NewLine();

            outer.Text("All the lights in this package have flares, that will auto rotate to face the player.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("You may need to update the code with the name of the place in the code");
            outer.NewLine();
            outer.Bold(@"\Assets\eWolf\Common\Scripts\FacePlayer.cs");
            outer.NewLine();

            // note about face player code.
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private static string AddSectionRandomizeAllFillers(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("Rooms can look a bit empty when first created.");
            outer.NewLine();

            outer.NewLine();
            outer.ImageCenter("RoomFillerEmpty.PNG", 55);
            outer.NewLine();
            outer.NewLine();
            outer.Text("So I've added an option to add extra details to the empty walls.");
            outer.NewLine();
            outer.ImageCenter("RoomFillerV1.PNG", 45);
            outer.NewLine();
            outer.ImageCenter("RoomFillerV2.PNG", 45);
            outer.TextBoldText("Clicking on the ", "2. Randomize All Fillers", " Will randomize the fillers on the walls.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Sometimes you will need to keep some walls clear.");
            outer.NewLine();
            outer.Text("You can easily just turn off the wall fillers.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("RoomFillerOptions.PNG", 45);
            outer.NewLine();
            outer.Text("Disabled the option will stop the wall filers from appearing");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionAddYouOwnRoom(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("You can also added new rooms to the system.");
            outer.NewLine();
            outer.Text("If you would like a copy of the Blender file used to create the rooms in this package. please email me, (Email below)");
            outer.NewLine();
            outer.NewLine();
            outer.NewLine();
            outer.Text("When you have your new model in the project");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Unselect ");
            outer.NewLine();
            outer.OtherDetails("Import BlendShapes", "");
            outer.OtherDetails("Import Visibility", "");
            outer.OtherDetails("Import Cameras", "");
            outer.OtherDetails("Import Lights", "");
            outer.NewLine();

            outer.ImageCenter("NewRoomSettingA.PNG", 30);
            outer.NewLine();
            outer.Text("And tick the Generate Light UVs (As you this is needed for the light baking)");
            outer.ImageCenter("NewRoomSettingB.PNG", 30);

            outer.NewLine();
            outer.Text("And finally, On the Materials Tab and select None on the Material Creation Mode.");
            outer.NewLine();
            outer.ImageCenter("NewRoomSettingC.PNG", 30);

            outer.NewLine();
            outer.NewLine();
            outer.NewLine();
            outer.Text("Next, We need to create the prefab, (sometime it's quicker to copy an existing prefab.)");
            outer.NewLine();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("RoomPrefabLayout.PNG", 55);
            right.StartTextMiddel(300);

            right.OtherDetails("Art", "This holder the mesh for the room.");
            right.OtherDetails("Links", "All the Connection links to others rooms");
            right.OtherDetails("RoomIDCollision", "Box collider that outlines the room.");
            right.OtherDetails("Lights", "All the lights for the room");
            right.OtherDetails("Collision", "The full mesh collider");
            right.OtherDetails("RoomObjects", "Is for any extra objects you want to add to the room.");
            right.OtherDetails("Effects", "For extra effects, Light Flare are added here.");
            right.EndTextMiddel();

            outer.NewLine();
            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("And the base object will need the script ", "Room", "");
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("Once added you will need to update ", "RoomInfomation.cs", "");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("CodeRoomInfomation.PNG", 55);
            outer.NewLine();
            outer.Text("RoomInfomation contains a list of all the rooms, with the door connection link types.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Just add your new room to the section where you would like it to appear.");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionAddYouOwnWallFillers(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("We currently have 5 wall fillers");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Should you wish to add more, just follow the add room steps to get the model in unity3d.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Then place your new wall filler in the R01-RoomFillers/Resources folder with the others");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Now add the name of the prefab in to the list of fillers.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("NewWallFillers.PNG", 45);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionCreateFirstRooms(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.TextBoldText("To start creating room, We just need to add the prefab ", @"Assets\eWolf\SciFi_Rooms_System\Scripts\Prefabs\Map_pf.prefab", "");
            outer.NewLine();
            outer.NewLine();
            outer.Text("in to your scenes, and with it selected you will see.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Map-Inspector.PNG", 25);
            outer.NewLine();
            outer.NewLine();
            outer.Text("You could just drop in any of the room or corridor prefabs on to this object,");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("Or you can just click on the ", "0. Add Starting Corridor", " option");
            outer.NewLine();

            outer.Text("This will add the basic starting corridor,");
            outer.NewLine();
            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("BasicStartCorridor.PNG", 45);
            right.ImageLeft("Hierarchy.PNG", 45);
            outer.Text(options.Output());
            outer.NewLine();
            outer.Text("And select it by default.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("From here you can add more");
            outer.NewLine();

            outer.ImageCenter("FirstRoomOptions.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("RoomLinks.PNG", 64);
            right.Text("The room links drop down lists allow you to select what room/corridor you would like to add");
            right.NewLine();
            right.Text("It will only give you the options for that connection type.");

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("RoomLinksAdd.PNG", 64);
            left.NewLine();
            left.Text("When selected just click add to add it to the scene.");

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("Room2.PNG", 45);
            outer.OtherDetails("NOTE:", "You may need to move or rotate the new room/corridor to make it snap in place");
            outer.NewLine();
            outer.NewLine();
            outer.Text("When you select a room it will show you what options you have to add next room.");
            outer.NewLine();
            outer.Text("It will also show where a room is all ready connected");
            outer.NewLine();
            outer.ImageCenter("Room2Links.PNG", 25);
            outer.NewLine();
            outer.Text("This also show the different connection types - 'Door' and 'corridor'");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Now you can continue to add as many rooms and corridors as you like.");

            outer.NewLine();
            outer.NewLine();
            outer.Text("Once you have an area you wish to test");
            outer.NewLine();
            outer.TextBoldText("re-select the ", "Map_pf", " gameObject");
            outer.NewLine();
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("Options.PNG", 65);
            right.Text("");
            right.NewLine();
            right.OtherDetails("1. Place all objects under right parents", "This is to move all the object under the map_pf object, in to folders.");
            right.OtherDetails("2. Randomize All Fillers", "Some rooms have extra random details");
            right.OtherDetails("3. Add Missing Doors & Effects", "To add the Door at the points of the links");
            right.OtherDetails("4. Generate Lighting", "Generate lighting for the rooms");
            right.OtherDetails("1 - 4 Do all", "Handy do all the above in one step");

            outer.Text(options.Output());

            outer.NewLine();
            outer.NewLine();

            outer.OtherDetails("1. Place all objects under right parents", " Will place all the rooms in to level folders");
            outer.NewLine();
            outer.Text("This is to just make things easier to find if you have a map with different levels");
            outer.NewLine();
            outer.ImageCenter("RoomsLevel00Folder.PNG", 45);
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("2. Randomize All Fillers", " Will add extra random details to some rooms (see more later)");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("3. Add Missing Doors & Effects", " Will add the doors to the map");
            outer.NewLine();
            outer.NewLine();
            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("AddedDoor.PNG", 65);
            right.ImageLeft("AddedDoorList.PNG.", 75);
            outer.Text(options.Output());

            outer.Text("It's created the door as a Fake door, this is due to the door leading now where.");
            outer.NewLine();
            outer.Text("And will not open.");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("4. Generate Lighting", " Will bake in the lighting for the rooms.");
            outer.NewLine();
            outer.Bold("NOTE: Scene need to be set to use light map/backing - see Setting up Lighting section");
            outer.NewLine();
            outer.Text("All lights in prefabs are set-up as Baked.");
            outer.NewLine();
            outer.NewLine();

            outer.Text("After Bake");
            outer.ImageCenter("PostLightBake.PNG.", 45);
            outer.Text("it's much faster as the lighting is fully backed in.");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionDoors(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.TextBold("When the doors are added they are all added to the folder", " RoomDoors");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("DoorShowAll.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("DoorInspector.PNG", 55);
            outer.NewLine();
            outer.OtherDetails("Door Action", "Lets you set how the operate when you get close.");
            outer.OtherDetails("Door Action Range", "Is how close you need to be to action the door.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Only Fake, and AutoOpen work, the rest of the options are for your Implementation");
            outer.NewLine();
            outer.NewLine();
            outer.TextBold("You can override the default doors actions, by stetting", " Action&lt;Door&gt; DoorOpenLogic");
            outer.NewLine();
            outer.Text("If DoorOpenLogic is set it will get called instead of the normal door code.");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.Text($"{DisplayTitle} Is a collection of easy to fix sci-fi rooms and corridors.");
            outer.NewLine();
            outer.NewLine();
            outer.Unity3DLink(Unity3DSetting.SciFiModularRooms_eWolf);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.TextBoldText("", DisplayTitle, "Is a collection of easy to fix rooms and corridors.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("All rooms snap together saving time on aligning objects");
            outer.NewLine();
            outer.Text("It also has a step by step builder that only gives to options to add rooms you can connect");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("ExampleRoomsA.PNG", 45);
            outer.NewLine();
            outer.NewLine();
            outer.Text("Giving you nearly endless layout options");
            outer.NewLine();

            var options = new HTMLBuilder();
            var left = new HTMLSection("col-md-6");
            var right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("MapA.PNG", 80);
            right.ImageLeft("MapB.PNG.", 80);
            left.NewLine();
            right.NewLine();
            left.ImageRight("MapA.PNG", 80);
            right.ImageLeft("MapB.PNG.", 80);

            outer.Text(options.Output());
            outer.NewLine();
            outer.Text("When the rooms are in place, it's just one click to add all the doors to connect them");
            outer.NewLine();
            outer.NewLine();
            outer.Text("And the doors will hide the rooms behind them when closed, saving render time");
            outer.NewLine();
            outer.NewLine();

            outer.NewLine();

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionPlayerSetUp(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("To make the doors open you just need two things");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("Your player object needs to have the script ", "RoomInteractor", " or at least something that is using IRoomInteractor");
            outer.NewLine();
            outer.TextBoldText("And the script ", "MainGameFlow", " anywhere in the project");
            outer.NewLine();
            outer.NewLine();
            outer.Text("We have prefabs for both. ");
            outer.NewLine();
            outer.NewLine();
            outer.OtherDetails("MainGameFlow_pf", "This can live anywhere in the scene");
            outer.OtherDetails("TempPlayer_pf", "This needs to be under map_pf object.(This is just a camera, no player control)");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("AddedPlayerMain.PNG", 35);
            outer.NewLine();
            outer.Text("Once both are added, You can run the game");
            outer.NewLine();
            outer.ImageCenter("RunningDoorClosed.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("When you move the player object towards the door it will open");
            outer.NewLine();
            outer.ImageCenter("RunningDoorOpen.PNG", 65);
            outer.NewLine();
            outer.Text("And the room behind the door will unhide, but for the door opens");
            outer.NewLine();
            outer.NewLine();
            outer.Text("If you move more in to the room, the door will close and hide the rooms behind it.");
            outer.ImageCenter("RunningDoorInRoom.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text("This also works for more then one player");
            outer.ImageCenter("MoreThenOnePlayer.PNG", 65);
            outer.Text("Each player will keep the room active.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("This also works for other things like CCTV.");
            outer.NewLine();
            outer.Text("Just make sure your object has the RoomInteractor Script to keep the room active.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("RoomInteractor also has the option to open doors, turn this off and RoomInteractor will not open the door, but still keep the room active.");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionProjectLayout(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("All the assests for this project are under the eWolf folder");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("ProjectLayoutTop.PNG", 50);
            outer.NewLine();
            outer.NewLine();
            outer.Text("All the code is under two NameSpace");
            outer.NewLine();
            outer.Text("namespace eWolf.Common");
            outer.NewLine();
            outer.Text("namespace eWolf.SciFi_Rooms_System");
            outer.NewLine();
            outer.NewLine();
            outer.Text("So when its imported in to you project, you will know where to find it");
            outer.NewLine();

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Sci-Fi Modular Rooms, Lets you easily create sci fi base rooms and corridors with a helpful selection and snapping system.");
            return options.Output();
        }
    }
}