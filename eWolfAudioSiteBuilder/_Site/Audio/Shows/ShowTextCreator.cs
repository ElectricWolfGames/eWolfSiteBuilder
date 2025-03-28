using eWolfAudioSiteBuilder.Interfaces;
using eWolfCommon.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eWolfAudioSiteBuilder._Site.Audio.Shows
{
    internal static class ShowTextCreator
    {
        public static  void CreateYTFile(IAudioShow AudioShow)
        {
            string path = $"E:\\_AudioTemp\\_Texts\\{FileHelper.GetSafeFileName(AudioShow.Title)}.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(AudioShow.Title);

            sb.AppendLine();
            sb.AppendLine(AudioShow.Description);
            sb.AppendLine();
            Cast(sb, AudioShow);


            File.WriteAllText(path, sb.ToString());
        }

        private static  void Cast(StringBuilder options, IAudioShow AudioShow)
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
