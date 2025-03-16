using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder.Interfaces
{
    public interface IAudioShow
    {
        CastHolder Casts { get; set; }
        CastHolder Production { get; set; }
        ShowHolder Shows { get; set; }
        string Title { get; set; }
        int Year { get; set; }
    }
}