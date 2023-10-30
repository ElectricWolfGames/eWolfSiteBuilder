using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("ProceduralGeneration.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class ProceduralGeneration : PageDetailsWolfSite
    {
        public ProceduralGeneration()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Procedural Generation";
            MenuTitle = "Procedural Generation";
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

            string folder = "05 ProceduralGeneration/Data/";

            options.Text("You can download the the files..");
            options.NewLine();

            options.Text($"<a href=\"{folder}ProceduralGeneration.unitypackage\" download>Unity3D package</a>");
            options.NewLine();
            options.NewLine();

            options.Text($"<a href=\"{folder}CreateMesh.cs\" download>CreateMesh.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text($"<a href=\"{folder}MeshBuilder.cs\" download>MeshBuilder.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text($"<a href=\"{folder}UVSet.cs\" download>UVSet.cs</a>");
            options.NewLine();
            options.NewLine();
            options.Text($"<a href=\"{folder}CreateMesh_UI.cs\" download>CreateMesh_UI.cs</a>");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateExmapleFiles(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("CreateMesh.cs");
            options.NewLine();
            options.CodeText("using UnityEngine;\r\n\r\nnamespace eWolf.CodeExamples.ProceduralGeneration\r\n{\r\n    public class CreateMesh : MonoBehaviour\r\n    {\r\n        public Material material;\r\n        private MeshBuilder _meshBuilder = new MeshBuilder();\r\n\r\n        public void BuildMesh()\r\n        {\r\n            _meshBuilder = new MeshBuilder();\r\n            UVSet uvSet = new UVSet(1, 1);\r\n\r\n            float size = 1f;\r\n            float width = 0.1f;\r\n\r\n            Vector3 xy = new Vector3(0, 0, 0);\r\n            Vector3 xytop = xy + Vector3.up * size;\r\n            Vector3 xyFar = xy + Vector3.forward * size;\r\n            Vector3 xytopFar = xytop + Vector3.forward * size;\r\n            _meshBuilder.BuildQuad(xy, xyFar, xytop, xytopFar, uvSet);\r\n\r\n            xy = new Vector3(width, 0, 0);\r\n            xytop = xy + Vector3.up * size;\r\n            xyFar = xy + Vector3.forward * size;\r\n            xytopFar = xytop + Vector3.forward * size;\r\n            _meshBuilder.BuildQuad(xytop, xytopFar, xy, xyFar, uvSet);\r\n\r\n            UVSet uvSetEnd = new UVSet(width, 1);\r\n            xy = new Vector3(0, 0, 0);\r\n            xytop = xy + Vector3.up * size;\r\n            xyFar = xy + Vector3.right * width;\r\n            xytopFar = xytop + Vector3.right * width;\r\n            _meshBuilder.BuildQuad(xytop, xytopFar, xy, xyFar, uvSetEnd);\r\n\r\n\r\n            _meshBuilder.ApplyMeshDetails(gameObject, material);\r\n        }\r\n\r\n        public void ClearMesh()\r\n        {\r\n            _meshBuilder = new MeshBuilder();\r\n            _meshBuilder.ApplyMeshDetails(gameObject, material);\r\n        }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();

            options.Text("MeshBuilder.cs");
            options.NewLine();
            options.CodeText("using System;\r\nusing System.Collections.Generic;\r\nusing UnityEngine;\r\n\r\nnamespace eWolf.CodeExamples.ProceduralGeneration\r\n{\r\n    public class MeshBuilder\r\n    {\r\n        private List<Vector2> MeshUVs { get; set; } = new List<Vector2>();\r\n        private List<Vector3> MeshVertices { get; set; } = new List<Vector3>();\r\n        private List<int> Triangles { get; set; } = new List<int>();\r\n\r\n        public void ApplyMeshDetails(GameObject baseobject, Material material)\r\n        {\r\n            Mesh mesh = new Mesh\r\n            {\r\n                name = $\"MyMesh {DateTime.Now.ToShortDateString()}\"\r\n            };\r\n            baseobject.GetComponent<MeshFilter>().mesh = mesh;\r\n\r\n            mesh.vertices = MeshVertices.ToArray();\r\n            mesh.uv = MeshUVs.ToArray();\r\n\r\n            Renderer r = baseobject.GetComponent<Renderer>();\r\n            r.sharedMaterial = material;\r\n\r\n            mesh.SetTriangles(Triangles.ToArray(), 0);\r\n\r\n            mesh.subMeshCount = 1;\r\n\r\n            mesh.RecalculateNormals();\r\n            mesh.RecalculateBounds();\r\n        }\r\n\r\n        public void BuildQuad(Vector3 a, Vector3 b, Vector3 c, Vector3 d, UVSet uvset)\r\n        {\r\n            int indexA = AddVectorUVSets(a, uvset.BR);\r\n            int indexB = AddVectorUVSets(b, uvset.TR);\r\n            int indexC = AddVectorUVSets(c, uvset.BL);\r\n            int indexD = AddVectorUVSets(d, uvset.TL);\r\n\r\n            Triangles.AddRange(new int[] { indexA, indexB, indexC });\r\n            Triangles.AddRange(new int[] { indexD, indexC, indexB });\r\n        }\r\n\r\n        private int AddVectorUVSets(Vector3 points, Vector2 uvs)\r\n        {\r\n            MeshVertices.Add(points);\r\n            MeshUVs.Add(uvs);\r\n            return MeshVertices.Count - 1;\r\n        }\r\n    }\r\n}");
            options.NewLine();
            options.NewLine();

            options.Text("UVSet.cs");
            options.NewLine();
            options.CodeText("using UnityEngine;\r\n\r\nnamespace eWolf.CodeExamples.ProceduralGeneration\r\n{\r\n    public class UVSet\r\n    {\r\n        /// <summary>\r\n        /// The Bottom left position\r\n        /// </summary>\r\n        public Vector2 BL;\r\n\r\n        /// <summary>\r\n        /// The bottom right postion\r\n        /// </summary>\r\n        public Vector2 BR;\r\n\r\n        /// <summary>\r\n        /// The top left position\r\n        /// </summary>\r\n        public Vector2 TL;\r\n\r\n        /// <summary>\r\n        /// The top right position\r\n        /// </summary>\r\n        public Vector2 TR;\r\n\r\n        /// <summary>\r\n        /// The Standard constructor\r\n        /// </summary>\r\n        /// <param name=\"topLeft\">The top left UV</param>\r\n        /// <param name=\"topRight\">The top right UV</param>\r\n        /// <param name=\"botLeft\">The bottom left uv</param>\r\n        /// <param name=\"botRight\">The bottom right uv</param>\r\n        public UVSet(Vector2 topLeft, Vector2 topRight, Vector2 botLeft, Vector3 botRight)\r\n        {\r\n            TL = topLeft;\r\n            TR = topRight;\r\n            BL = botLeft;\r\n            BR = botRight;\r\n        }\r\n\r\n        /// <summary>\r\n        /// The Standard constructor\r\n        /// </summary>\r\n        public UVSet()\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// The Standard constructor\r\n        /// </summary>\r\n        /// <param name=\"x\">The X position</param>\r\n        /// <param name=\"y\">The Y position</param>\r\n        public UVSet(float x, float y)\r\n        {\r\n            TL = new Vector2(0, 0);\r\n            TR = new Vector2(0, y);\r\n            BL = new Vector2(x, 0);\r\n            BR = new Vector2(x, y);\r\n        }\r\n    }\r\n}");
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

            options.Text("Procedural Generating a mesh from code.");
            options.NewLine();
            options.NewLine();
            options.Text("The video talks and shows you how to create a simple wall just by using code.");
            options.NewLine();
            options.NewLine();
            options.Text("We build up the wall, polygon by polygon and, apply UV to define how the textures are used.");
            options.NewLine();
            options.NewLine();

            options.YouTubeLinkBig("hEERhVO5Q_M");

            options.EndTextCenter();
            return options.Output();
        }
    }
}