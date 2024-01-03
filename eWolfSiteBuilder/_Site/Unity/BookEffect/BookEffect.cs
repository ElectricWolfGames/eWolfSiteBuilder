using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace eWolfSiteBuilder._Site.Unity.BookEffect
{
    [PageTitle("BookEffect.html")]
    public class BookEffect : PageDetailsWolfSite, IHomePagePreview, IUnityList
    {
        public BookEffect()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Book Effect";
            MenuTitle = "Book Effect";
            Keywords.Add(DisplayTitle);
            Keywords.Add("book with turning pages");
            Keywords.Add("unity book");
            Keywords.Add("unity3d turning pages");
        }

        public int UnityListOrder { get; set; } = 1;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            var items = new List<HTMLIndexedItems>
            {
                new HTMLIndexedItems("Demo Video", CreateExample),
                new HTMLIndexedItems("Download", CreateDownload),
                new HTMLIndexedItems("OlderVersion", CreateOlderVersion),
                new HTMLIndexedItems("Overview", CreateOverview),

                //new HTMLIndexedItems("How to use from Code", CreateUseFromCode),
                //new HTMLIndexedItems("Code Control Options", CreateCodeOptions),
                //new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport)
            };

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
                ImagePath = $@"{WebPage.HtmlPath}\images\BookEffect.png",
                Description = "Updated (2024) Book Effect, Lets you add a book with turning pages into any unity game. </br>" +
                "Just add the prefab book object and then add all of your textures in the Inspector. Add now you can set the size and shape of the book.",
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.BookEffect);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private static string CreateOlderVersion(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.PageLink("If you need to check the older version Documation you can ", "found Here", "BookEffectV2.html");
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private static string CreateOverview(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text("The updated Book effect package now lets you set the size of the book");
            options.NewLine();
            options.NewLine();
            //options.Image("V3/InspectorBookSize.PNG", 60);
            //options.Text("");

            var section = new HTMLBuilder();
            var left = new HTMLSection("col-md-6");
            var right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookSize.PNG", 100);
            right.InspectorDetails("Width", "The width of the book in units");
            right.InspectorDetails("Height", "The height of the book in units");
            right.InspectorDetails("Thinkness", "The thinkness of the book when closed");
            right.InspectorDetails("Cover Thinkness", "The thinkness of the book cover");
            right.InspectorDetails("Hardback", "Not used yet, for future use!");
            right.NewLine();

            options.Text(section.Output());
            options.NewLine();

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookPageDetails.PNG", 100);
            right.InspectorDetails("Edge Gap", "Gap between the pages and the edge of the book");
            right.InspectorDetails("Page Turn Style", "How the page looks when it turns");
            right.NewLine();

            options.Text(section.Output());

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookMaterials.PNG", 100);
            right.InspectorDetails("Cover Inner", "Inside cover material");
            right.InspectorDetails("Cover Outter", "The book outside material");
            right.InspectorDetails("Inside Back Page", "Inside page right side");
            right.InspectorDetails("Inside Front Page", "Inside page left side");
            right.InspectorDetails("Pages", "Edge of the book. (pages)");

            right.NewLine();
            right.Text("");

            options.Text(section.Output());
            options.NewLine();

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookPages.PNG", 100);
            right.InspectorDetails("Pages", "Allow you to add as many textures as needed.");
            right.NewLine();

            options.Text(section.Output());
            options.NewLine();

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookOthers.PNG", 100);
            right.InspectorDetails("Starting Page", "Sets the starting page when the book opens");
            right.InspectorDetails("Start Speed", "Set the speed of the anims");
            right.NewLine();
            right.Text("");

            options.Text(section.Output());
            options.NewLine();
            options.TextBoldText("When you are ready Click on the", " Build Book ", "button to create the book");
            options.NewLine();
            options.Image("V3/Buttons.PNG", 65);
            options.NewLine();
            options.NewLine();
            options.TextBoldText("When built, you can use the ", "Open and Close", " Buttons to view the book open and closed");
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateExample(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.YouTubeLinkBig("OAkJZ9Tj9UU");

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Book effect lets you add a book to your scene with turning pages. And updated for 2024, you can now set the size and shape of the book.");
            return options.Output();
        }
    }
}