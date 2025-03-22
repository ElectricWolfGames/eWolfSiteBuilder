using eWolfAudioSiteBuilder.Data.Enums;
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

        public List<IAudioShow> OnlyAviableShows()
        {
            var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded));
            var today = DateTime.Now.AddDays(1);
            selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) < today).ToList();
            selectedShows = selectedShows.OrderByDescending(x =>
                DateTime.Parse(x.DateAdded)
                ).ToList();

            return (List<IAudioShow>)selectedShows;
        }
    }
}