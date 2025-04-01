using eWolfAudioSiteBuilder.Interfaces;
using eWolfCommon.Helpers;
using System.IO;
using System.Text;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows
{
    internal static class ShowTextCreator
    {
        public static void CreateYTFile(IAudioShow AudioShow)
        {
            string path = $"E:\\_AudioTemp\\_Texts\\{AudioShow.ShowTypes}\\";
            Directory.CreateDirectory(path);
            path = $"{path}\\{FileHelper.GetSafeFileName(AudioShow.Title)}.txt";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(AudioShow.Title);

            if (AudioShow.Title == "A Plague Of Goodness")
            {
                int i = 0;
                i++;
            }

            if (AudioShow.Shows.Shows.Count != 0)
            {
                if (AudioShow.Shows.Shows.Count > 1)
                {
                    for (int i = 0; i < AudioShow.Shows.Shows.Count; i++)
                    {
                        sb.AppendLine($"{AudioShow.Title} | Series {i + 1} of {AudioShow.Shows.Shows.Count} | Radio {AudioShow.ShowTypes}");
                    }
                }
                else
                {
                    if (AudioShow.Shows.Shows[0].Episodes.Count == 0)
                    {
                        sb.AppendLine($"{AudioShow.Title} | Complete Story | Radio {AudioShow.ShowTypes}");
                    }
                    else
                    {
                        sb.AppendLine($"{AudioShow.Title} | Series 1 of 1 | Radio {AudioShow.ShowTypes}");
                    }
                }
            }

            sb.AppendLine();
            sb.AppendLine(AudioShow.Description);
            sb.AppendLine();
            Cast(sb, AudioShow);

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
    }
}