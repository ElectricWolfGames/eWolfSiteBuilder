namespace eWolfAudioShows.Data;

public class ShowItem
{
    public ShowItem(string name)
    {
        Name = name;
    }

    public string Description { get; set; }
    public List<EpisodeItem> Episodes { get; set; } = [];
    public string Name { get; set; }
    public string PartName { get; set; }
    public string StartName { get; set; }
    public string YoutubeLink { get; set; }

    internal void AddEpisode(int number, string name)
    {
        var e = new EpisodeItem(number, name, string.Empty, string.Empty, string.Empty);
        Episodes.Add(e);
    }

    internal void AddEpisode(int number, string name, string description)
    {
        var e = new EpisodeItem(number, name, description, string.Empty, string.Empty);
        Episodes.Add(e);
    }

    internal void AddEpisode(int number, string name, string description, string mp3, string image)
    {
        var e = new EpisodeItem(number, name, description, mp3, image);
        Episodes.Add(e);
    }

    internal void AddLink(string link)
    {
        if (link.Contains("youtu.be"))
            throw new Exception("You tube linkes need to be just the end code!");

        YoutubeLink = link;
    }
}