namespace eWolfAudioSiteBuilder.Data
{
    public class ShowHolder
    {
        public List<ShowItem> Shows { get; set; } = new List<ShowItem>();

        internal void Add(string name)
        {
            var ci = new ShowItem(name);
            Shows.Add(ci);
        }
    }
}