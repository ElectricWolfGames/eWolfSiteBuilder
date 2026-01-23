using eWolfAudioShows;
using eWolfAudioShows.Interfaces;

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

        public List<IAudioShow> OnlyAviableShows()
        {
            var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded));
            var today = DateTime.Now.AddDays(0);
            selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) <= today).ToList();
            selectedShows = selectedShows.OrderByDescending(x =>
                DateTime.Parse(x.DateAdded)
                ).ToList();

            return (List<IAudioShow>)selectedShows;
        }

        public List<IAudioShow> OnlyNotAviableShows()
        {
            var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded)).ToList();
            var today = DateTime.Now.AddDays(0);
            selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) >= today).ToList();
            selectedShows = selectedShows.OrderByDescending(x =>
                DateTime.Parse(x.DateAdded)
                ).ToList();

            selectedShows.AddRange(Shows.Where(x => string.IsNullOrWhiteSpace(x.DateAdded)));

            return (List<IAudioShow>)selectedShows;
        }

        private static List<IAudioShow> GetAll()
        {
            return Holder.GetAll();
        }

        private void AddAudioShows()
        {
            _audioShow.AddRange(GetAll());
        }
    }
}