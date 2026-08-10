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
        private const string ThreeNumberProblemPage = "ThreeNumberProblems/index.html";
        private const string ThreeNumberProblemStore = "https://play.google.com/store/apps/details?id=com.threenumberproblem.game";

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
            WebPage.Append(CreateThreeNumberProblem());

            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();

            string heroText = $"Games made at Electric Wolf, from ideas in progress to titles you can play today" +
                $"</br></br>" +
                "Feel free to get in touch at Contact@electricWolf.co.uk";

            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }

        private string CreateThreeNumberProblem()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.Text("<h3>Out now</h3>");
            outer.NewLine();
            outer.EndTextCenter();

            outer.Text($"<a href='{ThreeNumberProblemPage}'>");
            outer.ImagePath("ThreeNumberProblems/Images/FeatureGraphic-1024x500.png", 60);
            outer.Text("</a>");
            outer.NewLine();

            outer.StartTextCenter();
            outer.Text($"<h4><a href='{ThreeNumberProblemPage}'>Three Number Problem</a></h4>");
            outer.NewLine();
            outer.Text("A quick fire maths puzzle game for Android. Three numbers, two operators and one target to hit, with two difficulties, streaks to chase and hints for when you get stuck.");
            outer.NewLine();
            outer.NewLine();
            outer.Text($"<a href='{ThreeNumberProblemStore}' target='_blank' class='btn btn-success btn-lg'>Get it on Google Play</a>");
            outer.Text("&nbsp;");
            outer.Text($"<a href='{ThreeNumberProblemPage}' class='btn btn-outline-secondary btn-lg'>More about the game</a>");
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}
