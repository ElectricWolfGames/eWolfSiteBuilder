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

            //IOrderedEnumerable<IBlog> ordedBlogs = blogs.Blogs.OrderByDescending(x => x.Date);
            //WebPage.Append(AddCarousel(ordedBlogs.ToList()));
            WebPage.Append("<main role='main' class='container'>");
            WebPage.Append("<div class='col-md-8 blog-main'>");
            WebPage.Append("<div class='row'>");

            //WebPage.Append(AddBlogsAsTimeline(ordedBlogs));
            WebPage.Append(ShowList());

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateShowPage(IAudioShow item)
        {
            ShowDisplay showDisplay = new()
            {
                LayoutDetails = item,
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
                string link = CreateShowPage(item);
                sb.Append(item.Title);
                sb.Append($"<li><a href='{item.Title}.html'>{item.Title}</a></li>");
                sb.Append("</br>");
            }
            return sb.ToString();
        }
    }
}