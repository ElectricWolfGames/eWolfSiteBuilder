using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using eWolfBootstrap.SiteBuilder;

namespace eWolfAudioSiteBuilder.Services;

public class AudioEpisodesShowServies
{
    private readonly List<IAudioEpisodesShow> _audioShow = new();

    public AudioEpisodesShowServies()
    {
        AddAudioShows();
    }

    public static AudioEpisodesShowServies Store
    {
        get
        {
            return SiteBuilderServiceLocator.Instance.GetService<AudioEpisodesShowServies>();
        }
    }

    internal List<IAudioEpisodesShow> Shows
    {
        get
        {
            return _audioShow;
        }
    }

    public List<IAudioEpisodesShow> OnlyAviableShows()
    {
        var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded));
        var today = DateTime.Now.AddDays(0);
        selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) <= today).ToList();
        selectedShows = selectedShows.OrderByDescending(x =>
            DateTime.Parse(x.DateAdded)
            ).ToList();

        return (List<IAudioEpisodesShow>)selectedShows;
    }

    public List<IAudioEpisodesShow> OnlyNotAviableShows()
    {
        var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded)).ToList();
        var today = DateTime.Now.AddDays(0);
        selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) >= today).ToList();
        selectedShows = selectedShows.OrderByDescending(x =>
            DateTime.Parse(x.DateAdded)
            ).ToList();

        selectedShows.AddRange(Shows.Where(x => string.IsNullOrWhiteSpace(x.DateAdded)));

        return (List<IAudioEpisodesShow>)selectedShows;
    }

    private static List<IAudioEpisodesShow> GetAllEpisodesShow()
    {
        return Holder.GetAllEpisodesShow();
    }

    private void AddAudioShows()
    {
        _audioShow.AddRange(GetAllEpisodesShow());
    }
}