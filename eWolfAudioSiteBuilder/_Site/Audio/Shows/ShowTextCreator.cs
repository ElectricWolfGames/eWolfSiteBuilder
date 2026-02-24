using eWolfAudioShows.Shows_OLD;
using eWolfAudioSiteBuilder.Process;
using eWolfCommon.Helpers;
using System.IO;
using System.Text;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows;

internal static class ShowTextCreator
{
    public static void CreateYTFile(IAudioShowOLD audioShow)
    {
        CreateTimeStampFile(audioShow);

        string path = $"E:\\_AudioTemp\\_Texts\\{audioShow.ShowTypes}\\";

        if (!string.IsNullOrWhiteSpace(audioShow.OutputPath))
            path = audioShow.OutputPath;

        Directory.CreateDirectory(path);
        path = $"{path}\\{FileHelper.GetSafeFileName(audioShow.Title)}.txt";

        StringBuilder sb = new();
        sb.AppendLine(audioShow.Title);

        if (audioShow.Shows.ShowItems.Count != 0)
        {
            if (audioShow.Shows.ShowItems.Count > 1)
            {
                for (int i = 0; i < audioShow.Shows.ShowItems.Count; i++)
                {
                    sb.AppendLine($"{audioShow.Title} | Series {i + 1} of {audioShow.Shows.ShowItems.Count} | Radio {audioShow.ShowTypes}");
                }
            }
            else
            {
                if (audioShow.Shows.ShowItems[0].Episodes.Count == 0)
                {
                    sb.AppendLine($"{audioShow.Title} | Complete Story | Radio {audioShow.ShowTypes}");
                }
                else
                {
                    sb.AppendLine($"{audioShow.Title} | Series 1 of 1 | Radio {audioShow.ShowTypes}");
                }
            }
        }

        sb.AppendLine();
        sb.AppendLine(audioShow.Description);
        sb.AppendLine();

        sb.AppendLine("You can find more at");
        sb.AppendLine("https://electricwolf.co.uk/Audio/index.html");

        sb.AppendLine();

        OutputHelperText.Cast(sb, audioShow);

        Episodes(sb, audioShow);

        // TODO:Add the series and episodes if we have more then one of them

        File.WriteAllText(path, sb.ToString());
    }

    private static void CreateTimeStampFile(IAudioShowOLD audioShow)
    {
        if (string.IsNullOrWhiteSpace(audioShow.OutputPath))
            return;

        string path = $"{audioShow.OutputPath}\\Timestamps.txt";

        if (File.Exists(path))
            return;

        StringBuilder sb = new();
        sb.AppendLine(audioShow.Title);

        int count = 1;
        foreach (var show in audioShow.Shows.ShowItems)
        {
            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Empty);
            sb.AppendLine($"Series {count++}");
            sb.AppendLine("TIMESTAMPS");

            TimeSpan timeSpan = new();
            foreach (var ep in show.Episodes)
            {
                // 00:00:00 Episode One
                sb.AppendLine($"{timeSpan} {ep.Name}");
                timeSpan += new TimeSpan(0, 27, 0);
            }
            sb.AppendLine(string.Empty);
        }

        sb.AppendLine();

        File.WriteAllText(path, sb.ToString());
    }

    private static void Episodes(StringBuilder sb, IAudioShowOLD audioShow)
    {
        int count = 1;
        foreach (var show in audioShow.Shows.ShowItems)
        {
            sb.AppendLine(string.Empty);
            sb.AppendLine($"Series {count++}");

            int epiCount = 1;
            foreach (var ep in show.Episodes)
            {
                sb.AppendLine($"{epiCount++}. {ep.Name}: {ep.Description}");
                sb.AppendLine(string.Empty);
            }
            sb.AppendLine(string.Empty);
        }
        /*
        sb.AppendLine(string.Empty);
        sb.AppendLine(string.Empty);
        sb.AppendLine(string.Empty);

        count = 0;
        foreach (var show in audioShow.Shows.Shows)
        {
            int epCount = 1; count++;
            foreach (var ep in show.Episodes)
            {
                string name = $"s0{count}e0{epCount++}";

                sb.AppendLine($"EpisodeDetails {name} = new EpisodeDetails();");
                sb.AppendLine($"{name}.TitleExtra = \"\";");
                sb.AppendLine($"{name}.Title = \"{name} {ep.Name}\";");
                sb.AppendLine($"{name}.Description = \"{ep.Description}\";");
                sb.AppendLine($"showDetails.EpisodeDetails.Add({name});");
                sb.AppendLine(string.Empty);
            }
            sb.AppendLine(string.Empty);
        }*/
    }
}