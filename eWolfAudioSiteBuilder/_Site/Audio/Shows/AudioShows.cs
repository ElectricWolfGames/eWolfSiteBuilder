using eWolfAudioSiteBuilder.Interfaces;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using System.Text;

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

            WebPage.Append("<div class='container mt-4'>");

            WebPage.AppendLine("<div class='col-md-8 blog-main'>");
            WebPage.AppendLine(ShowList());
            WebPage.AppendLine("</div>");

            WebPage.AppendLine("</div>");
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

        private string ShowList()
        {
            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            var sb = new StringBuilder();

            foreach (var item in meds.Shows)
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    string link = CreateShowPage(item);
                    sb.Append($"<a href='{item.Title}.html'>{item.Title}</a>");
                    sb.Append("</br>");
                }
            }
            return sb.ToString();
        }
    }
}