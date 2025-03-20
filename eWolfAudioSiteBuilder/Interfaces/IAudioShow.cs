using eWolfAudioSiteBuilder.Data;
using eWolfAudioSiteBuilder.Data.Enums;

namespace eWolfAudioSiteBuilder.Interfaces
{
    public interface IAudioShow
    {
        CastHolder Casts { get; set; }
        string DateAdded { get; set; }
        string Description { get; set; }
        CastHolder Production { get; set; }
        ShowHolder Shows { get; set; }
        public ShowTypes ShowTypes { get; set; }
        string Title { get; set; }
        int Year { get; set; }
    }
}