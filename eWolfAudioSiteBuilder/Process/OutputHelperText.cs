using eWolfAudioShows.Data;
using eWolfAudioShows.Interfaces;
using eWolfAudioShows.Shows_OLD;
using eWolfAudioSiteBuilder._Site.Audio.Shows;
using eWolfAudioSiteBuilder.Services;
using System.IO;
using System.Text;

namespace eWolfAudioSiteBuilder.Process;

public static class OutputHelperText
{
    public static void OutputAudioEpisodesShow()
    {
        var shows = AudioEpisodesShowServies.Store.OnlyNotAviableShows();

        foreach (var show in shows)
        {
            OutputEpisodesShowText(show);
        }
    }

    private static void Cast(StringBuilder options, EpisodeItem AudioShow)
    {
        foreach (var cast in AudioShow.Casts.Casts)
        {
            if (string.IsNullOrWhiteSpace(cast.Role))
                options.AppendLine($"{cast.FullName}");
            else
                options.AppendLine($"{cast.FullName} as '{cast.Role}'");
        }
    }

    private static void OutputEpisodesShowText(IAudioEpisodesShow show)
    {
        int count = 1;
        foreach (var episode in show.Episodes.EpisodeItems)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string path = Path.Combine(show.OutputPath, episode.OutputPath, $"{episode.Name}.txt");
            stringBuilder.AppendLine($"{episode.Name} | {count} | {show.Title}");

            stringBuilder.AppendLine();

            stringBuilder.AppendLine($"{episode.Name}");
            if (string.IsNullOrWhiteSpace(episode.FullDescription))
                stringBuilder.AppendLine($"{episode.Description}");
            stringBuilder.AppendLine($"{episode.FullDescription}");

            stringBuilder.AppendLine();
            stringBuilder.AppendLine();

            Cast(stringBuilder, episode);

            File.WriteAllText(path, stringBuilder.ToString());
            count++;
        }
    }
}