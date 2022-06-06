using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;

namespace eWolfSiteBuilder._Site
{
    // TODO: Links to railway don't work when on thoer pages.

    [PageTitle("Index.html")]
    [Navigation(NavigationTypes.Main, 0)]
    public class Index : PageDetails
    {
        public Index()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Home";
            MenuTitle = "Home";
        }

        public static string CreateGallary()
        {
            HTMLBuilder builder = new HTMLBuilder();

            builder.Text("<section id='services' class='services'>");
            builder.Text("<div class='container'>");

            builder.Text("<div class='section-title'>");
            builder.Text("  <h2>Unity3D Tools</h2>");

            builder.Text("  <h3>Check our <span><a href='Unity/Index.html'></i>Unity3D projects</a></span></h3>");
            builder.Text("  <p>All packages are available on the Assert store.</p>");
            builder.Text("</div>");

            builder.Text("<div class='row'>");

            List<PreviewItem> items = PageDetailsHelper.GetPreviewItem();

            foreach (var item in items)
            {
                builder.Text("<div class='col-lg-4 col-md-6' >");
                builder.Text("<div class='card border-light'>");
                builder.Text($"<img src='{item.ImagePath}' class='img-fluid' alt=''>");
                builder.Text($"<h4><a href='{item.HRef}'>{item.Name}</a></h4>");
                builder.Text($"<p>{item.Description}</p>");
                builder.Text("</div>");
                builder.Text("</div>");
            }

            builder.Text("</div>");
            builder.Text("</div>");

            builder.Text("</section>");

            return builder.Output();
        }

        public static string CreateHero()
        {
            HTMLBuilder builder = new HTMLBuilder();

            builder.Text("<section id='hero' class='d-flex align-items-center'>");
            builder.Text("<div class='container' data-aos='zoom-out' data-aos-delay='100'>");
            builder.Text("<h1>Welcome to <span>Electric Wolf</spa>");
            builder.Text("</h1>");
            builder.Text("<h2>Electric wolf excels at creating user friendly tools with Unity3D </h2>");
            builder.Text("<div class='d-flex'>");
            builder.Text("<a href='#services' class='btn-get-started scrollto'>Take a look</a>");
            //builder.Text("<a href='https://www.youtube.com/watch?v=jDDaplaOz7Q' class='venobox btn-watch-video' data-vbtype='video' data-autoplay='true'> Watch Video <i class='icofont-play-alt-2'></i></a>");
            builder.Text("</div>");
            builder.Text("</div>");
            builder.Text("</section>");

            return builder.Output();
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main);
            WebPage.StartBody();

            WebPage.Append(CreateHero());
            WebPage.Append(CreateGallary());
            WebPage.AddStickyHeader("myHeader");

            WebPage.EndBody();
            WebPage.Output();
        }
    }
}