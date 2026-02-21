using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using eWolfBootstrap.SiteBuilder;

namespace eWolfAudioSiteBuilder.Services;

public class AudioEpisodesOneOffServies
{
    private readonly List<IAudioDramaOneOffShow> _audioShow = new();

    public AudioEpisodesOneOffServies()
    {
        AddAudioShows();
    }

    public static AudioEpisodesOneOffServies Store
    {
        get
        {
            return SiteBuilderServiceLocator.Instance.GetService<AudioEpisodesOneOffServies>();
        }
    }

    internal List<IAudioDramaOneOffShow> Shows
    {
        get
        {
            return _audioShow;
        }
    }

    public List<IAudioDramaOneOffShow> OnlyAviableShows()
    {
        var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded));
        var today = DateTime.Now.AddDays(0);
        selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) <= today).ToList();
        selectedShows = selectedShows.OrderByDescending(x =>
            DateTime.Parse(x.DateAdded)
            ).ToList();

        return (List<IAudioDramaOneOffShow>)selectedShows;
    }

    public List<IAudioDramaOneOffShow> OnlyNotAviableShows()
    {
        var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded)).ToList();
        var today = DateTime.Now.AddDays(0);
        selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) >= today).ToList();
        selectedShows = selectedShows.OrderByDescending(x =>
            DateTime.Parse(x.DateAdded)
            ).ToList();

        selectedShows.AddRange(Shows.Where(x => string.IsNullOrWhiteSpace(x.DateAdded)));

        return (List<IAudioDramaOneOffShow>)selectedShows;
    }

    private void AddAudioShows()
    {
        _audioShow.AddRange(Holder.GetAllIAudioDramaOneOffShow());
    }
}