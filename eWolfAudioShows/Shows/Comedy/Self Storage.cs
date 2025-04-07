using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class SelfStorage : AudioBaseDetails
    {
        public SelfStorage()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Self Storage";
            Year = 2007;
            DateAdded = "";

            Description = "";

            Casts.Add("Dave", "Reece Shearsmith");
            Casts.Add("Geoff", "Mark Heap ");
            Casts.Add("Ron", "Tom Goodman-Hill ");

            Production.Add("WRITER", "");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("");
            Shows.Shows[1].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[1].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[1].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[1].AddEpisode(4, "Episodes 4", "");
        }
    }
}