using eWolfAudioShows.Data;
using eWolfAudioShows.Data.Enums;
using eWolfAudioShows.Interfaces.Interfaces;

namespace eWolfAudioShows.Interfaces;

public interface IAudioEpisodesShow : IHaveCast,
        IHaveProduction
{
    string DateAdded { get; set; }
    string Description { get; set; }
    string DetailedDescription { get; set; }
    EpisodeHolder Episodes { get; set; }
    string OutputPath { get; set; }

    public ShowTypes ShowTypes { get; set; }
    string Title { get; set; }
    string TitleLine2 { get; set; }
    int Year { get; set; }
    string YTPlayList { get; set; }
}