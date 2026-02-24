using eWolfAudioShows.Interfaces.Interfaces;
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
}