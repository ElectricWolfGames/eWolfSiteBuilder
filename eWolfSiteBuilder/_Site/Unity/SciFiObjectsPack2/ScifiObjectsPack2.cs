using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SciFiObjectsPack2
{
    [PageTitle("SciFiObjects2Index.html")]
    internal class ScifiObjectsPack2 : PageDetails, IHomePagePreview, IUnityList
    {
        public ScifiObjectsPack2()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Sci-Fi Objects Pack 2";
            MenuTitle = "Sci-fi Pack2";
        }

        public int UnityListOrder { get; set; } = 11;

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
            items.Add(new HTMLIndexedItems("Cargo", CreateCargo));
            items.Add(new HTMLIndexedItems("Debris", CreateDebris));
            items.Add(new HTMLIndexedItems("Desk", CreateDesk));
            items.Add(new HTMLIndexedItems("Equipment", CreateEquipment));
            items.Add(new HTMLIndexedItems("Living Quarters", CreateLivingQuarters));
            items.Add(new HTMLIndexedItems("Lockers", CreateLockers));
            items.Add(new HTMLIndexedItems("Scenery", CreateScenery));
            items.Add(new HTMLIndexedItems("Screens", CreateScreens));
            items.Add(new HTMLIndexedItems("Animations", CreateAnimations));
            items.Add(new HTMLIndexedItems("Scripts Used", CreateScriptsUsed));
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
                PreviewItemType = PreviewItemType.Models,
                ImagePath = @$"{WebPage.HtmlPath}\images\SciFiObjectsPack2Ad.png",
                Description = "Collection of game ready objects you can just use in any sci-fi style game.</br>" +
                "<strong>Contains:</strong> Cargo, Debris, Desks, Equipment, Living Quarters, Bed, Chairs, Lockers, Scenery, Screens, etc."
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text(@"Sci-Fi Objects pack 2 is a collection of game ready objects you can just use in any sci-fi style game.");
            options.NewLine();
            options.Unity3DLink(Unity3DSetting.ScifiObjectsPack2);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateAnimations(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.TextBoldText("All of the objects, scripts and prefabs are under the ", "eWolf", " folder");
            options.NewLine();
            options.NewLine();
            options.ImageCenter("Project.PNG", 35);
            options.NewLine();
            options.Text("And all the scripts are contained with in the two namespace's");
            options.NewLine();
            options.Text("<strong>eWolf.Common</strong> and <strong>eWolf.SciFiObjects_Pack2</strong>");
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateCargo(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of cargo pallets with different items on them, as well as an empty one.");
            options.NewLine();
            options.NewLine();
            options.ImageCenter("CargoA.png", 65);
            options.NewLine();
            options.Text(@"With one large container that has a animation for opening and closing.");
            options.ImageCenter("CargoB.png", 65);
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateDebris(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Debris");
            options.EndTextCenter();
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("DebrisA.png", "DebrisB.png"));

            return options.Output();
        }

        private string CreateDesk(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Desks");
            options.EndTextCenter();
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("DesksA.png", "DesksB.png"));

            return options.Output();
        }

        private string CreateEquipment(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Equipment");
            options.EndTextCenter();
            options.NewLine();

            options.Text(PageDetailsHelper.TwoImages("EquipmentA.png", "EquipmentB.png"));

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Sci-Fi Objects Pack 2 is a collection of game ready objects you can just use in any sci-fi style game.");
            return options.Output();
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

        private string CreateLivingQuarters(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Living Quarters");
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            options.Text(PageDetailsHelper.TwoImages("LivingQuartersA.png", "LivingQuartersB.png"));
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("LivingQuartersC.png", "LivingQuartersD.png"));

            return options.Output();
        }

        private string CreateLockers(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Lockers");
            options.NewLine();
            options.Text(@"All 3 animate and will save the state (Remember if they are open or closed)");
            options.EndTextCenter();
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("LockersA.png", "LockersB.png"));
            options.NewLine();
            options.ImageCenter("LockersC.png", 35);

            return options.Output();
        }

        private string CreateScenery(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Scenery");
            options.NewLine();
            options.EndTextCenter();
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("SceneryB.png", "SceneryA.png"));

            return options.Output();
        }

        private string CreateScreens(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();
            options.Text(@"A selection of Screens");
            options.EndTextCenter();
            options.NewLine();
            options.NewLine();
            options.Text(PageDetailsHelper.TwoImages("ScreensB.png", "ScreensA.png"));
            options.NewLine();
            return options.Output();
        }

        private string CreateScriptsUsed(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.NewLine();
            options.InspectorDetails("eWolf.Common.FacePlayer", "Used to rotate an object to face the player.");
            options.InspectorDetails("eWolf.Common.PlaceInRoom", "Uses a ServiceLocator, so you can add anything you want it to do here, by just using an IMapController");
            options.InspectorDetails("eWolf.SciFiObjects_Pack2.InteractiveObjects", "Just set Operate when you want the object to do it's action. It also saves it's state.");
            options.InspectorDetails("eWolf.SciFiObjects_Pack2.FanBlades", "Spins the fan blades, with speed options");
            options.NewLine();
            return options.Output();
        }
    }
}