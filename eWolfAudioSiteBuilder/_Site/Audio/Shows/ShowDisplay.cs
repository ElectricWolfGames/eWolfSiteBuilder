using eWolfAudioSiteBuilder.Interfaces;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using System.Text;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    public class ShowDisplay : PageDetails
    {
        public IAudioShow AudioShow;

        public ShowDisplay()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "To update later";
            MenuTitle = "To update later";
            DontShowNavigation = true;
            DontBuildPage = true;
        }

        public string OutputPath
        {
            get
            {
                return WebPage.OutputPath;
            }
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.SetRootAddress = RootAddress + "E:\\Projects\\GitHub\\eWolfSiteBuilder\\DemoSiteAudio\\Audio\\";
            WebPage.HtmlPath = "Shows";
            WebPage.HtmlTitle = $"{MenuTitle}.html";

            WebPage.SetDontBuild = false;

            WebPage.Append("<div class='container mt-4'>");

            WebPage.Append(Jumbotron());

            WebPage.EndBody();
            WebPage.Output();
        }

        private string Jumbotron()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine($"<h1>{AudioShow.Title}</h1>");

            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine($"<p'>{AudioShow.Description}</p>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}