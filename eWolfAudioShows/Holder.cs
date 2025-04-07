using eWolfAudioShows.Interfaces;
using System.Reflection;

namespace eWolfAudioShows
{
    public static class Holder
    {
        public static List<IAudioShow> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(IAudioShow))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as IAudioShow;

            return updates.ToList();
        }
    }
}
