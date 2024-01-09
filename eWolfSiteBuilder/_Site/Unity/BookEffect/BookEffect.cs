using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

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
                new HTMLIndexedItems("Download", CreateDownload),
                new HTMLIndexedItems("OlderVersion", CreateOlderVersion),
                new HTMLIndexedItems("VideoOverView", Version3Video),

                new HTMLIndexedItems("Example Book", CreateExampleBook),
                new HTMLIndexedItems("Overview", CreateOverview),
                new HTMLIndexedItems("Define the book cover", DefineTheBookCover),

                new HTMLIndexedItems("How to use from Code", CreateUseFromCode),
                new HTMLIndexedItems("Code Control Options", CreateCodeOptions),

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
            options.Text("Version 3 will be released Feburay 2024.");
            options.EndTextCenter();

            return options.Output();
        }

        private static string CreateExampleBook(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text("After importing");
            options.NewLine();
            options.NewLine();
            options.TextBold("Take a look at the two example scenes in the folder ", "Assets\\eWolf\\BookEffectV3\\Scene");
            options.NewLine();
            options.NewLine();
            options.NewLine();
            options.NewLine();
            options.Text("To add a book to a scene follow the steps");
            options.NewLine();
            options.NewLine();
            options.Text("Create a new empty scene");
            options.NewLine();
            options.TextBold("Drag in the book Prefab </br>", "Assets\\eWolf\\BookEffectV3\\Prefabs\\Book_Builder_pf.prefab");
            options.NewLine();
            options.TextBoldText("Then select the book in the scene, and in the inspector click on the ", "Build Book", " Button");
            options.NewLine();
            options.NewLine();
            options.Text("And the book will appear with all it's default material and pages");
            options.NewLine();
            options.Text("The Overview section (below) has all the details on what all the options are");
            options.NewLine();
            options.NewLine();
            options.Text("To test the book in a running game,");
            options.NewLine();
            options.NewLine();
            options.TextBold("Drag in the book controller Prefab </br>", "Assets\\eWolf\\BookEffectV2\\Prefabs\\BookHudControl_pf.prefab");
            options.NewLine();
            options.NewLine();
            options.Text("Select the BookHudControl_pf");
            options.NewLine();
            options.NewLine();
            options.Text("And then drag the Book_Builder_pf game object in to the Book Object field");
            options.NewLine();
            options.Text("So it looks like the below.");
            options.NewLine();
            options.Image("V3/BookControl.PNG", 45);
            options.NewLine();
            options.NewLine();
            options.Text("Now when you run the game, you will see the button to open and close the book, and also turn the pages.");

            options.EndTextCenter();

            return options.Output();
        }

        private static string CreateOlderVersion(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text("Version 3 will be released Feburay 2024. Until then please use Version 2");
            options.NewLine();
            options.PageLink("If you need to check the older version Documation you can ", "found Here", "BookEffectV2.html");
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            return options.Output();
        }

        private static string CreateOverview(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.Text("The updated Book effect package now lets you set the size of the book");
            options.NewLine();
            options.NewLine();

            var section = new HTMLBuilder();
            var left = new HTMLSection("col-md-6");
            var right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookSize.PNG", 100);
            right.InspectorDetails("Width", "The width of the book in units");
            right.InspectorDetails("Height", "The height of the book in units");
            right.InspectorDetails("Thickness", "The thickness of the book when closed");
            right.InspectorDetails("Cover Thickness", "The thickness of the book cover");
            right.InspectorDetails("Hardback", "Not used yet, for future use!");
            right.NewLine();

            options.Text(section.Output());
            options.NewLine();

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookPageDetails.PNG", 100);
            right.InspectorDetails("Edge Gap", "Gap between the pages and the edge of the book");
            right.InspectorDetails("Page Turn Style", "How the page looks when it turns");
            right.NewLine();

            options.Text(section.Output());

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookMaterials.PNG", 100);
            right.InspectorDetails("Cover Inner", "Inside cover material");
            right.InspectorDetails("Cover Outter", "The book outside material");
            right.InspectorDetails("Inside Back Page", "Inside page right side");
            right.InspectorDetails("Inside Front Page", "Inside page left side");
            right.InspectorDetails("Pages", "Edge of the book. (pages)");

            right.NewLine();
            right.Text("");

            options.Text(section.Output());
            options.NewLine();

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookPages.PNG", 100);
            right.InspectorDetails("Pages", "Allow you to add as many textures as needed.");
            right.NewLine();

            options.Text(section.Output());
            options.NewLine();

            section = new HTMLBuilder();
            left = new HTMLSection("col-md-6");
            right = new HTMLSection("col-md-6");
            section.SetTwoSections(left, right);

            left.ImageRight("V3/InspectorBookOthers.PNG", 100);
            right.InspectorDetails("Starting Page", "Sets the starting page when the book opens");
            right.InspectorDetails("Start Speed", "Set the speed of the animation");
            right.NewLine();
            right.Text("");

            options.Text(section.Output());
            options.NewLine();
            options.TextBoldText("When you are ready Click on the", " Build Book ", "button to create the book");
            options.NewLine();
            options.Image("V3/Buttons.PNG", 65);
            options.NewLine();
            options.NewLine();
            options.TextBoldText("When built, you can use the ", "Open and Close", " Buttons to view the book open and closed");
            options.NewLine();

            options.Text("Each time you change a value above you will need to rebuild the book.");
            options.NewLine();
            options.NewLine();

            options.Text("We also have more options to help with defining the Book Cover, which we will talk about later.");
            options.NewLine();
            options.NewLine();

            options.EndTextCenter();
            return options.Output();
        }

        private static string Version3Video(string data)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();
            options.NewLine();

            options.YouTubeLinkBig("V1iKKwmNrIM");
            options.EndTextCenter();

            return options.Output();
        }

        private string CreateCodeOptions(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("With access to the IBookControl");
            options.NewLine();
            options.NewLine();
            options.Text("You have access to ");
            options.NewLine();
            options.NewLine();
            options.EndTextCenter();

            options.StartTextLeft();
            options.Text("Can we turn the back backwards");
            options.CodeText("bool CanTurnPageBackWard  { get; }");
            options.NewLine();
            options.NewLine();

            options.Text("Can we turn the back forward (normal direction)");
            options.CodeText("bool CanTurnPageForward  { get; }");
            options.NewLine();
            options.NewLine();

            options.Text("Get the book details");
            options.CodeText("IDetails GetDetails { get; }");
            options.NewLine();
            options.NewLine();

            options.Text("Is the book currently open");
            options.CodeText("bool IsBookOpen { get; }");
            options.NewLine();
            options.NewLine();

            options.Text("Close the Book");
            options.CodeText("void CloseBook();");
            options.NewLine();
            options.NewLine();

            options.Text("Open the Book");
            options.CodeText("void OpenBook();");
            options.NewLine();
            options.NewLine();

            options.Text("Open the book at a set page");
            options.CodeText("void OpenBookAtPage(int pageIndex);");
            options.NewLine();
            options.NewLine();

            options.Text("Set the animation speed for the book");
            options.CodeText("void SetSpeed(float speed);");
            options.NewLine();
            options.NewLine();

            options.Text("Trun the page forward (normal)");
            options.CodeText("void TurnPage();");
            options.NewLine();
            options.NewLine();

            options.Text("Turn the page backwards");
            options.CodeText("void TurnPageBack();");
            options.EndTextLeft();

            return options.Output();
        }

        private string CreateExample(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.YouTubeLinkBig("OAkJZ9Tj9UU");

            return options.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Jumbotron(DisplayTitle, "Book effect lets you add a book to your scene with turning pages. And updated for 2024, you can now set the size and shape of the book.");
            return options.Output();
        }

        private string CreateUseFromCode(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("To access the book from code you will need to get the IBookControl from the Book (GameObject)");
            options.NewLine();
            options.NewLine();
            options.Text("Example Code");
            options.NewLine();
            options.NewLine();
            options.CodeText("public GameObject Book;</br>private IBookControl _bookControl;");
            options.NewLine();
            options.Text("And in the Start methods get the IBookControl");
            options.NewLine();
            options.NewLine();
            options.CodeText("private void Start()</br>{</br>&nbsp&nbsp&nbsp&nbsp_bookControl = Book.GetComponent&ltIBookControl&gt();</br>}");
            options.NewLine();
            options.Text("In the Update code you can open the book with ");
            options.NewLine();
            options.NewLine();
            options.CodeText("" +
                "private void Update()</br>" +
                "{<br>" +
                "&nbsp&nbsp&nbsp&nbspif (Input.GetKeyDown(\"o\"))</br>" +
                "&nbsp&nbsp&nbsp&nbsp{</br>" +
                "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp_bookControl.OpenBook();</br>" +
                "&nbsp&nbsp&nbsp&nbsp}</br>" +
                "}");

            options.NewLine();
            options.Text("Back in Unity3D, create an empty object and add this script and then link the book game object to the Book in this script.");

            options.NewLine();
            options.Text("When you run that in game it will open the book when you press 'o'");
            options.NewLine();
            options.NewLine();
            options.Text("Now you have access to the book you can add extra options like turning the pages with");
            options.NewLine();
            options.NewLine();
            options.CodeText("_bookControl.TurnPage();");
            options.NewLine();
            options.Text("To make it safe we will first need to check the book can turn to the next page.");
            options.NewLine();
            options.Text("Here is the code to make the page turn from another keypress");
            options.NewLine();
            options.NewLine();
            options.CodeText("" +
                "if (Input.GetKeyDown(\"p\"))</br>" +
                "{</br>" +
                "&nbsp&nbsp&nbsp&nbspif (_bookControl.CanTurnPageForward)</br>" +
                "&nbsp&nbsp&nbsp&nbsp{</br>" +
                "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp_bookControl.TurnPage();</br>" +
                "&nbsp&nbsp&nbsp&nbsp}</br>" +
                "}");
            options.NewLine();
            options.NewLine();

            options.Text("Please NOTE: This video was for Book Effect V2.");
            options.NewLine();
            options.TextBoldText("but will still work the same way, you just use the ", @"Assets\eWolf\BookEffectV3\Prefabs\Book_Builder_pf.prefab", "");

            options.YouTubeLinkBig("Lm6nuxJ3a54");

            options.EndTextCenter();
            return options.Output();
        }

        private string DefineTheBookCover(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.Text("As we can now set the thickness of the book cover");
            options.NewLine();
            options.Text("We also need to be able to change how much UV are used for the edge.");
            options.NewLine();
            options.NewLine();
            options.Image("V3/BookEdge.PNG", 45);
            options.NewLine();
            options.NewLine();
            options.Text("This can be done by the Book Cover UV Size Options");
            options.Image("V3/InspectorBookUV.PNG", 45);
            options.NewLine();
            options.NewLine();
            options.InspectorDetails("UV Cover Width", "The % of texture to use from the front cover");
            options.InspectorDetails("UV Cover Border X", "The % of the texture to use for the Edge (left and right)");
            options.InspectorDetails("UV Cover Border Y", "The % of the texture to use for the Edge (top and bottom)");

            options.EndTextCenter();
            return options.Output();
        }
    }
}