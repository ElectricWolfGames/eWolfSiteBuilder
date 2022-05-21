using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Helpers;
using eWolfSiteBuilder.zOLD.Configuration;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site.Unity.BookEffect
{
    [PageTitle("BookEffect.html")]
    public class BookEffect : PageDetails, IHomePagePreview, IUnityList
    {
        public BookEffect()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Book Effect";
            MenuTitle = "Book Effect";
        }

        public int UnityListOrder { get; set; } = 3;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main);
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");

            WebPage.Append(CreateHero());

            WebPage.Append("<div class='row'>");
            WebPage.Append($"<div class='col-md-12'>");

            List<HTMLIndexedItems> items = new List<HTMLIndexedItems>();

            items.Add(new HTMLIndexedItems("Example", CreateExample));
            items.Add(new HTMLIndexedItems("Download", CreateDownload));
            items.Add(new HTMLIndexedItems("Inspector Options", CreateInspectorOptions));
            items.Add(new HTMLIndexedItems("How to use", CreateHowToUse));
            items.Add(new HTMLIndexedItems("Interface options", CreateInterfaceOptions));
            items.Add(new HTMLIndexedItems("Project Layout", CreateProjectLayout));
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
                ImagePath = $@"{WebPage.HtmlPath}\Images\BookEffect.png",
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

            options.Text(@"That you can get from Unity3D asset store");
            options.NewLine();
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
            outer.ImageCenter("Folders.png", 30);
            outer.NewLine();
            outer.NewLine();

            return outer.Output();
        }
    }
}