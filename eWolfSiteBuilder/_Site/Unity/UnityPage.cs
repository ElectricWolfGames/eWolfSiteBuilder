using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfSiteBuilder.SiteDetails;
using eWolfSiteBuilder.SiteDetails.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace eWolfSiteBuilder._Site.Unity
{
    [PageTitle("Index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class UnityPage : PageDetails
    {
        public UnityPage()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Unity3D Packages";
            MenuTitle = "Unity";
        }

        public static string CreateGallary(PreviewItemType previewItemType)
        {
            HTMLBuilder builder = new HTMLBuilder();

            builder.Text("<section id='services' class='services'>");
            builder.Text("<div class='container'>");

            builder.Text("<div class='row'>");

            List<PreviewItem> items = PageDetailsHelper.GetPreviewItem();

            items = items.Where(x => x.PreviewItemType == previewItemType).ToList();

            foreach (var item in items)
            {
                string imagePath = item.ImagePath;
                imagePath = imagePath.Replace("Unity\\", "");

                string itemHRef = item.HRef;
                itemHRef = itemHRef.Replace("Unity\\", "");

                builder.Text("<div class='col-lg-4 col-md-6' >");
                builder.Text("<div class='card border-light'>");
                builder.Text($"<img src='{imagePath}' class='img-fluid' alt=''>");
                builder.Text($"<h4><a href='{itemHRef}'>{item.Name}</a></h4>");
                builder.Text($"<p>{item.Description}</p>");
                builder.Text("</div>");
                builder.Text("</div>");
            }

            builder.Text("</div>");
            builder.Text("</div>");

            builder.Text("</section>");

            return builder.Output();
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../");
            WebPage.StartBody();

            WebPage.StartDiv("<div class='container mt-4'>");
            WebPage.Append(CreateHero());
            WebPage.Append(CreateBuilderHeader());
            WebPage.Append(CreateModelHeader());
            WebPage.Append(CreateSkyboxesHeader());

            WebPage.CloseAllsDiv();
            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateBuilderHeader()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"<h3>Builders</h3>");
            outer.NewLine();
            outer.Text(@"Builders let you create worlds or scenes with extra tools to make things easy");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            outer.Text(CreateGallary(PreviewItemType.Builders));

            return outer.Output();
        }

        private string CreateHero()
        {
            HTMLBuilder options = new HTMLBuilder();

            string link = "<a href='https://assetstore.unity.com/publishers/4249' target='Blank' >Electric Wolf Unity3D Asset Store</a>";
            string heroText = $"Unity3D Assert/packages can be download for the Unity Asset Store</br>" +
                $"You can see all the packages {link}</br></br>" +
                "Feel free to get in touch at Contact@electricWolf.co.uk";
            // TODO: Make sure this Contact@electricWolf.co.uk works

            options.Jumbotron(DisplayTitle, heroText);
            return options.Output();
        }

        private string CreateModelHeader()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"<h3>Models</h3>");
            outer.NewLine();
            outer.Text(@"Model Packages are mostly collections of prefabs you can add to any scene.");
            outer.NewLine();
            outer.Text(@"Some have scripts and tools for extra options.");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            outer.Text(CreateGallary(PreviewItemType.Models));

            return outer.Output();
        }

        private string CreateSkyboxesHeader()
        {
            HTMLBuilder outer = new HTMLBuilder();
            outer.StartTextCenter();
            outer.NewLine();

            outer.Text(@"<h3>Skyboxes</h3>");
            outer.NewLine();
            outer.Text(@"Skyboxes Packages are collections of skyboxs you can add to any camera");
            outer.NewLine();
            outer.NewLine();
            outer.EndTextCenter();

            outer.Text(CreateGallary(PreviewItemType.Skyboxes));

            return outer.Output();
        }
    }
}