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

        private const string NumberTrailPage = "NumberTrail/index.html";

        /// <summary>
        /// Number Trail is built and signed but the listing does not exist yet, so it sits
        /// under "Coming soon" with no store link — a button to a page that 404s is worse
        /// than no button. Flip this on the day it goes live; the heading, the wording and
        /// the buttons all follow it.
        /// </summary>
        private static readonly bool NumberTrailReleased = false;

        private const string NumberTrailStore = "https://play.google.com/store/apps/details?id=com.numbertrail.game";

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
            WebPage.Append(CreateNumberTrail());

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

        private string CreateNumberTrail()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.NewLine();
            outer.StartTextCenter();
            outer.Text(NumberTrailReleased ? "<h3>Out now</h3>" : "<h3>Coming soon</h3>");
            outer.NewLine();
            outer.EndTextCenter();

            outer.Text($"<a href='{NumberTrailPage}'>");
            outer.ImagePath("NumberTrail/Images/FeatureGraphic-1024x500.png", 60);
            outer.Text("</a>");
            outer.NewLine();

            outer.StartTextCenter();
            outer.Text($"<h4><a href='{NumberTrailPage}'>Number Trail</a></h4>");
            outer.NewLine();
            outer.Text("A one line puzzle game for Android. Trace the numbered coins in order without lifting your finger, before the clock runs out — with gaps to find, blank decoys to route around, and a new daily set every day.");
            outer.NewLine();
            outer.NewLine();

            // Only the released path gets a store button. Until then the page itself is the
            // only destination, and it is also where the privacy policy lives.
            if (NumberTrailReleased)
            {
                outer.Text($"<a href='{NumberTrailStore}' target='_blank' class='btn btn-success btn-lg'>Get it on Google Play</a>");
                outer.Text("&nbsp;");
            }

            outer.Text($"<a href='{NumberTrailPage}' class='btn btn-outline-secondary btn-lg'>More about the game</a>");
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }
    }
}
