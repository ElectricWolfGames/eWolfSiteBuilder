using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.PipeBuilder
{
    [PageTitle("PipeBuilder.html")]
    internal class PipeBuilder : PageDetailsWolfSite, IHomePagePreview, IUnityList
    {
        public PipeBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Pipe Builder";
            MenuTitle = "Pipe Builder";
            Keywords.Add(DisplayTitle);
            Keywords.Add("Create pipes");
            Keywords.Add("dynamically create pipes");
            Keywords.Add("pipes for games");
            Keywords.Add("Unity3d Pipes");
            Keywords.Add("Unity3d edit Pipes");
        }

        public int UnityListOrder { get; set; } = 3;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");

            WebPage.Append(CreateHero());

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Creating your first Pipe", CreateCreatingYourFirstPipe));
            items.Add(new HTMLIndexedItems("Inspector Details", CreateInspectorDetails));
            items.Add(new HTMLIndexedItems("Corner Pipes", CreateCornerPipes));
            items.Add(new HTMLIndexedItems("Auto Build and Inside Pipes", CreateAutoBuildAndInsidePipes));
            items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            items.Add(new HTMLIndexedItems("Create Pipes from Scripts", CreateCreatePipesFromScripts));
            items.Add(new HTMLIndexedItems("Version 2", CreateVersion2));
            items.Add(new HTMLIndexedItems("Fittings (version 2)", CreateV2Fittings));
            items.Add(new HTMLIndexedItems("New Materials (version 2)", CreateV2Materials));
            items.Add(new HTMLIndexedItems("Bake Lighting (version 2)", CreateV2BakeLighting));
            items.Add(new HTMLIndexedItems("Version 2.1", CreateVersion21));
            items.Add(new HTMLIndexedItems("Version 2.2", CreateVersion22));
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
                PreviewItemType = PreviewItemType.Builders,
                ImagePath = @$"{WebPage.HtmlPath}\images\PipeBuilderAd.png",
                Description = "Pipe Builder lets you quickly add pipes into any scene. You can define how many sides you wish to have on the pipes and you can also refine exactly where the pipe are in the scene. All with in Unity3D no need to swap back to a 3D editor. Pipe builder is ideal for placing pipes around other objects, with tools like Insert/ Delete and Extract, it makes it easy to add, remove modify later."
            };

            return pi;
        }

        private static string CreateDownload(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text(@"Pipe builder is ideal for placing pipes around other objects, with tools like Insert/ Delete and Extract, it makes it easy to add, remove modify later.");
            options.NewLine();
            options.NewLine();
            options.Unity3DLink(Unity3DSetting.PipeBuilder);
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateAutoBuildAndInsidePipes(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();

            outer.TextBoldText("Having", " Auto Build ", "set will create the pipes each time you move a node.");
            outer.NewLine();
            outer.TextBoldText("", "Inside Pipe", " will create the pipe inside out so you can place the player inside the pipe.");

            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateCornerPipes(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("CornerDetailsA.png", 85);

            left.StartTextCenterRight();
            left.StartTextMiddel(150);
            left.Text("We have 3 options that define the pipe corners: Size, Steps and Larger");
            left.EndTextMiddel();
            left.EndTextCenterRight();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("CornerDetailsB.png", 85);

            left.StartTextCenterRight();
            left.StartTextMiddel(150);
            left.TextBoldText("", "Size", " defines the overall size of the corner");
            left.EndTextMiddel();
            left.EndTextCenterRight();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("CornerDetailsC.png", 85);

            left.StartTextCenterRight();
            left.StartTextMiddel(150);
            left.TextBoldText("", "Steps", " define how many polygons you want. A high number will make it smoother");
            left.EndTextMiddel();
            left.EndTextCenterRight();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("CornerDetailsD.png", 85);

            left.StartTextCenterRight();
            left.StartTextMiddel(150);
            left.TextBoldText("", "Larger ", " sets whether you want the corner to be large or not");
            left.EndTextMiddel();
            left.EndTextCenterRight();

            outer.Text(options.Output());
            outer.NewLine();

            return outer.Output();
        }

        private string CreateCreatePipesFromScripts(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();
            outer.TextBoldText("If you need to create Pipes from your own scripts take a look at the example scene", " CreatePipesFromScript", "");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Run this scene and you will see 3 buttons");
            outer.NewLine();
            outer.ImageCenter("EX01_Ingame.PNG", 45);
            outer.NewLine();

            outer.TextBoldText("The button ", "Create basic pipes", "run this code");
            outer.NewLine();
            outer.ImageCenter("CreateBasicPipe.png", 45);
            outer.NewLine();

            outer.OtherDetails("Pipe.AddPipes();", "create a new pipe and returns it");
            outer.OtherDetails("pipeNode.ExtendPipe();", "Extends the current pipe node - creating the two nodes needed for the first pipe");
            outer.OtherDetails("Pipe.BuildPipes();", "forced the pipes to build the mesh");
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("The button ", "Create basic pipes", "run this code");
            outer.NewLine();
            outer.ImageCenter("CreatePipesFromList.png", 45);
            outer.NewLine();
            outer.Text("This is doing the same as the above script but just looping through a list of vectors.");
            outer.NewLine();
            outer.InspectorDetails("Note", "It still needs to call 'AddPipe' before having any nodes to extend.");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateCreatingYourFirstPipe(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();
            outer.TextBoldText("To start creating pipes add the main prefab ", "'PipeBase_pf'", " into the map.");
            outer.NewLine();
            outer.TextBoldText("With this prefab selected click on the ", "'Add Pipe'", " button. This will create a simple straight pipe.");
            outer.NewLine();
            outer.Text("Now you can start to position your pipe");
            outer.NewLine();
            outer.TextBoldText("If you need more nodes just click on the ", "'Extend Pipe'", " button and this will create another node in the direction of the pipe.");
            outer.NewLine();
            outer.TextBold("After you have positioned all your nodes just press ", "Generate pipe Mesh");
            outer.NewLine();
            outer.Text("You can see a basic pipe creation in this video");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("SylhKZ2sPhQ");

            outer.EndTextCenter();
            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.JumbotronImage(DisplayTitle, "Pipe Builder lets you quickly add pipes into any scene. You can define how many sides you wish to have on the pipes and you can also refine exactly where the pipes are in the scene. All within Unity3D no need to swap back to a 3D editor.", "PipeBuilderLogo.png", 35);
            return options.Output();
        }

        private string CreateInspectorDetails(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("PipeDetailsInspector.png", 70);

            right.StartTextCenterLeft();
            right.StartTextMiddel(450);
            right.Text("Main Details");
            right.NewLine();
            right.InspectorDetails("Sides", "Number of sides of the pipe");
            right.InspectorDetails("Radius", "The size of the pipe");
            right.InspectorDetails("UV Modifier", "Scale the UVs");
            right.InspectorDetails("Auto Build", "Rebuild the mesh each time you move a node");
            right.InspectorDetails("Inside Pipe", "Flips the normals, So you are inside the pipe");
            right.NewLine();
            right.NewLine();

            right.Text("Flange Details");
            right.NewLine();
            right.InspectorDetails("Flange", "Whether to add flanges");
            right.InspectorDetails("Length", "The length of the flanges");
            right.InspectorDetails("Interval", "How often to add flanges");
            right.InspectorDetails("Size", "The size of the flanges. Can me negative if needed");
            right.NewLine();
            right.NewLine();

            right.Text("Corners Details");
            right.NewLine();
            right.Text("We will cover the corners below.");
            right.NewLine();
            right.NewLine();
            right.Text("Bake Lighting Details");
            right.NewLine();

            right.Text("We will cover the bake lighting below.");
            right.NewLine();
            right.NewLine();
            right.NewLine();

            right.EndTextMiddel();
            right.EndTextCenterLeft();
            outer.Text(options.Output());

            outer.NewLine();
            outer.Text("You can see some of the different pipe details In this video.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("tsG1y81gin0");

            return outer.Output();
        }

        private string CreateMaterials(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("You will get a default set of high-resolution materials included in the package, you will need to drop the resolution if you don't need it.");
            outer.NewLine();
            outer.ImageCenter("Materials.png", 45);

            outer.NewLine();
            outer.Text("And you can easily add your own materials if you need.");
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("One other material in the package is ", "Bricks", " this is best used as the inside of the pipes.");
            outer.NewLine();
            outer.ImageCenter("InsidePipes.png", 45);

            outer.EndTextCenter();

            return outer.Output();
        }

        private void CreateOldPage(List<HTMLIndexedItems> items)
        {
            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            // Create Index
            HTMLBuilder options = new HTMLBuilder();
            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("PipeAroundPipes.png", 75);

            right.StartTextCenterLeft();
            right.StartTextMiddel(150);
            right.Text("Options allow you to set the size of the corners and with or without Flanges");
            right.NewLine();
            right.EndTextMiddel();
            right.EndTextCenterLeft();
            outer.Text(options.Output());

            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("PipeDetails.png", 75);

            right.StartTextCenterLeft();
            right.StartTextMiddel(250);
            right.Text("Adjustable number of the side for the pipes, Flanges have customizable intervals, length, and size.");
            right.NewLine();
            right.NewLine();
            right.Text("Allowing for a large range of custom looks for your pipes");
            right.NewLine();
            right.NewLine();
            right.EndTextMiddel();
            right.EndTextCenterLeft();

            outer.Text(options.Output());
            outer.NewLine();
            outer.NewLine();
            outer.Text("Here is an full overview video.");
            outer.NewLine();
            outer.NewLine();
            outer.YouTubeLinkBig("o3rYiB2Sd2g");

            return outer.Output();
        }

        private string CreateV2BakeLighting(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();
            outer.Text("Should you want to use Bake lights in your scenes, you can turn this on at the base pipe object.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("You also have the option set if you need the pipe to cast shadows and receive shadow");
            outer.NewLine();
            outer.Image("BakeLightingOptions.PNG", 45);
            outer.NewLine();
            outer.NewLine();
            outer.TextBold("After you have update the lighting options just rebuild the mesh by clicking ", "Generate pipe Mesh");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Just remember to bake the scene after any changes.");
            outer.NewLine();
            outer.TextBoldText("We have added a ", "Generate bake Lighting", " Option on the base Pipe build to make it easy to find");

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateV2Fittings(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();
            outer.TextBoldText("Fitting type are ", "Box, Flange, Value Wheel, Value Leaver.", "");
            outer.NewLine();
            outer.Text("Added in Version 2");
            outer.NewLine();

            var options = new HTMLBuilder();
            var left = new HTMLSection("col-md-6");
            var right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("Fitting Box.png", 80);
            right.ImageLeft("Fitting flange.png", 80);
            left.NewLine();
            right.NewLine();
            left.ImageRight("Fitting Leaver Red.png", 80);
            right.ImageLeft("Fitting Wheel Blue.png", 80);

            outer.Text(options.Output());
            outer.NewLine();

            outer.TextBold("To add a fitting to a pipe, just select a pipe node and click ", "'Add Fittings'");
            outer.NewLine();
            outer.Text("If you select two nodes it will add the fitting at the mid point between the two nodes");
            outer.NewLine();
            outer.Image("NodeDetailsInspector-AddFitting.png", 35);
            outer.NewLine();
            outer.Text("Any fitting can be moved in 3d space - but it will always link to the closest point along the pipe.");
            outer.NewLine();
            outer.Text("And when you release it - it will jump to that location.");
            outer.NewLine();
            outer.NewLine();

            outer.NewLine();

            outer.Text("<h3>Fitting Options</h3>");
            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("FittingInspector.png", 80);
            right.InspectorDetails("Direction", "The Direction of the fitting*");
            right.InspectorDetails("Extra Radius", "How far out from the pipe");
            right.InspectorDetails("Fitting Type", "The type of fitting");
            right.InspectorDetails("Length", "Length of the fitting along the pipe");
            right.InspectorDetails("Object Scale Modifier", "Wheels and Leavers scale adjuster*");
            right.InspectorDetails("Stem Length", "The length of the stem*");
            right.InspectorDetails("Stem Radius", "The radius of the stem*");
            right.Text("* Only on selected types");
            right.NewLine();
            right.NewLine();

            right.TextBoldText("Click ", "'Build mesh'", " to create the mesh");
            right.NewLine();
            right.TextBoldText("Click ", "'Duplicate Fitting'", " to Duplicate Fitting the current fitting.");

            outer.Text(options.Output());

            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.Text("Wheel Gates - 4 Directions");
            left.ImageRight("Fitting Show Wheels.png", 80);
            right.Text("leaver Gates - 4 Directions");
            right.ImageLeft("Fitting Show Leavers.png", 80);
            left.NewLine();
            right.NewLine();

            outer.Text(options.Output());
            outer.NewLine();

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateV2Materials(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.Text("New Materials added in Version 2");
            outer.NewLine();
            outer.Bold("Dented Copper");
            outer.NewLine();
            outer.Bold("Old Paint Blue");
            outer.NewLine();
            outer.Bold("Old Paint Green");
            outer.NewLine();
            outer.Bold("Old Paint Yellow");
            outer.NewLine();
            outer.Bold("Plastic Black");
            outer.NewLine();
            outer.Bold("Plastic Yellow");
            outer.NewLine();
            outer.NewLine();
            outer.Image("New materials v2.png", 65);

            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateVersion2(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Version 2 Adds");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Fittings like Wheel Gate, Leaver gates and others");
            outer.NewLine();
            outer.NewLine();
            outer.Text("More materials");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Bake Lighting Options");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Fixed some bugs:");
            outer.NewLine();

            outer.Text("Update on the UV mapping to keep it more balanced.");
            outer.NewLine();
            outer.Text("Update name of buttons in the inspectors");
            outer.NewLine();
            outer.Text("Some button now work when selecting more than one GameObject.");

            outer.NewLine();

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateVersion21(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Version 2.1");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Fixes a release build problem.");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateVersion22(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.NewLine();

            outer.Text("Version 2.2");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Optimised the Components used.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("If No Collection was selected, then all MeshCollider Components are removed.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("And if an object hasn't got any mesh it will remove the MeshFilter and MeshRenderer Components.");
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}