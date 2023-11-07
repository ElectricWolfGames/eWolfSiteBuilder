using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("EnhanceYourUnityEditorHandles.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class EnhanceYourUnityEditorHandles : PageDetailsWolfSite
    {
        public EnhanceYourUnityEditorHandles()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Enhance your unity editor with Handles";
            MenuTitle = "Enhance your unity editor with Handles";
            DontShowNavigation = true;
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Downloads", CreateDownloadFiles));
            items.Add(new HTMLIndexedItems("Files", CreateExmapleFiles));

            AddIndexItemsWithSideBar(items);

            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateDownloadFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            string folder = "06 EnhanceYourUnityEditor/Data/";

            options.Text("You can download the the files..");
            options.NewLine();

            options.Text($"<a href=\"{folder}EnhanceYourUnityEditor.unitypackage\" download>Unity3D package</a>");
            options.NewLine();
            options.NewLine();

            options.Text($"<a href=\"{folder}ShowLink.cs\" download>ShowLink.cs</a>");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text(".cs");
            options.NewLine();
            options.CodeText("");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            string heroText = $"";
            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("Enhance your unity editor with Handles");
            options.NewLine();
            options.NewLine();
            options.Text("");
            options.NewLine();
            options.NewLine();
            
            options.YouTubeLinkBig("");

            options.EndTextCenter();
            return options.Output();
        }
    }
}