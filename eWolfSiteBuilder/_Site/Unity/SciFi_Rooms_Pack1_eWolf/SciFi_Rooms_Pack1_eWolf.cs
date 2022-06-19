using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SciFi_Rooms_Pack1_eWolf
{
    [PageTitle("SciFiModularRooms.html")]
    public class SciFi_Rooms_Pack1_eWolf : PageDetails
    {
        public SciFi_Rooms_Pack1_eWolf()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Sci-Fi Modular Rooms - eWolf";
            MenuTitle = "Sci-Fi Modular Rooms - eWolf";
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

            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Create First Rooms", CreateCreateFirstRooms));
            items.Add(new HTMLIndexedItems("Player setup", CreatePlayerSetUp));

            items.Add(new HTMLIndexedItems("Connection Types", CreateConnectionTypes));

            items.Add(new HTMLIndexedItems("Lighting", CreateLighting));
            items.Add(new HTMLIndexedItems("Randomize All Fillers", CreateRandomizeAllFillers));

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

        private static string CreateConnectionTypes(string arg)
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

        private static string CreateDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text(@"That you can get from Unity3D asset store");
            outer.NewLine();
            outer.NewLine();
            outer.Unity3DLink(Unity3DSetting.SciFi_Rooms_Pack1_eWolf);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private static string CreateLighting(string arg)
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
            outer.Text("And the LightMapper should be Progressice CPU.");
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
            outer.Text("And then to add a light fog, Click on the Enviroment tab.");
            outer.NewLine();
            outer.Text("Then just set the Fog Color and Density.");
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

        private static string CreateRandomizeAllFillers(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCreateFirstRooms(string arg)
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

            left.ImageRight("RoomLinks.PNG", 45);
            right.Text("The room links drop down lists allow you to select what room/corridor you would like to add");
            right.NewLine();
            right.Text("It will only give you the options for that connection type.");

            outer.Text(options.Output());
            outer.Text("When selected just click add to add it to the scene.");
            outer.ImageCenter("RoomLinksAdd.PNG", 25);
            outer.NewLine();
            outer.NewLine();
            outer.Text("It will add it and select it");
            outer.NewLine();

            outer.ImageCenter("Room2.PNG", 45);
            outer.OtherDetails("NOTE:", "You may need to move or rotate the new room/corridor to make it snap in place");
            outer.NewLine();
            outer.NewLine();
            outer.Text("The new rooms - rooms links will show the new options, but also show where a room is all ready connected");
            outer.NewLine();
            outer.ImageCenter("Room2Links.PNG", 25);
            outer.NewLine();
            outer.Text("This also show the different connection types - 'Door' and 'corridor'");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Now you can continue to add as many roos and corridors as you like.");

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
            right.OtherDetails("1 - 4 Do all", "Handy do all the aboce in one step");

            outer.Text(options.Output());

            outer.NewLine();
            outer.NewLine();

            outer.OtherDetails("1. Place all objects under right parents", " Will place all the rooms in to level folders");
            outer.NewLine();
            outer.Text("This is to just make things easyer to find if you have a map with different levels");
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
            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.Text("Before Bake");
            left.ImageRight("PreLightBake.PNG", 80);

            right.Text("After Bake");
            right.ImageLeft("PostLightBake.PNG.", 80);
            outer.Text(options.Output());
            outer.Text("While, not a lot of different - it's much faster as the lighting is fully backed in.");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Sci-Fi Modular Rooms, Lets you easyly create sci fi base rooms and corridors with a helpful selection and snapping system.");
            return options.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("");
            // what this pack can do!

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreatePlayerSetUp(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text("To make the doors open you just need two things");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("Your player object needs to have the script ", "RoomInteractor", " ");
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

            outer.EndTextCenter();

            return outer.Output();
        }
    }
}