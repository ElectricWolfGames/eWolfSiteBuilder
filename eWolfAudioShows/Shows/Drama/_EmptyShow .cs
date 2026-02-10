using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class _EmptyShow : AudioBaseEpisodesShowDetails
{
    public _EmptyShow()
    {
        ShowTypes = Data.Enums.ShowTypes.None;

        Title = "";
        Year = 2099;
        DateAdded = "";
        OutputPath = null;

        Description = "";

        Casts.Add("", "");
        Casts.Add("", "");
        Casts.Add("", "");
        Casts.Add("", "");
        Casts.Add("", "");
        Casts.Add("", "");

        Production.Add("WRITER", "");
        Production.Add("WRITER", "");
        Production.Add("PRODUCER", "");
        Production.Add("DIRECTOR", "");
    }
}