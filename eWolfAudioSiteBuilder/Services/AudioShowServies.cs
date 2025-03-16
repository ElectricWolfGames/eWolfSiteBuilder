using eWolfAudioSiteBuilder.Interfaces;
using System.Reflection;

namespace eWolfAudioSiteBuilder.Services
{
    public class AudioShowServies
    {
        private List<IAudioShow> _audioShow = new();

        public AudioShowServies()
        {
            AddAudioShows();
        }

        internal List<IAudioShow> Shows
        {
            get
            {
                return _audioShow;
            }
        }

        private static List<IAudioShow> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(IAudioShow))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as IAudioShow;

            return updates.ToList();
        }

        private void AddAudioShows()
        {
            _audioShow.AddRange(GetAll());
        }
    }
}