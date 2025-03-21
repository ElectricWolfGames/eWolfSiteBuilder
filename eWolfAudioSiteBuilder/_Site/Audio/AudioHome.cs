﻿using eWolfAudioSiteBuilder.Data.Enums;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;
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

            WebPage.Append("<div class='container'>");
            WebPage.Append("<h2>Radio Shows</h2>");

            WebPage.Append("<h2>Most Recent Releases</h2>");
            WebPage.Append("<div class='row'>");

            WebPage.Append("<div class='col-md-6' style='background-color: #EEEEEE;'>");
            WebPage.AppendLine(ShowByType(ShowTypes.Comedy, "Comedy", "Comedy.png"));
            WebPage.Append("</div>");

            WebPage.Append("<div class='col-md-6' style='background-color: #DDDDDD;'>");
            WebPage.AppendLine(ShowByType(ShowTypes.SciFiDrama, "Sci fi Drama", "sci fi.png"));
            WebPage.Append("</div>");
            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string ShowByType(ShowTypes showType, string title, string image)
        {
            HTMLBuilder options = new HTMLBuilder();
            options.Text("<br>");
            options.ImageCenter(image, 35);
            options.Title(title);

            var meds = SiteBuilderServiceLocator.Instance.GetService<AudioShowServies>();

            var sb = new StringBuilder();

            var selectedShows = meds.Shows.Where(x => x.ShowTypes == showType && !string.IsNullOrWhiteSpace(x.DateAdded));

            var today = DateTime.Now.AddDays(1);
            selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) < today).ToList();
            selectedShows = selectedShows.OrderByDescending(x =>
                DateTime.Parse(x.DateAdded)
                ).ToList();

            string path = "Shows";

            foreach (var item in selectedShows.Take(5))
            {
                if (!string.IsNullOrEmpty(item.Title))
                {
                    options.Text($"<a href='{path}\\{FileHelper.GetSafeFileName(item.Title)}.html'>{item.Title}</a>");
                    options.Text("</br>");
                }
            }

            options.Text("</br>");
            options.Text("</br>");
            return options.Output();
        }
    }
}