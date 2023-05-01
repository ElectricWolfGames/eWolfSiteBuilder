using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SciFiModularRooms
{
    [PageTitle("SciFiModularRoomsTroubleShooter.html")]
    public class SciFi_Modular_Rooms_TroubleShooter_eWolf : PageDetails
    {
        public SciFi_Modular_Rooms_TroubleShooter_eWolf()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Sci-Fi Modular Rooms TroubleShooter";
            MenuTitle = "Sci-Fi Modular Rooms TroubleShooter";
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

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", AddSectionDownload));
            items.Add(new HTMLIndexedItems("Removing White Lines", AddRemovingWhiteLines));
            items.Add(new HTMLIndexedItems("Light Flares not facing player", AddSectionFixLightFlares));
            items.Add(new HTMLIndexedItems("Trying to read Input ", AddSectionTryingToReadInput));
            items.Add(new HTMLIndexedItems("Magenta Models", AddSectionMagenta));

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

        private static string AddSectionMagenta(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.NewLine();
            outer.Text("If you import Sci-Fi Modular Rooms in to a project and find the material are magenta.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("MagentaMaterials.PNG", 45);
            outer.NewLine();
            outer.NewLine();
            outer.Text("We will need to update our material to match the project render pipeline.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Sci-Fi Modular Rooms is using Standard Shader for the materials,");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("If your project is using ", "Universal Render Pipeline", " Then we can update our materials");
            outer.NewLine();
            outer.NewLine();
            outer.Text(@"Open the material Rooms001 (eWolf\SciFi_Rooms_Pack1\Art\Materials)");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Select Universal Render Pipeline -> Backed Lit shader");
            outer.NewLine();
            outer.TextBoldText("Then just update the BaseMap with the", " Room001_albedo ", "Texture");
            outer.ImageCenter("UpdateMaterials.PNG", 35);

            outer.EndTextCenter();

            return outer.Output();
        }

        private static string AddSectionTryingToReadInput(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text(@"If you get the messages");
            outer.NewLine();
            outer.NewLine();
            outer.Bold(@"You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling to Input System package in Player Settings.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Then go to Project Setting -> Player");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("PlayerSettings.PNG", 45);
            outer.TextBoldText("Update ", "Active Input Handing", " to use Both");
            outer.NewLine();

            outer.EndTextCenter();

            /*InvalidOperationException: You are trying to read Input using the UnityEngine.Input class, but you have switched active Input handling to Input System package in Player Settings.
UnityEngine.Input.GetKeyDown (System.String name) (at <f54f1818644d43d89bbc43937d848865>:0)
eWolf.Common.Helper.SceneHelpers.UpdateSnapshot () (at Assets/eWolf/Common/Scripts/Helper/SceneHelpers.cs:10)
eWolf.SciFi_Rooms_System.Players.RoomInteractor.Update () (at Assets/eWolf/SciFi_Rooms_System/Scripts/Players/RoomInteractor.cs:45)

*/

            return outer.Output();
        }

        private string AddRemovingWhiteLines(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text(@"If you see bits of white lines in the scene");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("WhiteLines.PNG", 65);
            outer.NewLine();
            outer.NewLine();
            outer.Text(@"Then we just need to set the camera colour to black.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("SetCameraColor.PNG", 30);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionDownload(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.Text($"{DisplayTitle} Is a collection of easy to fix Sci-Fi rooms and corridors.");
            outer.NewLine();
            outer.NewLine();
            outer.Unity3DLink(Unity3DSetting.SciFiModularRooms_eWolf);
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string AddSectionFixLightFlares(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.NewLine();
            outer.Text(@"When the light flare don't rotate to face the player.");
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("BrokenFlares.PNG", 54);
            outer.NewLine();
            outer.NewLine();

            outer.Text("With in the code just update FacePlayer, to be the name of the player object you need the flares to face.");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Code-UpdatePlayerName.PNG", 54);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Sci-Fi Modular Rooms TroubleShooter Guide");
            return options.Output();
        }
    }
}