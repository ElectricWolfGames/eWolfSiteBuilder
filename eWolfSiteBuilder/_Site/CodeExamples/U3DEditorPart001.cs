using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("U3DEditorPart001.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class U3DEditorPart001 : PageDetailsWolfSite
    {
        public U3DEditorPart001()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Customizing the inspector for your game objects";
            MenuTitle = "Customizing the inspector for your game objects";
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

            options.Text("<a href=\"U3DEditorPart001/Data/U3DEditorPart001.unitypackage\" download>Unity3D package</a>");
            options.NewLine();
            options.NewLine();
            options.Text("<a href=\"U3DEditorPart001/Data/ShowInspector.cs\" download>ShowInspector.cs</a>");
            options.NewLine();
            options.Text("<a href=\"U3DEditorPart001/Data/UsableItems.cs\" download>UsableItems.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text("<a href=\"U3DEditorPart001/Data/ShowInspector_UI.cs\" download>ShowInspector_UI.cs</a>");
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("ShowInspector.cs");
            options.NewLine();
            options.CodeText("using System;\r\nusing UnityEngine;\r\n\r\npublic class ShowInspector : MonoBehaviour\r\n{\r\n    [Range(1, 10)]\r\n    public float Price = 5;\r\n\r\n    public ExtraData ExtraData = new ExtraData();\r\n    public UsableItems UsableItems = UsableItems.None;\r\n\r\n    public void ResetValues()\r\n    {\r\n        UsableItems = UsableItems.None;\r\n        Price = 5;\r\n    }\r\n}\r\n\r\n[Serializable]\r\npublic class ExtraData\r\n{\r\n    public bool ShowIcon = true;\r\n\r\n    [Range(32.0f, 256)]\r\n    public float IconSize = 96;\r\n\r\n}\r\n");
            options.NewLine();
            options.NewLine();
            options.Text("ShowInspector_UI.cs");
            options.NewLine();
            options.CodeText("using System.Collections;\r\nusing System.Collections.Generic;\r\nusing UnityEditor;\r\nusing UnityEngine;\r\n\r\n[CustomEditor(typeof(ShowInspector)), CanEditMultipleObjects]\r\npublic class ShowInspector_UI : Editor\r\n{\r\n    private ShowInspector _showInspector;\r\n    private string _oldName;\r\n    private Texture2D _showItem = null;\r\n\r\n    private static Texture2D GetTexture(string name)\r\n    {\r\n        try\r\n        {\r\n            Texture2D go = (Texture2D)Resources.Load(name);\r\n            return go;\r\n        }\r\n        catch\r\n        {\r\n            return null;\r\n        }\r\n    }\r\n\r\n\r\n    public override void OnInspectorGUI()\r\n    {\r\n        DrawDefaultInspector();\r\n\r\n        if (_showInspector.ExtraData.ShowIcon)\r\n        {\r\n            if (_showItem == null ||\r\n            _oldName != _showInspector.UsableItems.ToString())\r\n            {\r\n                _showItem = GetTexture(_showInspector.UsableItems.ToString());\r\n                _oldName = _showInspector.UsableItems.ToString();\r\n            }\r\n\r\n            if (_showItem != null)\r\n            {\r\n                GUILayout.Label(\r\n                    _showItem,\r\n                    GUILayout.Width(_showInspector.ExtraData.IconSize),\r\n                    GUILayout.Height(_showInspector.ExtraData.IconSize));\r\n            }\r\n        }\r\n\r\n        if (_showInspector.UsableItems != UsableItems.None)\r\n        {\r\n            GUI.color = Color.green;\r\n            if (GUILayout.Button(\"Reset Values\"))\r\n            {\r\n                _showInspector.ResetValues();\r\n            }\r\n        }\r\n\r\n    }\r\n\r\n    private void OnEnable()\r\n    {\r\n        _showInspector = (ShowInspector)target;\r\n    }\r\n}\r\n");
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

            options.Text("In the video below I show you how to take a basic inspector..");
            options.NewLine();
            options.NewLine();
            options.ImageFolder("U3DEditorPart001", "OldInspector.PNG", 45);
            options.NewLine();
            options.NewLine();

            options.Text("And turn it in to ");
            options.NewLine();
            options.ImageFolder("U3DEditorPart001", "FullInspector.PNG", 35);

            options.NewLine();
            options.NewLine();
            options.YouTubeLinkBig("1UQrQ6xgsIY");

            options.EndTextCenter();
            return options.Output();
        }
    }
}