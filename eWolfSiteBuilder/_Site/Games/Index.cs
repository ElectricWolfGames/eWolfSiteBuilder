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
        private const string ScreenShotFolder = "ThreeNumberProblems/Images";

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

        private string CreateThreeNumberProblem()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.Title("Three Number Problem");
            outer.ImageCenter("ThreeNumberProblemLogo.png", 35);
            outer.NewLine();

            outer.StartTextCenter();
            outer.Text("A quick fire maths puzzle game for Android. Every round deals you three number tiles and a set of operator tiles, and gives you a target to hit.");
            outer.NewLine();
            outer.Text("Drag the tiles into the five slots to build a sum that lands exactly on the target, then hit Submit. The sum is worked out left to right, so it is the order you choose that matters.");
            outer.NewLine();
            outer.NewLine();
            outer.Text("Get it right and the numbers grow and your streak climbs. Get it wrong and you lose one of your three lives.");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            outer.InspectorDetails("Two difficulties", "Casual sticks to add, subtract and multiply. Challenging adds divide and starts from bigger numbers");
            outer.InspectorDetails("Always whole numbers", "Puzzles are generated so the answer never comes out as a fraction or a negative");
            outer.InspectorDetails("Climbing difficulty", "The numbers you are dealt get larger the further you get");
            outer.InspectorDetails("Streaks", "Your current run and your best ever streak are tracked and saved between sessions");
            outer.InspectorDetails("Three lives", "A wrong answer costs a life, so it is worth checking before you submit");
            outer.InspectorDetails("Hints", "Start with five hints that fill in part of the answer, and earn more as you go");

            outer.NewLine();
            outer.NewLine();
            outer.Text(CreateScreenShots());

            outer.NewLine();
            outer.StartTextCenter();
            outer.Text("Three Number Problem is in development and heading for Google Play.");
            outer.NewLine();
            outer.EndTextCenter();

            return outer.Output();
        }

        private string CreateScreenShots()
        {
            HTMLBuilder outer = new HTMLBuilder();

            outer.StartTextCenter();
            outer.Text("<h3>Screen shots</h3>");
            outer.NewLine();
            outer.EndTextCenter();

            HTMLBuilder options = new HTMLBuilder();
            HTMLSection a = new HTMLSection("col-md-4");
            HTMLSection b = new HTMLSection("col-md-4");
            HTMLSection c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            AddScreenShot(a, "SS - 2026 07 30-18-47-25-1547.png", "Pick your difficulty and go");
            AddScreenShot(b, "SS - 2026 07 30-18-49-24-8925.png", "Three numbers, a set of operators and a target");
            AddScreenShot(c, "SS - 2026 07 30-18-52-11-6302.png", "Drag the tiles into the row to build your sum");

            outer.Text(options.Output());
            outer.NewLine();

            options = new HTMLBuilder();
            a = new HTMLSection("col-md-4");
            b = new HTMLSection("col-md-4");
            c = new HTMLSection("col-md-4");
            options.SetThreeSections(a, b, c);

            AddScreenShot(a, "SS - 2026 07 30-18-52-14-0969.png", "Land on the target and keep the streak alive");
            AddScreenShot(b, "SS - 2026 07 30-18-52-36-5138.png", "Stuck? A hint fills in part of the answer");
            AddScreenShot(c, "SS - 2026 07 30-18-47-35-5195.png", "Music, sound and stats can all be changed");

            outer.Text(options.Output());
            outer.NewLine();

            return outer.Output();
        }

        private void AddScreenShot(HTMLSection section, string imageName, string caption)
        {
            section.ImagePath($"{ScreenShotFolder}/{imageName}", 90);
            section.StartTextCenter();
            section.Text(caption);
            section.EndTextCenter();
            section.NewLine();
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
