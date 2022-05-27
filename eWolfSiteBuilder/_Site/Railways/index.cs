using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;

namespace eWolfSiteBuilder._Site.Railways
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class Index : PageDetails
    {
        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Railways";
            DontBuildPage = true;
        }

        public override void CreatePage()
        {
            WebPage.Output();
        }
    }
}