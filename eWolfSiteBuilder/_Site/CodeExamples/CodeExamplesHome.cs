using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.Helpers;

namespace eWolfSiteBuilder._Site.CodeExamples
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class CodeExamplesHome : PageDetailsWolfSite
    {
        public CodeExamplesHome()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Code Examples";
            MenuTitle = "Code Examples";
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-12'>");
            WebPage.Append(CreateHero());

            WebPage.Append("<h2>Unity3d: Editor help</h2>");

            string displayText = "Customizing the inspector for your game objects";
            WebPage.Append($"<li><a href='U3DEditorPart001.html'>{displayText}</a></li>");

            displayText = "Adding extra data on to Enums";
            WebPage.Append($"<li><a href='U3DEnumsAttribute.html'>{displayText}</a></li>");

            //displayText = "Basic API Request";
            //WebPage.Append($"<li><a href='BasicAPIRequest.html'>{displayText}</a></li>");


            //displayText = "Testing Internals Methods";
            //WebPage.Append($"<li><a href='TestingInternalsMethods.html'>{displayText}</a></li>");

            // ProceduralGeneration     
            //displayText = "Procedural Generation";
            //WebPage.Append($"<li><a href='ProceduralGeneration.html'>{displayText}</a></li>");



            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();

            string heroText = $"Unity3d coding tutorials" +
                $"</br></br>" +
                "Feel free to get in touch at Contact@electricWolf.co.uk";
            // TODO: Make sure this Contact@electricWolf.co.uk works

            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }
    }
}