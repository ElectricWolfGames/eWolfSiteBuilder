using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.GardenFlowers
{
    [PageTitle("GardenFlowers.html")]
    public class GardenFlowers : PageDetails, IHomePagePreview, IUnityList
    {
        public GardenFlowers()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Garden Flowers";
            MenuTitle = "Garden Flowers";
        }

        public int UnityListOrder { get; set; } = 15;

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
            items.Add(new HTMLIndexedItems("Collection", CreateCollection));
            items.Add(new HTMLIndexedItems("Easy placement", CreateEasyPlacement));
            items.Add(new HTMLIndexedItems("Render Optimization", CreateRenderOptimization));
            items.Add(new HTMLIndexedItems("Examples", CreateExamples));
            items.Add(new HTMLIndexedItems("Demo", CreateDemo));
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
                ImagePath = @$"{WebPage.HtmlPath}\images\GardenFlowers.png",
                Description = "A collection of low poly garden flowers for Unity3D. Flowers have individual prefabs and also a collection of Flower Beds prefabs with pre-arranged groups of flowers for easy placement"
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text(@"That you can get from Unity3D asset store");
            options.NewLine();
            options.NewLine();
            options.Unity3DLink(Unity3DSetting.GardenFlowers);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateCollection(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"16 Flower/plant prefabs");
            outer.NewLine();
            outer.NewLine();
            outer.TextBoldText("", "Asters ", "- 3 versions");
            outer.NewLine();
            outer.TextBoldText("", "EvergreenShrubs ", "- 2 versions");
            outer.NewLine();
            outer.TextBoldText("", "Hosta - Devon Green ", "- 2 versions");
            outer.NewLine();
            outer.TextBoldText("", "Lavender ", "- 1 version");
            outer.NewLine();
            outer.TextBoldText("", "Rhododendron ", "- 2 versions");
            outer.NewLine();
            outer.TextBoldText("", "Rose ", "- 2 versions");
            outer.NewLine();
            outer.TextBoldText("", "SunFlower ", "- 2 versions");
            outer.NewLine();
            outer.TextBoldText("", "Tulips ", "- 2 versions");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Each as a prefab");
            outer.NewLine();
            outer.NewLine();

            outer.NewLine();
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-4");
            HTMLSection b = new HTMLSection("col-md-4");
            HTMLSection c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("AstersA_pf.png", 85);
            b.ImageCenter("GreenShrubA_pf.png", 85);
            c.ImageCenter("Hosta_DevonGreenA_pf.png", 85);
            outer.Text(options.Output());

            outer.NewLine();
            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("LavenderA_pf.png", 85);
            b.ImageCenter("RhododendronB_pf.png", 85);
            c.ImageCenter("RoseB_pf.png", 85);
            outer.Text(options.Output());

            outer.NewLine();
            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("SunFlowerA_pf.png", 85);
            b.ImageCenter("TulipB_Red_pf.png", 85);
            c.ImageCenter("AstersB_pf.png", 85);
            outer.Text(options.Output());

            return outer.Output();
        }

        private string CreateDemo(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("<div class='sketchfab-embed-wrapper'>");
            outer.Text("<iframe width='640' height='480' src='https://sketchfab.com/models/9f39e298cf4d401893e6c024273610f0/embed' frameborder='0' allowvr allowfullscreen mozallowfullscreen='true' webkitallowfullscreen='true' onmousewheel=''></iframe>");
            outer.Text("<p style='font-size: 13px; font-weight: normal; margin: 5px; color: #4A4A4A;'>");
            outer.Text("<a href='https://sketchfab.com/models/9f39e298cf4d401893e6c024273610f0?utm_medium=embed&utm_source=website&utm_campain=share-popup' target='_blank' style='font-weight: bold; color: #1CAAD9;'>Hosta Devon Green A</a> by ");
            outer.Text("<a href='https://sketchfab.com/ElectricWolf?utm_medium=embed&utm_source=website&utm_campain=share-popup' target='_blank' style='font-weight: bold; color: #1CAAD9;'>ElectricWolf</a> on ");
            outer.Text("<a href='https://sketchfab.com?utm_medium=embed&utm_source=website&utm_campain=share-popup' target='_blank' style='font-weight: bold; color: #1CAAD9;'>Sketchfab</a>");
            outer.Text("</p>");
            outer.Text("</div>");

            outer.NewLine();
            outer.Text("<div class='sketchfab-embed-wrapper'>");
            outer.Text("<iframe width='640' height='480' src='https://sketchfab.com/models/5c9634d17bb1494eadaf9c0c315ad2a6/embed' frameborder='0' allowvr allowfullscreen mozallowfullscreen='true' webkitallowfullscreen='true' onmousewheel=''></iframe>");
            outer.Text("<p style='font-size: 13px; font-weight: normal; margin: 5px; color: #4A4A4A;'>");
            outer.Text("<a href='https://sketchfab.com/models/5c9634d17bb1494eadaf9c0c315ad2a6?utm_medium=embed&utm_source=website&utm_campain=share-popup'target='_blank' style='font-weight: bold; color: #1CAAD9;'>Rhododendron Version A</a> by ");
            outer.Text("<a href='https://sketchfab.com/ElectricWolf?utm_medium=embed&utm_source=website&utm_campain=share-popup' target='_blank' style='font-weight: bold; color: #1CAAD9;'>ElectricWolf</a> on ");
            outer.Text("<a href='https://sketchfab.com?utm_medium=embed&utm_source=website&utm_campain=share-popup' target='_blank' style='font-weight: bold; color: #1CAAD9;'>Sketchfab</a>");
            outer.Text("</p>");
            outer.Text("</div>");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateEasyPlacement(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("Pre-arranged groups of flowers for easy placement.");

            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-4");
            HTMLSection b = new HTMLSection("col-md-4");
            HTMLSection c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("FlowerBed_A_pf.png", 85);
            b.ImageCenter("FlowerBed_B_pf.png", 85);
            c.ImageCenter("FlowerBed_C_pf.png", 85);
            outer.Text(options.Output());

            outer.NewLine();
            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("FlowerBed_D_pf.png", 85);
            b.ImageCenter("FlowerBed_E_pf.png", 85);
            c.ImageCenter("FlowerBed_Oval_A_pf.png", 85);
            outer.Text(options.Output());

            outer.NewLine();
            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            a.ImageCenter("FlowerBed_Oval_B_pf.png", 85);
            b.ImageCenter("FlowerBed_Round_A_pf.png", 85);
            c.ImageCenter("FlowerBed_Round_B_pf.png", 85);
            outer.Text(options.Output());

            return outer.Output();
        }

        private string CreateExamples(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.NewLine();

            outer.ImageCenter("ShowInGameA.png", 65);
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("ShowInGameB.png", 65);

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "A collection of low poly garden flowers for Unity3D. Flowers have individual prefabs and also a collection of Flower Beds prefabs with pre-arranged groups of flowers for easy placement");
            return options.Output();
        }

        private string CreateRenderOptimization(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("Render optimization has a batch count of 22");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("NewRenderSpeed.png", 65);
            outer.EndTextCenter();
            return outer.Output();
        }
    }
}