using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;

namespace eWolfSiteBuilder._Site.Games
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class Index : PageDetailsWolfSite
    {
        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Games";
            MenuTitle = "Games";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this, string.Empty);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreateHero());

            string displayText = "Three Number Problem";
            WebPage.Append($"<li><a href='ThreeNumberProblems/index.html'>{displayText}</a></li>");

            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();

            string heroText = $"Games in development at Electric Wolf" +
                $"</br></br>" +
                "Feel free to get in touch at Contact@electricWolf.co.uk";

            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }
    }
}
