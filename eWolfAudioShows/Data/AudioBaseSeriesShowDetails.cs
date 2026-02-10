using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces;

namespace eWolfAudioShows.Data;

public class AudioBaseSeriesShowDetails : IAudioSeriesShow
{
    public CastHolder Casts { get; set; } = new CastHolder();
    public string DateAdded { get; set; } = string.Empty;
    public string Description { get; set; }
    public string DetailedDescription { get; set; }
    public string OutputPath { get; set; }
    public CastHolder Production { get; set; } = new CastHolder();
    public ShowHolder Shows { get; set; } = new ShowHolder();
    public ShowTypes ShowTypes { get; set; }
    public string Title { get; set; } = null!;
    public int Year { get; set; }
}