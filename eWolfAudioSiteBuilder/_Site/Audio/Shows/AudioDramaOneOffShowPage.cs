using eWolfAudioShows.Data;
using eWolfAudioShows.Interfaces;
using eWolfAudioShows.Interfaces.Interfaces;
using eWolfAudioSiteBuilder.Helper;
using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using eWolfCommon.Helpers;
using System.Text;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows;

[PageTitle("Place holder Page")]
[Navigation(NavigationTypes.Main, 2)]
public class AudioDramaOneOffShowPage : PageDetails
{
    public IAudioDramaOneOffShow AudioShow;

    public AudioDramaOneOffShowPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "To update later";
        MenuTitle = "To update later";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public string OutputPath
    {
        get
        {
            return WebPage.OutputPath;
        }
    }

    public override void CreatePage()
    {
        DisplayTitle = $"Audio Drama {AudioShow.Title} {AudioShow.TitleLine2}";
        Keywords.Add("Audio Drama");
        Keywords.Add("Radio Show, audiobooks full length, audiobook");
        Keywords.Add(AudioShow.ShowTypes.ToString());

        if (AudioShow.ShowTypes == eWolfAudioShows.Data.Enums.ShowTypes.SciFiDrama)
        {
            Keywords.Add("science fiction audiobooks on youtube");
            Keywords.Add("science fiction");
        }

        if (AudioShow.Casts.Casts.Count > 1)
        {
            Keywords.Add($"{AudioShow.Casts.Casts[0].Role}");
            Keywords.Add($"{AudioShow.Casts.Casts[0].FullName}");
        }

        MetaDescription = AudioShow.Description;

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-12'>");

        WebPage.SetRootAddress = RootAddress + "E:\\eWolfSiteUploads\\Audio\\";
        WebPage.HtmlPath = "Shows";
        WebPage.HtmlTitle = $"{FileHelper.GetSafeFileName(MenuTitle)}.html";

        WebPage.SetDontBuild = false;

        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(Jumbotron());

        WebPage.Append(Show());

        WebPage.EndBody();
        WebPage.Output();
    }

    private string Jumbotron()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.AppendLine("<div class='jumbotron'>");
        stringBuilder.AppendLine("<div class='row'>");
        stringBuilder.AppendLine("<div class='col-md-12'>");
        stringBuilder.AppendLine($"<h1>{AudioShow.Title}</h1>");

        stringBuilder.AppendLine("<div class='col-md-12'>");
        stringBuilder.AppendLine($"<p'>{AudioShow.Description}</p>");
        stringBuilder.AppendLine("</div>");
        stringBuilder.AppendLine("</div>");
        stringBuilder.AppendLine("</div>");
        stringBuilder.AppendLine("</div>");

        return stringBuilder.ToString();
    }

    private void ProductinTeam(HTMLBuilder options, CastHolder castHolder)
    {
        options.StartTextCenter();
        var writers = castHolder.Casts.Where(x => x.Role == "WRITER" && !string.IsNullOrEmpty(x.FullName));

        if (writers.Any())
        {
            if (writers.Count() == 1)
                options.Text("<h3>Writen by</h3>");
            else
                options.Text("<h3>Writers</h3>");

            foreach (var writer in writers)
            {
                options.Text($"<h4>{writer.FullName}</h4>");
            }
        }
        options.EndTextCenter();
    }

    private string Show()
    {
        HTMLBuilder options = new();

        if (string.IsNullOrWhiteSpace(AudioShow.YoutubeLink))
        {
            options.Text("<h2>Audio comming soon...</h2>");
        }
        else
            options.YouTubeLinkAudio(AudioShow.YoutubeLink);

        AudioHTMLHelpers.Cast(options, AudioShow);

        ProductinTeam(options, AudioShow.Production);

        //options.NewLine();
        //options.NewLine();

        //AlsoWritenBy(options);

        options.NewLine();
        options.NewLine();

        return options.Output();
    }
}