using eWolfAudioShows;
using eWolfAudioShows.Shows_OLD;

namespace eWolfAudioSiteBuilder.Services
{
    public class AudioShowServies
    {
        private List<IAudioShowOLD> _audioShow = new();

        public AudioShowServies()
        {
            AddAudioShows();
        }

        internal List<IAudioShowOLD> Shows
        {
            get
            {
                return _audioShow;
            }
        }

        public List<IAudioShowOLD> OnlyAviableShows()
        {
            var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded));
            var today = DateTime.Now.AddDays(0);
            selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) <= today).ToList();
            selectedShows = selectedShows.OrderByDescending(x =>
                DateTime.Parse(x.DateAdded)
                ).ToList();

            return (List<IAudioShowOLD>)selectedShows;
        }

        public List<IAudioShowOLD> OnlyNotAviableShows()
        {
            var selectedShows = Shows.Where(x => !string.IsNullOrWhiteSpace(x.DateAdded)).ToList();
            var today = DateTime.Now.AddDays(0);
            selectedShows = selectedShows.Where(x => DateTime.Parse(x.DateAdded) >= today).ToList();
            selectedShows = selectedShows.OrderByDescending(x =>
                DateTime.Parse(x.DateAdded)
                ).ToList();

            selectedShows.AddRange(Shows.Where(x => string.IsNullOrWhiteSpace(x.DateAdded)));

            return (List<IAudioShowOLD>)selectedShows;
        }

        private static List<IAudioShowOLD> GetAll()
        {
            return Holder.GetAll();
        }

        private void AddAudioShows()
        {
            _audioShow.AddRange(GetAll());
        }
    }
}