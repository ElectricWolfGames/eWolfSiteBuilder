using eWolfAudioShows.Data;
using eWolfAudioShows.Interfaces.Interfaces;
using eWolfAudioSiteBuilder._Site.Audio.Shows;
using eWolfBootstrap.Builders;

namespace eWolfAudioSiteBuilder.Helper;

internal static class AudioHTMLHelpers
{
    internal static void Cast(HTMLBuilder options, IHaveCast castHolder)
    {
        options.StartTextCenter();
        options.Text("<h3>Cast</h3>");
        options.NewLine();
        foreach (var cast in castHolder.Casts.Casts)
        {
            if (string.IsNullOrWhiteSpace(cast.Role))
                options.Text($"{cast.FullName}");
            else
                options.Text($"{cast.FullName} as '{cast.Role}'");
            options.NewLine();
        }
        options.EndTextCenter();
    }

    internal static string GetListOfActors(IHaveCast castHolder)
    {
        List<string> names = new List<string>();
        foreach (var cast in castHolder.Casts.Casts)
        {
            names.Add($"{cast.FullName}");
        }
        return string.Join(", ", names);
    }

    internal static void ProductinTeam(HTMLBuilder options, IHaveProduction productionTeamHolder)
    {
        options.StartTextCenter();
        var writers = productionTeamHolder.Production.Casts.Where(x => x.Role == "WRITER" && !string.IsNullOrEmpty(x.FullName));

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

    internal static void YouTubeLink(HTMLBuilder options, IHaveYoutubeLink youtubeLink)
    {
        if (string.IsNullOrWhiteSpace(youtubeLink.YoutubeLink))
        {
            options.Text("<h2>Audio comming soon...</h2>");
        }
        else
            options.YouTubeLinkAudio(youtubeLink.YoutubeLink);
    }
}