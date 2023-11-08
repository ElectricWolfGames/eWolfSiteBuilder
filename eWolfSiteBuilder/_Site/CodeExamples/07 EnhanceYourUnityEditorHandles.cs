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

            string folder = "07 EnhanceYourUnityEditorHandles/Data/";

            options.Text("You can download the the files..");
            options.NewLine();

            options.Text($"<a href=\"{folder}EnhanceYourUnityEditor.unitypackage\" download>Unity3D package</a>");
            options.NewLine();
            options.NewLine();

            options.Text("<h1>Show Range</h1>");
            options.NewLine();
            options.Text($"<a href=\"{folder}ShowHandles.cs\" download>ShowHandles.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text($"<a href=\"{folder}ShowHandles_UI.cs\" download>ShowHandles_UI.cs</a>");
            options.NewLine();
            options.NewLine();

            options.Text("<h1>Show area</h1>");
            options.NewLine();
            options.Text($"<a href=\"{folder}ShowPath.cs\" download>ShowPath.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text($"<a href=\"{folder}ShowPath_UI.cs\" download>ShowPath_UI.cs</a>");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("ShowHandles.cs");
            options.NewLine();
            options.CodeText("using UnityEngine;\r\n\r\npublic class ShowHandles : MonoBehaviour\r\n{\r\n    public float Size = 1;\r\n    public Vector3 LastPos { get; set; } = new Vector3(1, 0, 0);\r\n\r\n    public void OnDrawGizmosSelected()\r\n    {\r\n        Gizmos.DrawWireSphere(transform.position, Size);\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();
            options.Text("ShowHandles_UI.cs");
            options.NewLine();
            options.CodeText("using Unity.VisualScripting;\r\nusing UnityEditor;\r\nusing UnityEngine;\r\n\r\n[CustomEditor(typeof(ShowHandles))]\r\n[CanEditMultipleObjects]\r\npublic class ShowHandles_UI : Editor\r\n{\r\n    private ShowHandles _node;\r\n\r\n    public void OnEnable()\r\n    {\r\n        _node = target.GetComponent<ShowHandles>();\r\n    }\r\n    public void OnSceneGUI()\r\n    {\r\n        var handlePosition = _node.gameObject.transform.position + _node.LastPos;\r\n\r\n        Vector3 newpos = Handles.FreeMoveHandle(\r\n            handlePosition,\r\n            Quaternion.identity, 0.5f, Vector3.zero, Handles.RectangleHandleCap);\r\n\r\n        if (newpos != handlePosition)\r\n        {\r\n            _node.LastPos = newpos - _node.gameObject.transform.position;\r\n            _node.Size = _node.LastPos.magnitude;\r\n        } \r\n\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();
            options.NewLine();
            options.NewLine();
            options.Text("ShowPath.cs");
            options.NewLine();
            options.CodeText("using System.Collections.Generic;\r\nusing System.Linq;\r\nusing UnityEngine;\r\n\r\npublic class ShowPath : MonoBehaviour\r\n{\r\n    public bool EditPath = true;\r\n    public List<Vector3> Nodes = new List<Vector3>();\r\n\r\n    public void OnDrawGizmosSelected()\r\n    {\r\n        if (!EditPath)\r\n            return;\r\n\r\n        if (!Nodes.Any())\r\n            return;\r\n\r\n        Vector3 posLast = Nodes[0];\r\n        \r\n        for (int i = 1; i < Nodes.Count; i++)\r\n        {\r\n            Gizmos.DrawLine(Nodes[i], posLast);\r\n            posLast = Nodes[i];\r\n        }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();
            options.Text("ShowPath_UI.cs");
            options.NewLine();
            options.CodeText("using Unity.VisualScripting;\r\nusing UnityEditor;\r\nusing UnityEngine;\r\n\r\n[CustomEditor(typeof(ShowPath))]\r\n[CanEditMultipleObjects]\r\npublic class ShowPath_UI : Editor\r\n{\r\n    private ShowPath _node;\r\n\r\n    public void OnEnable()\r\n    {\r\n        _node = target.GetComponent<ShowPath>();\r\n    }\r\n\r\n    public void OnSceneGUI()\r\n    {\r\n        if (!_node.EditPath)\r\n            return;\r\n\r\n        Vector3 handlePosition = new Vector3(1, 0, 0);\r\n\r\n        for (int i = 0; i < _node.Nodes.Count; i++)\r\n        {\r\n            handlePosition = _node.Nodes[i];\r\n\r\n            Vector3 newpos = Handles.FreeMoveHandle(\r\n               handlePosition,\r\n               Quaternion.identity, 0.5f, Vector3.zero, Handles.RectangleHandleCap);\r\n\r\n            if (newpos != handlePosition)\r\n            {\r\n                newpos.y = 0;\r\n                _node.Nodes[i] = newpos;\r\n            }\r\n        }\r\n\r\n        handlePosition.x += 2f;\r\n        Quaternion q = Quaternion.Euler(90, 0, 0);\r\n        if (Handles.Button(handlePosition, q, 0.5f, 0.5f, Handles.CircleHandleCap))\r\n        {\r\n            _node.Nodes.Add(handlePosition);\r\n        }\r\n\r\n    }\r\n}");
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
            options.Text("By using handles within the Unity editor you can make your game editing much easier");
            options.NewLine();
            options.NewLine();
            options.Text("This video shows you two ways you can use handles with UI examples and how the code works");
            options.NewLine();
            options.NewLine();

            options.YouTubeLinkBig("");

            options.EndTextCenter();
            return options.Output();
        }
    }
}