using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.PipeBuilder
{
    [PageTitle("PipeBuilder.html")]
    internal class PipeBuilder : PageDetails, IHomePagePreview, IUnityList
    {
        public PipeBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Pipe Builder";
            MenuTitle = "Pipe Builder";
        }

        public int UnityListOrder { get; set; } = 3;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Overview", CreateOverview));
            items.Add(new HTMLIndexedItems("Creating your first Pipe:", CreateCreatingYourFirstPipe));
            items.Add(new HTMLIndexedItems("Inspector Details", CreateInspectorDetails));
            items.Add(new HTMLIndexedItems("Corner Pipes", CreateCornerPipes));
            items.Add(new HTMLIndexedItems("Auto Build and Inside Pipes", CreateAutoBuildAndInsidePipes));
            items.Add(new HTMLIndexedItems("Materials", CreateMaterials));
            items.Add(new HTMLIndexedItems("Create Pipes from Scripts", CreateCreatePipesFromScripts));
            items.Add(new HTMLIndexedItems("Support", PageDetailsHelper.CreateSupport));

            HTMLBuilder options = new HTMLBuilder();

            options.CreateIndex(items);
            WebPage.Append(options.Output());

            options = new HTMLBuilder();
            options.CreateIndexItems(items);
            WebPage.Append(options.Output());
            WebPage.Append("</div>");

            WebPage.CloseAllsDiv();

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
                ImagePath = @$"{WebPage.HtmlPath}\Images\PipeBuilderAd.png",
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
            options.Text(@"That you can get from Unity3D asset store");
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

            right.ImageLeft("CornerDetailsA.PNG", 85);

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

            right.ImageLeft("CornerDetailsB.PNG", 85);

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

            right.ImageLeft("CornerDetailsC.PNG", 85);

            left.StartTextCenterRight();
            left.StartTextMiddel(150);
            left.TextBoldText("", "Steps", " define how may polygon you want. A high number will make it smoother");
            left.EndTextMiddel();
            left.EndTextCenterRight();

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            right.ImageLeft("CornerDetailsD.PNG", 85);

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
            outer.ImageCenter("CreateBasicPipe.PNG", 45);
            outer.NewLine();

            outer.OtherDetails("Pipe.AddPipes();", "create a new pipe and returns it");
            outer.OtherDetails("pipeNode.ExtendPipe();", "Extends the current pipe node - creating the two nodes needed for the first pipe");
            outer.OtherDetails("Pipe.BuildPipes();", "forced the pipes to build the mesh");
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("The button ", "Create basic pipes", "run this code");
            outer.NewLine();
            outer.ImageCenter("CreatePipesFromList.PNG", 45);
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
            options.JumbotronImage(DisplayTitle, "Pipe Builder lets you quickly add pipes into any scene. You can define how many sides you wish to have on the pipes and you can also refine exactly where the pipe are in the scene. All with in Unity3D no need to swap back to a 3D editor.", "PipeBuilderLogo.PNG", 35);
            return options.Output();
        }

        private string CreateInspectorDetails(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("PipeDetailsInspector.PNG", 70);

            right.StartTextCenterLeft();
            right.StartTextMiddel(450);
            right.Text("Main Details");
            right.NewLine();
            right.InspectorDetails("Sides", "Number of sides of the pipe");
            right.InspectorDetails("Radius", "The size of the pipe");
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
            outer.ImageCenter("Materials.PNG", 45);

            outer.NewLine();
            outer.Text("And you can easily add your own materials if you need.");
            outer.NewLine();
            outer.NewLine();

            outer.TextBoldText("One other material in the package is ", "Bricks", " this is best used as the inside of the pipes.");
            outer.NewLine();
            outer.ImageCenter("InsidePipes.PNG", 45);

            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateOverview(string arg)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.NewLine();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("PipeAroundPipes.PNG", 75);

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

            left.ImageRight("PipeDetails.PNG", 75);

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

            return outer.Output();
        }
    }
}