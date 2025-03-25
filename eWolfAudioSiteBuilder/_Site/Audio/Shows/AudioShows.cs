using eWolfAudioSiteBuilder.Interfaces;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows
{
    [PageTitle("shows.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class AudioShows : PageDetails
    {
        public AudioShows()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Shows";

            Keywords.AddRange(
                new string[]
                {
                    "Audio Shows",
                });
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container'>");

            WebPage.Append("</br>");

            WebPage.Append(Jumbotron());

            WebPage.Append("<div class='row'>");

            WebPage.Append("<div class='col-md-12'>");
            WebPage.Append("</br>");
            WebPage.Append("</br>");
            WebPage.Append("</div>");

            WebPage.Append("<div class='col-md-5' style='background-color: #EEEEEE; margin:10px;'>");
            WebPage.AppendLine(ShowListByName());
            WebPage.Append("</div>");

            WebPage.Append("<div class='col-md-5' style='background-color: #DDDDDD; margin:10px;'>");
            WebPage.AppendLine(ShowListByYear());
            WebPage.Append("</div>");

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateShowPage(IAudioShow item)
        {
            ShowDisplay showDisplay = new()
            {
                AudioShow = item,
                DisplayTitle = item.Title,
                MenuTitle = item.Title,
            };

            showDisplay.CreatePage();
            return showDisplay.OutputPath;
        }

        private string Jumbotron()
        {
            HTMLBuilder options = new HTMLBuilder();

            options.ImagePath("..//images/Title.jpeg", 50);

            return options.Output();
        }

        private string ShowListByName()
        {
            HTMLBuilder options = new HTMLBuilder();
            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            options.Title("All shows by name");
            foreach (var item in meds.OnlyAviableShows().OrderBy(x => x.Title))
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    string link = CreateShowPage(item);
                    string safeFileName = FileHelper.GetSafeFileName(item.Title);
                    options.Text($"<a style='color: darkblue;' href='{safeFileName}.html'>{item.Title} ({item.ShowTypes})</a>");
                    options.Text("</br>");
                }
            }
            options.Text("</br>");
            options.Text("More to come...");
            return options.Output();
        }

        private string ShowListByYear()
        {
            HTMLBuilder options = new HTMLBuilder();
            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            options.Title("All shows by Broadcast year");
            foreach (var item in meds.OnlyAviableShows().OrderBy(x => x.Year))
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    string link = CreateShowPage(item);
                    string safeFileName = FileHelper.GetSafeFileName(item.Title);
                    options.Text($"<a style='color: darkblue;' href='{safeFileName}.html'>{item.Year} {item.Title} ({item.ShowTypes})</a>");
                    options.Text("</br>");
                }
            }
            options.Text("</br>");
            options.Text("More to come...");
            return options.Output();
        }
    }
}