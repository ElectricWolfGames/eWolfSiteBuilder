using eWolfAudioShows.Data;
using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces.Interfaces;

namespace eWolfAudioShows.Interfaces;

public interface IAudioSeriesShow : IHaveCast
{
    string DateAdded { get; set; }
    string Description { get; set; }
    string DetailedDescription { get; set; }
    string OutputPath { get; set; }
    CastHolder Production { get; set; }
    ShowHolder Shows { get; set; }
    public ShowTypes ShowTypes { get; set; }
    string Title { get; set; }
    int Year { get; set; }
}