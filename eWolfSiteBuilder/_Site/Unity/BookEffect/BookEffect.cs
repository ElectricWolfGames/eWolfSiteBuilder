using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Configuration;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;
using System.Threading;

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

        public int UnityListOrder { get; set; } = 3;

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
                new HTMLIndexedItems("Demo Video", CreateExample),
                new HTMLIndexedItems("Download", CreateDownload),
                new HTMLIndexedItems("How to use Unity", CreateHowToUseNew),
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
                Description = "Book Effect, Lets you add a book with turning pages into any unity game. </br>" +
                "Just add the prefab book object and then add all of your textures in the Inspector. Add as many as you need.",
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
            options.EndTextCenter();

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
            options.Jumbotron(DisplayTitle, "Book effect lets you add a book to your scene with turning pages. And by using the interface you have actions to open, close the book and turn the pages forward and back. All pages are added to the Inspector as textures.");
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


            options.YouTubeLinkBig("Lm6nuxJ3a54");

            options.EndTextCenter();
            return options.Output();

        }

        private string CreateHowToUseNew(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.StartTextCenter();

            options.TextBoldText("Add the ", @"eWolf\BookEffectV2\Prefabs\Book_Normal_pf.prefab", " into your scene.");
            options.NewLine();
            options.NewLine();
            options.Text("Next you will need add the pages");
            options.NewLine();
            options.Image("InspectorStart.png", 45);
            options.NewLine();
            options.NewLine();
            options.Text("Set the number of pages size for wish to use");
            options.NewLine();
            options.NewLine();
            options.Text("Then add all the pages in to the array");
            options.NewLine();
            options.NewLine();
            options.Image("InspectorEnd.png", 45);
            options.NewLine();
            options.NewLine();
            options.Text("You can quicky test the book by adding the prefab");
            options.NewLine();
            options.Bold(@"eWolf\BookEffectV2\Prefabs\BookHudControl_pf");
            options.NewLine();
            options.NewLine();
            options.Text("Then link this to your book.");
            options.NewLine();
            options.NewLine();
            options.Image("InspectorHud.png", 45);
            options.NewLine();
            options.NewLine();
            options.Text("And run the game and use the HUD options to use the book.");
            options.NewLine();
            options.NewLine();
            options.Image("InGameTest.PNG", 45);

            options.EndTextCenter();
            return options.Output();
        }

        private string CreateHowToUse(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();

            options.StartTextCenterLeft();
            options.NewLine();
            options.NewLine();

            options.TextBoldText("Add the ", @"eWolf\BookEffectV2\Prefabs\Book_Normal_pf.prefab", " into your scene.");
            options.NewLine();
            options.NewLine();
            options.TextBoldText("Update ", "Details.Pages.Size", " with how many pages you have.");
            options.TextBoldText("Add all the textures into the ", "Details.Pages.Element", " sections");
            options.NewLine();
            options.NewLine();
            options.Text("Set the starting pages if you want the book to open at a page other than the first page. To control the Book you will need to get access to the IBookControl interface with");
            options.Bold("IBookControl bookControl = BookObject.GetComponent();");
            options.Text("This will give you access to all the action in the interface. (examples of this can be seen in BookHud.cs)");

            options.EndTextCenterLeft();

            return options.Output();
        }

        private void CreateIndexedItems(List<HTMLIndexedItems> items)
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

        private string CreateInspectorOptions(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();
            HTMLSection left = new HTMLSection("col-md-6");
            HTMLSection right = new HTMLSection("col-md-6");
            options.SetTwoSections(left, right);

            left.ImageRight("BookInspector.PNG", 90);

            right.StartTextCenterLeft();
            right.StartTextMiddel(350);
            // TODO - replace the text 'hooks'
            right.InspectorDetails("Book Cover Animation", "Hooks in the Book Cover GameObject");
            right.InspectorDetails("Book Cover Mesh", "hooks in the Book Cover mesh");
            right.InspectorDetails("Book Animation", "hooks in the Book Page GameObject");
            right.InspectorDetails("Book Mesh", "hooks in the Book Page mesh");
            right.InspectorDetails("Details.Pages.Size", "The number of pages in the book.");
            right.InspectorDetails("Details.Pages.Element [n]", "Each texture in the book.");
            right.InspectorDetails("Details.Starting Page:", "The starting page when you open the book. This number must be even.");

            right.EndTextMiddel();
            right.EndTextCenterLeft();

            return options.Output();
        }

        private string CreateInterfaceOptions(string arg)
        {
            HTMLBuilder options = new HTMLBuilder();

            options.StartTextCenterLeft();
            options.NewLine();
            options.NewLine();

            options.Text("All book actions are controlled through an interface.");
            options.NewLine();
            options.NewLine();
            options.TextBoldText("The interface", " IBookControl ", "contains");
            options.NewLine();
            options.NewLine();

            options.Text("bool CanTurnPageBackWard { get; }"); options.NewLine();
            options.Text("bool CanTurnPageForward { get; }"); options.NewLine();
            options.Text("Details GetDetails { get; }"); options.NewLine();
            options.Text("bool IsBookOpen { get; }"); options.NewLine();
            options.Text("void CloseBook();"); options.NewLine();
            options.Text("void OpenBook();"); options.NewLine();
            options.Text("void OpenBookAtPage(int pageIndex);"); options.NewLine();
            options.Text("void SetSpeed(float speed);"); options.NewLine();
            options.Text("void TurnPage();"); options.NewLine();
            options.Text("void TurnPageBack();"); options.NewLine();

            options.EndTextCenterLeft();

            return options.Output();
        }

        private string CreateProjectLayout(string data)
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.TextBoldText("All of the objects, scripts and prefabs are under the", " eWolf ", "folder");
            outer.NewLine();
            outer.NewLine();
            outer.ImageCenter("Folders.PNG", 30);
            outer.NewLine();
            outer.NewLine();

            return outer.Output();
        }
    }
}