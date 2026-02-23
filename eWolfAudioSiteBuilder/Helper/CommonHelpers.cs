using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces;
using eWolfBootstrap.Builders;
using eWolfCommon.Helpers;

namespace eWolfAudioSiteBuilder.Helper;

internal class CommonHelpers
{
    internal static string CreateCard(IAudioEpisodesShow audioEpisodesShow)
    {
        HTMLBuilder options = new();

        string path = "Shows";
        string link = $"{path}\\{FileHelper.GetSafeFileName(audioEpisodesShow.Title)}.html";

        int maxLength = 150;
        string description = audioEpisodesShow.Description;
        if (description.Length >= maxLength)
        {
            description = description.Substring(0, maxLength);
            description += "...";
        }

        string color = "#2E8B57";
        if (audioEpisodesShow.ShowTypes == ShowTypes.Drama)
            color = "#2E578B";

        options.Text($"<div class='card' style='max-width: 18rem; border: 3px solid {color}; border-radius: 10px; margin:10px;' >");
        options.Text($"<div class='card-header text-white' style='background-color: {color};'>");
        options.Text($"<h4><a style='color: #FFFFFF;' href='{link}'>{audioEpisodesShow.Title} (Series)</a></h4></div>");
        options.Text("<div class='card-body text-primary'>");
        options.Text($"<p style='color: {color};' class='card-text'>{description}</p>");
        options.Text($"<h5 style='color: #FFFFFF;' class='card-title'><a href='{link}'>{audioEpisodesShow.ShowTypes}</a></h5>");

        options.Text("</div>");
        options.Text("</div>");

        return options.Output();
    }

    internal static string CreateCard(IAudioDramaOneOffShow audioEpisodesShow)
    {
        HTMLBuilder options = new();

        string path = "Shows";
        string link = $"{path}\\{FileHelper.GetSafeFileName(audioEpisodesShow.Title)}.html";

        int maxLength = 150;
        string description = audioEpisodesShow.Description;
        if (description.Length >= maxLength)
        {
            description = description.Substring(0, maxLength);
            description += "...";
        }

        string color = "#2E8B57";
        if (audioEpisodesShow.ShowTypes == ShowTypes.Drama)
            color = "#2E578B";

        options.Text($"<div class='card' style='max-width: 18rem; border: 3px solid {color}; border-radius: 10px; margin:10px;' >");
        options.Text($"<div class='card-header text-white' style='background-color: {color};'>");
        options.Text($"<h4><a style='color: #FFFFFF;' href='{link}'>{audioEpisodesShow.Title}</a></h4></div>");
        options.Text("<div class='card-body text-primary'>");
        options.Text($"<p style='color: {color};' class='card-text'>{description}</p>");
        options.Text($"<h5 style='color: #FFFFFF;' class='card-title'><a href='{link}'>{audioEpisodesShow.ShowTypes}</a></h5>");

        options.Text("</div>");
        options.Text("</div>");

        return options.Output();
    }
}