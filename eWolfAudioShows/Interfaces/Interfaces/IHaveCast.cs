using eWolfAudioShows.Data;

namespace eWolfAudioShows.Interfaces.Interfaces;

public interface IHaveCast
{
    CastHolder Casts { get; set; }
}
