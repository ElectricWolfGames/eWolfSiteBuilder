using CommonCode;
using eWolfAudioShows.Data;
using eWolfAudioShows.Interfaces;
using eWolfAudioSiteBuilder.Services;
using System.IO;
using System.Security.Policy;
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

    public static void OutputAudioOneOffShow()
    {
        var shows = AudioEpisodesOneOffServies.Store.OnlyNotAviableShows();

        foreach (var show in shows)
        {
            OutputOneOffShowText(show);
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

    private static void Cast(StringBuilder options, IAudioDramaOneOffShow audioShow)
    {
        foreach (var cast in audioShow.Casts.Casts)
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

            if (File.Exists(path))
            {
                count++;
                continue;
            }

            stringBuilder.AppendLine($"{episode.Name} | {count} | {show.Title} {show.TitleLine2} (Audio Drama)");

            stringBuilder.AppendLine();

            stringBuilder.AppendLine($"{episode.Name}");

            if (string.IsNullOrWhiteSpace(episode.FullDescription))
                stringBuilder.AppendLine($"{episode.Description}");
            stringBuilder.AppendLine($"{episode.FullDescription}");

            stringBuilder.AppendLine();
            stringBuilder.AppendLine("PLAYLIST");
            stringBuilder.AppendLine(show.YTPlayList);
            stringBuilder.AppendLine();

            stringBuilder.AppendLine("CAST");
            Cast(stringBuilder, episode);

            // Show
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"{show.Title} {show.TitleLine2}");
            stringBuilder.AppendLine(show.Description);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine();

            File.WriteAllText(path, stringBuilder.ToString());
            count++;
        }
    }

    private static void OutputOneOffShowText(IAudioDramaOneOffShow show)
    {
        if (string.IsNullOrWhiteSpace(show.Title))
            return;
        StringBuilder stringBuilder = new StringBuilder();

        string path = Path.Combine(show.OutputPath, $"{StringsHelper.MakeFileNameSafe(show.Title)}.txt");

        if (File.Exists(path))
        {
            return;
        }

        stringBuilder.AppendLine($"{show.Title} | {show.TitleLine2} | (Audio Drama {show.StoryType})");

        stringBuilder.AppendLine();

        stringBuilder.AppendLine($"{show.Title}");

        stringBuilder.AppendLine($"{show.Description}");

        stringBuilder.AppendLine();
        stringBuilder.AppendLine("PLAYLIST");
        stringBuilder.AppendLine(show.YTPlayList);
        stringBuilder.AppendLine();

        stringBuilder.AppendLine("CAST");
        Cast(stringBuilder, show);

        stringBuilder.AppendLine();

        File.WriteAllText(path, stringBuilder.ToString());
    }
}