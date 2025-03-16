using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;

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

            //IOrderedEnumerable<IBlog> ordedBlogs = blogs.Blogs.OrderByDescending(x => x.Date);
            //WebPage.Append(AddCarousel(ordedBlogs.ToList()));
            WebPage.Append("<main role='main' class='container'>");
            WebPage.Append("<div class='col-md-8 blog-main'>");
            WebPage.Append("<div class='row'>");

            //WebPage.Append(AddBlogsAsTimeline(ordedBlogs));

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }
    }
}