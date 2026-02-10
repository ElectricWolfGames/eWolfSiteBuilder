namespace eWolfAudioShows.Data;

public class ShowHolder
{
    public List<ShowItem> ShowItems { get; set; } = [];

    public int ShowCount()
    {
        List<string> showName = ShowItems.Select(x => x.Name).ToList();
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

    internal ShowItem Add(string name)
    {
        var ci = new ShowItem(name);
        ShowItems.Add(ci);
        return ci;
    }
}