using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;

namespace eWolfSiteBuilder._Site.VintageSciFi
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 3)]
    public class Index : PageDetails
    {
        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Vintage Sci-Fi";
            DontBuildPage = true;
        }

        public override void CreatePage()
        {
            WebPage.Output();
        }
    }
}