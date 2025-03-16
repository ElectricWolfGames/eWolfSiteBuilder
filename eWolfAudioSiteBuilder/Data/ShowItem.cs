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

        internal void AddLink(string link)
        {
            YoutubeLink = link;
        }
    }
}