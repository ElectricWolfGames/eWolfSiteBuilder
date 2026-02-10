namespace eWolfAudioShows.Data;

public class CastHolder
{
    public List<CastItem> Casts { get; set; } = [];

    internal void Add(string role, string name)
    {
        var ci = new CastItem(role, name);
        Casts.Add(ci);
    }
}