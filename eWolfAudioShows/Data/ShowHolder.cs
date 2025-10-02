namespace eWolfAudioShows.Data
{
    public class ShowHolder
    {
        public List<ShowItem> Shows { get; set; } = [];

        internal ShowItem Add(string name)
        {
            var ci = new ShowItem(name);
            Shows.Add(ci);
            return ci;
        }
    }
}