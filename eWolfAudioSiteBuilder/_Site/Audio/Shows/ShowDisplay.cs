using eWolfAudioSiteBuilder.Interfaces;
using eWolfBootstrap.Builders;
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

            WebPage.Append(Shows());

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

        private string Shows()
        {
            HTMLBuilder options = new HTMLBuilder();

            foreach (var show in AudioShow.Shows.Shows)
            {
                options.Title(show.Name);
                options.NewLine();
                options.NewLine();
                if (string.IsNullOrWhiteSpace(show.YoutubeLink))
                {
                    options.Text("<h2>Audio comming soon...</h2>");
                }
                else
                    options.YouTubeLinkAudio(show.YoutubeLink);

                options.StartTextCenter();
                options.Text("<h3>Episodes</h3>");
                options.NewLine();
                foreach (var episode in show.Episodes)
                {
                    options.Text($"<h4>{episode.Name}</h4>");
                    options.Text(episode.Description);
                    options.NewLine();
                }
                options.EndTextCenter();
                options.NewLine();
            }
            options.NewLine(); options.NewLine();

            options.StartTextCenter();
            options.Text("<h3>Cast</h3>");
            options.NewLine();
            foreach (var cast in AudioShow.Casts.Casts)
            {
                if (string.IsNullOrWhiteSpace(cast.Role))
                    options.Text($"{cast.FullName}");
                else
                    options.Text($"{cast.FullName} as '{cast.Role}'");
                options.NewLine();
            }
            options.EndTextCenter();
            options.NewLine();
            options.NewLine(); options.NewLine(); options.NewLine();

            return options.Output();
        }
    }
}