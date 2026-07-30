using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;

namespace eWolfSiteBuilder._Site.VintageSciFi
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 4)]
    public class Index : PageDetails
    {
        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Vintage Sci-Fi";
        }

        public override void CreatePage()
        {
        }
    }
}