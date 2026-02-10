namespace eWolfAudioShows.Data;

public class ShowEpisodeItem
{
    public ShowEpisodeItem(int number, string name, string description, string mp3, string image)
    {
        Name = name;
        Number = number;
        Description = description;
        Mp3 = mp3;
        Image = image;
    }

    public string Description { get; set; }
    public string Image { get; set; }
    public string Mp3 { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
}