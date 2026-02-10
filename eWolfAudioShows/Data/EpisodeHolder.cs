namespace eWolfAudioShows.Data;

public class EpisodeHolder
{
    public List<EpisodeItem> EpisodeItems { get; set; } = [];

    public int ShowCount()
    {
        List<string> showName = EpisodeItems.Select(x => x.Name).ToList();
        List<string> newNames = new List<string>();

        foreach (var str in showName)
        {
            string update = str.Replace("Part A", string.Empty);
            update = update.Replace("Part B", string.Empty);
            update = update.Replace("Part C", string.Empty);
            update = update.Replace("Part D", string.Empty);

            newNames.Add(update);
        }
        newNames = newNames.Distinct().ToList();

        return newNames.Count();
    }

    internal EpisodeItem Add(string name)
    {
        var ci = new EpisodeItem(name);
        EpisodeItems.Add(ci);
        return ci;
    }
}