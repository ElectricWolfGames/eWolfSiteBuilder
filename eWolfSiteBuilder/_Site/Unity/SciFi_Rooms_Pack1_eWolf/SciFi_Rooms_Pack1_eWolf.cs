using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System;
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

            //items.Add(new HTMLIndexedItems("Connection Types", CreateConnectionTypes));
            //items.Add(new HTMLIndexedItems("Randomize All Fillers", CreateRandomizeAllFillers));

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

            outer.TextBoldText("", "1. Place all objects under right parents", " Will place all the rooms in to level folders, This is to just make things easyer to find if you have a map with different levels");
            outer.NewLine();
            outer.ImageCenter("RoomsLevel00Folder.PNG", 55);
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("", "2. Randomize All Fillers", " Will add extra random details to some rooms (see more later)");

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
    }
}