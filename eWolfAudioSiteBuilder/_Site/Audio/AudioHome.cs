using eWolfAudioSiteBuilder.Data.Enums;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
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
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-4'>");

            WebPage.AppendLine("<div class='col-md-8 blog-main'>");
            WebPage.AppendLine(ShowByType(ShowTypes.Comedy, "Comedy"));
            WebPage.AppendLine("</div>");
            WebPage.AppendLine("</div>");

            WebPage.Append("<div class='container mt-4'>");
            WebPage.AppendLine("<div class='col-md-8 blog-main'>");
            WebPage.AppendLine(ShowByType(ShowTypes.SciFiDrama, "Sci fi Drama"));
            WebPage.AppendLine("</div>");

            WebPage.AppendLine("</div>");

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string ShowByType(ShowTypes showType, string title)
        {
            HTMLBuilder options = new HTMLBuilder();

            options.Text(title);
            options.Text("</br>");
            

            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            var sb = new StringBuilder();

            var comedys = meds.Shows.Where(x => x.ShowTypes == showType);
            comedys = comedys.OrderBy(x => x.Title).ToList();

            string path = "E:\\Projects\\GitHub\\eWolfSiteBuilder\\DemoSiteAudio\\Audio\\Shows\\";

            foreach (var item in comedys)
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    options.Text($"<a href='\\{path}\\{item.Title}.html'>{item.Title}</a>");
                    options.Text("</br>");
                }
            }

            options.Text("</br>");
            options.Text("</br>");
            return options.Output();
        }
    }
}