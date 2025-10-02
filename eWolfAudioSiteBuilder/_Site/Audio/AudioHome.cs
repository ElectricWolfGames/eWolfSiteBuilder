using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces;
using eWolfAudioSiteBuilder._Site.Audio.Shows;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;
using System.Text;

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

            /*WebPage.Append("<div class='row'>");
            WebPage.Append("<div class='col-md-5' style='background-color: #EEEEEE; margin:10px;'>");
            WebPage.AppendLine(ShowByType(ShowTypes.Comedy, "Comedy", "Comedy.png"));
            WebPage.Append("</div>");*/

            /*WebPage.Append("<div class='col-md-5' style='background-color: #DDDDDD; margin:10px;'>");
            WebPage.AppendLine(ShowByType(ShowTypes.SciFiDrama, "Sci fi Drama", "sci fi.png"));
            WebPage.Append("</div>");
            WebPage.Append("</div>");*/

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string CreateCard(IAudioShow showDetails)
        {
            HTMLBuilder options = new();

            string path = "Shows";
            string link = $"{path}\\{FileHelper.GetSafeFileName(showDetails.Title)}.html";

            int maxLength = 150;
            string description = showDetails.Description;
            if (description.Length >= maxLength)
            {
                description = description.Substring(0, maxLength);
                description += "...";
            }

            string color = "#2E8B57";
            if (showDetails.ShowTypes == ShowTypes.SciFiDrama)
                color = "#2E578B";

            options.Text($"<div class='card' style='max-width: 18rem; border: 3px solid {color}; border-radius: 10px; margin:10px;' >");
            options.Text($"<div class='card-header text-white' style='background-color: {color};'>");
            options.Text($"<h4><a style='color: #FFFFFF;' href='{link}'>{showDetails.Title}</a></h4></div>");
            options.Text("<div class='card-body text-primary'>");
            options.Text($"<p style='color: {color};' class='card-text'>{description}</p>");
            options.Text($"<h5 style='color: #FFFFFF;' class='card-title'><a href='{link}'>{showDetails.ShowTypes}</a></h5>");

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

        private static string ShowByType(ShowTypes showType, string title, string image)
        {
            HTMLBuilder options = new();
            options.Text("<br>");
            options.ImageCenter(image, 35);
            options.Title(title);

            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            var sb = new StringBuilder();

            var selectedShows = meds.OnlyAviableShows().Where(x => x.ShowTypes == showType);

            string path = "Shows";
            foreach (var item in selectedShows.Take(20))
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    options.Text($"<a style='color: darkblue;' href='{path}\\{FileHelper.GetSafeFileName(item.Title)}.html'>{item.Title}</a>");
                    options.Text("</br>");
                }
            }
            options.Text("</br>");
            options.PageLink("", "- See all shows", ".\\Shows\\shows.html");

            options.Text("</br>");
            options.Text("</br>");
            return options.Output();
        }

        private string ShowCardsListByName()
        {
            HTMLBuilder options = new();
            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            var selectedShows = meds.OnlyAviableShows();
            foreach (var item in selectedShows.Take(21))
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    options.Text(CreateCard(item));
                }
            }

            foreach (var item in meds.Shows)
                ShowTextCreator.CreateYTFile(item);

            return options.Output();
        }
    }
}