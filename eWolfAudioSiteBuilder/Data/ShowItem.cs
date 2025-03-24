using System.Windows.Shapes;

namespace eWolfAudioSiteBuilder.Data
{
    public class ShowItem
    {
        public ShowItem(string name)
        {
            Name = name;
        }

        public string Description { get; set; }
        public List<EpisodeItem> Episodes { get; set; } = new List<EpisodeItem>();
        public string Name { get; set; }
        public string YoutubeLink { get; set; }

        internal void AddEpisode(int number, string name)
        {
            var e = new EpisodeItem(number, name);
            Episodes.Add(e);
        }

        internal void AddEpisode(int number, string name, string description)
        {
            var e = new EpisodeItem(number, name, description);
            Episodes.Add(e);
        }

        internal void AddLink(string link)
        {
            if (link.Contains("youtu.be"))
                throw new Exception("You tube linkes need to be just the end code!");

            YoutubeLink = link;
        }
    }
}