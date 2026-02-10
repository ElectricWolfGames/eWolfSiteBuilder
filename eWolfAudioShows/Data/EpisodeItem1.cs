namespace eWolfAudioShows.Data;

public class EpisodeItem
{
    public EpisodeItem(string name)
    {
        Name = name;
    }

    public CastHolder Casts { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string OutputPath { get; set; }
    public string PartName { get; set; }
    public CastHolder Production { get; set; } = new CastHolder();
    public string StartName { get; set; }
    public string YoutubeLink { get; set; }

    internal void AddLink(string link)
    {
        if (link.Contains("youtu.be"))
            throw new Exception("You tube linkes need to be just the end code!");

        YoutubeLink = link;
    }
}