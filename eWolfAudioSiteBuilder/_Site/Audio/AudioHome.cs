using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces;
using eWolfAudioShows.Shows_OLD;
using eWolfAudioSiteBuilder._Site.Audio.Shows;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;

namespace eWolfAudioSiteBuilder._Site.Audio
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class AudioHome : PageDetails
    {
        public AudioHome()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Home";

            Keywords.AddRange(
                new string[]
                {
                    "Audio drama",
                });
        }

        public override void CreatePage()
        {
            DisplayTitle = "Audio Dramas";
            WebPage.AddHeader(this, string.Empty);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.Append("<div class='container'>");

            WebPage.Append("</br>");

            WebPage.Append(Jumbotron());

            WebPage.Append("<h3>Radio Shows - Most Recent Releases...</h3>");
            WebPage.Append("<div class='row col-md-16'>");
            WebPage.AppendLine(ShowCardsListByName());
            WebPage.Append("</div>");

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string CreateCard(IAudioEpisodesShow audioEpisodesShow)
        {
            HTMLBuilder options = new();

            string path = "Shows";
            string link = $"{path}\\{FileHelper.GetSafeFileName(audioEpisodesShow.Title)}.html";

            int maxLength = 150;
            string description = audioEpisodesShow.Description;
            if (description.Length >= maxLength)
            {
                description = description.Substring(0, maxLength);
                description += "...";
            }

            string color = "#2E8B57";
            if (audioEpisodesShow.ShowTypes == ShowTypes.Drama)
                color = "#2E578B";

            options.Text($"<div class='card' style='max-width: 18rem; border: 3px solid {color}; border-radius: 10px; margin:10px;' >");
            options.Text($"<div class='card-header text-white' style='background-color: {color};'>");
            options.Text($"<h4><a style='color: #FFFFFF;' href='{link}'>{audioEpisodesShow.Title}</a></h4></div>");
            options.Text("<div class='card-body text-primary'>");
            options.Text($"<p style='color: {color};' class='card-text'>{description}</p>");
            options.Text($"<h5 style='color: #FFFFFF;' class='card-title'><a href='{link}'>{audioEpisodesShow.ShowTypes}</a></h5>");

            options.Text("</div>");
            options.Text("</div>");

            return options.Output();
        }

        private static string Jumbotron()
        {
            HTMLBuilder options = new();
            options.ImageCenter("Title.jpeg", 50);
            return options.Output();
        }

        private string ShowCardsListByName()
        {
            HTMLBuilder options = new();
            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioEpisodesShowServies>();

            var selectedShows = meds.OnlyAviableShows();
            foreach (var item in selectedShows)
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    options.Text(CreateCard(item));
                }
            }

            return options.Output();
        }
    }
}