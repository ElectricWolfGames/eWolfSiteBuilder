using eWolfAudioShows.Data;
using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces.Interfaces;

namespace eWolfAudioShows.Shows_OLD;

public interface IAudioShowOLD : IHaveCast
{
    string DateAdded { get; set; }
    string Description { get; set; }
    string OutputPath { get; set; }
    CastHolder Production { get; set; }
    ShowHolder Shows { get; set; }
    public ShowTypes ShowTypes { get; set; }
    string Title { get; set; }
    string TitleLine2 { get; set; }
    int Year { get; set; }
}