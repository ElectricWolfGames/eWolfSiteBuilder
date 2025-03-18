using eWolfAudioSiteBuilder.Data.Enums;
using eWolfAudioSiteBuilder.Interfaces;

namespace eWolfAudioSiteBuilder.Data
{
    public class AudioBaseDetails : IAudioShow
    {
        public CastHolder Casts { get; set; } = new CastHolder();
        public string Description { get; set; }
        public CastHolder Production { get; set; } = new CastHolder();
        public ShowHolder Shows { get; set; } = new ShowHolder();
        public string Title { get; set; }
        public int Year { get; set; }
        public ShowTypes ShowTypes { get; set; }

    }
}