using eWolfAudioSiteBuilder.Helper;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;

namespace eWolfAudioSiteBuilder._Site.Audio;

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
        DisplayTitle = "Audio Dramas";
        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../");
        WebPage.StartBody();

        WebPage.Append("<div class='container'>");

        WebPage.Append("</br>");

        WebPage.Append(Jumbotron());

        WebPage.Append("<h3>Radio Shows - Most Recent Releases...</h3>");
        WebPage.Append("<div class='row col-md-16'>");
        WebPage.AppendLine(ShowCardsListByName());
        WebPage.Append("</div>");

        WebPage.Append("</div>");

        WebPage.EndBody();
        WebPage.Output();
    }

    private static string Jumbotron()
    {
        HTMLBuilder options = new();
        //options.ImageCenter("Title.jpeg", 50);
        return options.Output();
    }

    private string ShowCardsListByName()
    {
        HTMLBuilder options = new();
        var meds = SiteBuilderServiceLocator.Instance.GetService<AudioEpisodesShowServies>();

        var selectedShows = meds.OnlyAviableShows();
        foreach (var item in selectedShows)
        {
            if (!string.IsNullOrEmpty(item.Title))
            {
                options.Text(CommonHelpers.CreateCard(item));
            }
        }

        return options.Output();
    }
}