using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfSiteBuilder.SiteDetails;

namespace eWolfSiteBuilder._Site.Unity.RoadBuilder
{
    [PageTitle("RoadBuilder.html")]
    public class RoadBuilder : PageDetails, IHomePagePreview, IUnityList
    {
        public RoadBuilder()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Road Builder";
            MenuTitle = "Road Builder";
        }

        public int UnityListOrder { get; set; } = 1;

        public override void CreatePage()
        {
            WebPage.AddHeader(this);

            //WebPage.Append();

            WebPage.Output();
        }

        public PreviewItem GetHomePagePreview()
        {
            PreviewItem pi = new PreviewItem()
            {
                HRef = $"{WebPage.HtmlPath}\\{WebPage.HtmlTitle}",
                Name = DisplayTitle,
                ImagePath = @$"{WebPage.HtmlPath}\Images\SciFiObjectsPack1Ad.png",
                Description = "Road Builder Lets you create non-linear roads easily by using a network of nodes. With easy to use buttons to extrude, join, insert nodes and create mesh. Building new roads has never been so easy.",
            };

            return pi;
        }
    }
}