
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("EnhanceYourUnityEditor.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class EnhanceYourUnityEditor : PageDetailsWolfSite
    {
        public EnhanceYourUnityEditor()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Enhance your unity editor with OnDrawGizmosSelected";
            MenuTitle = "Enhance your unity editor";
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

            options.Text("ShowLink.cs");
            options.NewLine();
            options.CodeText("using System.Collections;\r\nusing System.Collections.Generic;\r\nusing UnityEditor;\r\nusing UnityEngine;\r\n\r\npublic class ShowLink : MonoBehaviour\r\n{\r\n    public GameObject Link;\r\n    public bool Red = false;\r\n\r\n    public void OnDrawGizmosSelected()\r\n    {\r\n        if (Red)\r\n            Gizmos.color = Color.red;\r\n        else\r\n            Gizmos.color = Color.yellow;\r\n\r\n        var pos = transform.position + Vector3.up * 2;\r\n        \r\n\r\n        Gizmos.DrawLine(transform.position, pos);\r\n\r\n        if (Link == null)\r\n        {\r\n            Handles.Label(pos, $\"{name} -> None\");\r\n            return;\r\n        }\r\n\r\n        Handles.Label(pos, $\"{name} -> {Link.name}\");\r\n        Gizmos.DrawLine(transform.position, Link.transform.position);\r\n    }\r\n}\r\n");
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

            options.Text("Enhance your unity editor with OnDrawGizmosSelected");
            options.NewLine();
            options.NewLine();
            options.Text("The video talks about how to display extra information in the unity editor on the selected GameObject.");
            options.NewLine();
            options.NewLine();
            options.Text("By drawing lines we can see how some objects are connected, and we take a look at how inspector fields can be visually seen in th editor.");
            options.NewLine();
            options.Text("And also how to add extra labels");
            options.NewLine();

            options.YouTubeLinkBig("MoorXetptJM");

            options.EndTextCenter();
            return options.Output();
        }
    }
}