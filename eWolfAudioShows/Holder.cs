using eWolfAudioShows.Shows_OLD;
using System.Reflection;

namespace eWolfAudioShows;

public static class Holder
{
    public static List<IAudioShowOLD> GetAll()
    {
        var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                      where t.GetInterfaces().Contains(typeof(IAudioShowOLD))
                            && t.GetConstructor(Type.EmptyTypes) != null
                      select Activator.CreateInstance(t) as IAudioShowOLD;

        return updates.ToList();
    }
}