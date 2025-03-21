﻿using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.SkyboxesSkies
{
    [PageTitle("SkyboxesSkies.html")]
    public class SkyboxesVariety : PageDetailsWolfSite, IHomePagePreview, IUnityList
    {
        public SkyboxesVariety()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Skyboxes Skies";
            MenuTitle = "Skyboxes Skies";

            Keywords.AddRange(
                new string[]
                {
                    "Skyboxes",
                    "game skys",
                    "unity sky boxes",
                    "background sky",
                });

            LinkedThePackages("Road Builder", "Traffic and Roadside objects", "Fence, Wall and Hedge Builder", "Skyboxes Skies");
        }

        public int UnityListOrder { get; set; } = 20;

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
            items.Add(new HTMLIndexedItems("How to Use", CreateHowToUse));
            items.Add(new HTMLIndexedItems("Previews", CreatePreviews));

            items.Add(new HTMLIndexedItems("You may also like", CreateAddLinkedPackages));
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
                PreviewItemType = PreviewItemType.Skyboxes,
                ImagePath = @$"{WebPage.HtmlPath}\images\SkyboxesB.png",
                Description = "Section of 10 Variety skies skyboxes, " +
                "High quality panoramic scenes that can be used in your game." +
                "All textures (6 of them) are 1024 by 1024 resolution."
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Unity3DLink(Unity3DSetting.SkyboxesVariety);
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string AddSkyImages(string skyBox, string name)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.NewLine();
            options.NewLine();

            HTMLSection a = new HTMLSection("col-md-8");
            HTMLSection b = new HTMLSection("col-md-4");
            options.SetTwoSections(a, b);

            a.TextBoldText("", name, "");
            a.NewLine();
            a.Images(23, $"{skyBox}\\{skyBox}_Back.png", $"{skyBox}\\{skyBox}_Right.png", $"{skyBox}\\{skyBox}_Front.png", $"{skyBox}\\{skyBox}_Left.png");
            b.NewLine();
            b.ImageCenter($"{skyBox}\\{skyBox}_Up.png", 45);

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "High quality panoramic scenes that can be used in your game." +
                "All textures (6 of them) are 1024 by 1024 resolution.");

            return options.Output();
        }

        private string CreateHowToUse(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.Text("This collection contains 10 Skyboxes that you can use in any Unity 3D scene.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Just add the SkyBox component to the camera and then just drag one of my materials on it.");
            outer.NewLine();
            outer.NewLine();
            return outer.Output();
        }

        private void CreateIndexItems(List<HTMLIndexedItems> items)
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

        private string CreatePreviews(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.Text("This collection contains 10 Skyboxes that are sky's only that you can use in any Unity 3D scene.");
            outer.NewLine();
            outer.NewLine();

            outer.Text(AddSkyImages("Sky_01", "Sky 1"));
            outer.Text(AddSkyImages("Sky_02", "Sky 2"));
            outer.Text(AddSkyImages("Sky_03", "Sky 3"));
            outer.Text(AddSkyImages("Sky_04", "Sky 4"));
            outer.Text(AddSkyImages("Sky_05", "Sky 5"));
            outer.Text(AddSkyImages("Sky_06", "Sky 6"));
            outer.Text(AddSkyImages("Sky_07", "Sky 7"));
            outer.Text(AddSkyImages("Sky_08", "Sky 8"));
            outer.Text(AddSkyImages("Sky_09", "Sky 9"));
            outer.Text(AddSkyImages("Sky_10", "Sky 10"));

            return outer.Output();
        }
    }
}