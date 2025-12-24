using eWolfAudioShows.Interfaces;
using eWolfCommon.Helpers;
using System.IO;
using System.Text;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows
{
    internal static class ShowTextCreator
    {
        public static void CreateYTFile(IAudioShow audioShow)
        {
            CreateTimeStampFile(audioShow);

            string path = $"E:\\_AudioTemp\\_Texts\\{audioShow.ShowTypes}\\";

            if (!string.IsNullOrWhiteSpace(audioShow.OutputPath))
                path = audioShow.OutputPath;

            Directory.CreateDirectory(path);
            path = $"{path}\\{FileHelper.GetSafeFileName(audioShow.Title)}.txt";

            StringBuilder sb = new();
            sb.AppendLine(audioShow.Title);

            if (audioShow.Shows.Shows.Count != 0)
            {
                if (audioShow.Shows.Shows.Count > 1)
                {
                    for (int i = 0; i < audioShow.Shows.Shows.Count; i++)
                    {
                        sb.AppendLine($"{audioShow.Title} | Series {i + 1} of {audioShow.Shows.Shows.Count} | Radio {audioShow.ShowTypes}");
                    }
                }
                else
                {
                    if (audioShow.Shows.Shows[0].Episodes.Count == 0)
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

            Cast(sb, audioShow);

            Episodes(sb, audioShow);

            // TODO:Add the series and episodes if we have more then one of them

            File.WriteAllText(path, sb.ToString());
        }

        private static void Cast(StringBuilder options, IAudioShow AudioShow)
        {
            foreach (var cast in AudioShow.Casts.Casts)
            {
                if (string.IsNullOrWhiteSpace(cast.Role))
                    options.AppendLine($"{cast.FullName}");
                else
                    options.AppendLine($"{cast.FullName} as '{cast.Role}'");
            }
        }

        private static void CreateTimeStampFile(IAudioShow audioShow)
        {
            if (string.IsNullOrWhiteSpace(audioShow.OutputPath))
                return;

            string path = $"{audioShow.OutputPath}\\Timestamps.txt";

            if (File.Exists(path))
                return;

            StringBuilder sb = new();
            sb.AppendLine(audioShow.Title);

            int count = 1;
            foreach (var show in audioShow.Shows.Shows)
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

        private static void Episodes(StringBuilder sb, IAudioShow audioShow)
        {
            int count = 1;
            foreach (var show in audioShow.Shows.Shows)
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
}