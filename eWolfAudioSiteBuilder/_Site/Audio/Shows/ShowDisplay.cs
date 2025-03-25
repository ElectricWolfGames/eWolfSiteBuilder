using eWolfAudioSiteBuilder.Interfaces;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;
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
            WebPage.HtmlTitle = $"{FileHelper.GetSafeFileName(MenuTitle)}.html";

            WebPage.SetDontBuild = false;

            WebPage.Append("<div class='container mt-4'>");
            WebPage.Append(Jumbotron());

            WebPage.Append(Show());

            WebPage.EndBody();
            WebPage.Output();
        }

        private void AlsoWritenBy(HTMLBuilder options)
        {
            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();
            var writers = AudioShow.Production.Casts.Where(x => x.Role == "WRITER" && !string.IsNullOrEmpty(x.FullName));

            List<IAudioShow> alsoBy = new List<IAudioShow>();
            foreach (var writer in writers)
            {
                var selectedShows = meds.OnlyAviableShows().Where(x =>
                     x.Production.Casts.Any(x => x.FullName == writer.FullName));

                foreach (var ss in selectedShows)
                {
                    if (ss.Title == AudioShow.Title)
                        continue;
                    alsoBy.Add(ss);
                }
            }

            if (alsoBy.Any())
            {
                options.Text("<div class='container mt-5'>");
                options.Text("<h4>By the same writers</h4>");
                options.Text("<div class='row'>");
                foreach (var ss in alsoBy)
                {
                    options.Text(CreateCard(ss));
                }
                options.Text("</div>");
                options.Text("</div>");
            }
        }

        private void Cast(HTMLBuilder options)
        {
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
        }

        private string CreateCard(IAudioShow showDetails)
        {
            HTMLBuilder options = new HTMLBuilder();

            string link = $"{FileHelper.GetSafeFileName(showDetails.Title)}.html";

            options.Text("<div class='card' style='max-width: 18rem; border: 3px solid #2E8B57; border-radius: 10px; margin:10px;' >");
            options.Text("<div class='card-header text-white' style='background-color: #2E8B57;'>");
            options.Text($"<h4><a style='color: #FFFFFF;' href='{link}'>{showDetails.Title}</a></h4></div>");
            options.Text("<div class='card-body text-primary'>");
            options.Text($"<p style='color: #2E8B57;' class='card-text'>{showDetails.Description}</p>");
            options.Text($"<h5 style='color: #FFFFFF;' class='card-title'><a href='{link}'>{showDetails.ShowTypes}</a></h5>");

            options.Text("</div>");
            options.Text("</div>");

            return options.Output();
        }

        private void Episodes(HTMLBuilder options)
        {
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

                if (show.Episodes.Count > 0)
                {
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
            }
            options.NewLine(); options.NewLine();
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

        private void ProductinTeam(HTMLBuilder options)
        {
            options.StartTextCenter();
            var writers = AudioShow.Production.Casts.Where(x => x.Role == "WRITER" && !string.IsNullOrEmpty(x.FullName));

            if (writers.Any())
            {
                if (writers.Count() == 1)
                    options.Text("<h3>Writen by</h3>");
                else
                    options.Text("<h3>Writers</h3>");

                foreach (var writer in writers)
                {
                    options.Text($"<h4>{writer.FullName}</h4>");
                }
            }
            options.EndTextCenter();
        }

        private string Show()
        {
            HTMLBuilder options = new HTMLBuilder();

            Episodes(options);

            Cast(options);

            ProductinTeam(options);

            options.NewLine();
            options.NewLine();

            AlsoWritenBy(options);

            options.NewLine();
            options.NewLine();

            return options.Output();
        }
    }
}