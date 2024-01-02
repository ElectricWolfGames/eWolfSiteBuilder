using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

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
                //new HTMLIndexedItems("Demo Video", CreateExample),
                new HTMLIndexedItems("Download", CreateDownload),
                new HTMLIndexedItems("OlderVersion", CreateOlderVersion),
                //new HTMLIndexedItems("How to use Unity", CreateHowToUseNew),
                //new HTMLIndexedItems("How to use from Code", CreateUseFromCode),
                //new HTMLIndexedItems("Code Control Options", CreateCodeOptions),
                new HTMLIndexedItems("Support", PageDetailsHelper.AddSectionSupport)
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

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Book effect lets you add a book to your scene with turning pages. And updated for 2024, you can now set the size and shape of the book.");
            return options.Output();
        }
    }
}