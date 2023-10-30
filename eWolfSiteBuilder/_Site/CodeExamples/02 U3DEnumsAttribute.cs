using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("U3DEnumsAttribute.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class U3DEnumsAttribute : PageDetailsWolfSite
    {
        public U3DEnumsAttribute()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Attributes: Adding extra data on to Enums";
            MenuTitle = "Attributes: Adding extra data on to Enums";
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

            options.Text("You can download the the files..");
            options.NewLine();

            options.Text("<a href=\"02 U3DEnumsAttribute/Data/U3DEnumsAttribute.unitypackage\" download>Unity3D package</a>");
            options.NewLine();
            options.NewLine();
            options.Text("<a href=\"02 U3DEnumsAttribute/Data/EnumHelper.cs\" download>EnumHelper.cs</a>");
            options.NewLine();
            options.Text("<a href=\"02 U3DEnumsAttribute/Data/PickupItems.cs\" download>PickupItems.cs</a>");
            options.NewLine();
            options.Text("<a href=\"02 U3DEnumsAttribute/Data/ShowEnumData.cs\" download>ShowEnumData.cs</a>");
            options.NewLine();
            options.Text("<a href=\"02 U3DEnumsAttribute/Data/TitleAttribute.cs\" download>TitleAttribute.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text("<a href=\"02 U3DEnumsAttribute/Data/ShowEnumData_UI.cs\" download>ShowEnumData_UI.cs</a>");
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("TitleAttribute.cs");
            options.NewLine();
            options.CodeText("using System;\r\n\r\nnamespace eWolf.CodeExamples.EnumnAttributes\r\n{\r\n    [AttributeUsage(AttributeTargets.All)]\r\n    public class TitleAttribute : Attribute\r\n    {\r\n        public TitleAttribute(string title)\r\n        {\r\n            Title = title;\r\n        }\r\n\r\n        public string Title { get; set; }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();
            options.Text("EnumHelper.cs");
            options.NewLine();
            options.CodeText("using System.ComponentModel;\r\nusing System.Linq;\r\nusing System.Reflection;\r\nusing UnityEngine;\r\n\r\nnamespace eWolf.CodeExamples.EnumnAttributes\r\n{\r\n    public class EnumHelper : MonoBehaviour\r\n    {\r\n        public static string GetEnumDescription(System.Enum value)\r\n        {\r\n            FieldInfo fi = value.GetType().GetField(value.ToString());\r\n\r\n            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];\r\n\r\n            if (attributes != null && attributes.Any())\r\n            {\r\n                return attributes.First().Description;\r\n            }\r\n\r\n            return value.ToString();\r\n        }\r\n\r\n        public static string GetEnumTitle(System.Enum value)\r\n        {\r\n            FieldInfo fi = value.GetType().GetField(value.ToString());\r\n            TitleAttribute[] attributes =\r\n                    fi.GetCustomAttributes(typeof(TitleAttribute), false) as TitleAttribute[];\r\n\r\n            if (attributes != null && attributes.Any())\r\n            {\r\n                return attributes.First().Title;\r\n            }\r\n\r\n            return value.ToString();\r\n        }\r\n    }\r\n}");
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

            options.Text("In the video below I show you how to add and use extra data on Enums");
            options.NewLine();
            options.NewLine();
            options.ImageFolder("02 U3DEnumsAttribute", "ShowEnum.PNG", 80);
            options.NewLine();
            options.NewLine();
            options.Text("This is all done by using attributes on to Enums");

            options.NewLine();
            options.NewLine();
            options.YouTubeLinkBig("rofuqFGz3Zs");

            options.EndTextCenter();
            return options.Output();
        }
    }
}