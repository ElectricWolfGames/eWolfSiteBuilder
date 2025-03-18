namespace eWolfAudioSiteBuilder.Data
{
    public class EpisodeItem
    {
        public EpisodeItem(int number, string name)
        {
            Name = name;
            Number = number;
        }

        public EpisodeItem(int number, string name, string description)
        {
            Name = name;
            Number = number;
            Description = description;
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}