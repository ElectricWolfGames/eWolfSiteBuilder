using eWolfAudioShows.Interfaces;
using eWolfAudioShows.Shows_OLD;
using System.Reflection;

namespace eWolfAudioShows;

public static class Holder
{
    public static List<IAudioEpisodesShow> GetAllEpisodesShow()
    {
        var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                      where t.GetInterfaces().Contains(typeof(IAudioEpisodesShow))
                            && t.GetConstructor(Type.EmptyTypes) != null
                      select Activator.CreateInstance(t) as IAudioEpisodesShow;

        return updates.ToList();
    }

    public static List<IAudioDramaOneOffShow> GetAllIAudioDramaOneOffShow()
    {
        var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                      where t.GetInterfaces().Contains(typeof(IAudioDramaOneOffShow))
                            && t.GetConstructor(Type.EmptyTypes) != null
                      select Activator.CreateInstance(t) as IAudioDramaOneOffShow;

        return updates.ToList();
    }
}