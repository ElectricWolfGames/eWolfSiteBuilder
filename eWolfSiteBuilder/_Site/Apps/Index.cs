using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;

namespace eWolfSiteBuilder._Site.Apps
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class Index : PageDetailsWolfSite
    {
        private const string SlideshowVideoCreatorPage = "SlideshowVideoCreator/index.html";

        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Apps";
            MenuTitle = "Apps";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this, string.Empty);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreateHero());
            WebPage.Append(CreateSlideshowVideoCreator());

            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();

            string heroText = $"Windows apps made at Electric Wolf" +
                $"</br></br>" +
                "Feel free to get in touch at Contact@electricWolf.co.uk";

            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }

        private string CreateSlideshowVideoCreator()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.Text(SlideshowVideoCreator.Index.Released ? "<h3>Out now</h3>" : "<h3>Coming soon</h3>");
            outer.NewLine();
            outer.EndTextCenter();

            outer.Text($"<a href='{SlideshowVideoCreatorPage}'>");
            outer.ImagePath("SlideshowVideoCreator/Images/FeatureGraphic-1024x500.png", 60);
            outer.Text("</a>");
            outer.NewLine();

            outer.StartTextCenter();
            outer.Text($"<h4><a href='{SlideshowVideoCreatorPage}'>Slideshow Video Creator</a></h4>");
            outer.NewLine();
            outer.Text("Turn a folder of photos into a finished slideshow video for Windows, with an animated title card, smooth transitions, gentle pans and your own music. Everything happens on your PC.");
            outer.NewLine();
            outer.NewLine();

            // Only the released app gets a store button; until then the page is the destination
            if (SlideshowVideoCreator.Index.Released)
            {
                outer.Text(SlideshowVideoCreator.Index.StoreButton());
                outer.Text("&nbsp;");
            }

            outer.Text($"<a href='{SlideshowVideoCreatorPage}' class='btn btn-outline-secondary btn-lg'>More about the app</a>");
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}
