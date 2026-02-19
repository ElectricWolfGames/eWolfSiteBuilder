using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces;

namespace eWolfAudioShows.Data;

public class AudioBaseOneOffShowDetails : IAudioDramaOneOffShow
{
    public CastHolder Casts { get; set; } = new CastHolder();
    public string DateAdded { get; set; }
    public string Description { get; set; }
    public string OutputPath { get; set; }
    public CastHolder Production { get; set; } = new CastHolder();
    public ShowTypes ShowTypes { get; set; }
    public string Title { get; set; }
    public string TitleLine2 { get; set; }
    public int Year { get; set; }
    public string YTPlayList { get; set; }
}