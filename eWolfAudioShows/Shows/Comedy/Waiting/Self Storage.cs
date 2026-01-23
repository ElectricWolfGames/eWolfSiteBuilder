using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy.Waiting
{
    public class SelfStorage : AudioBaseDetails
    {
        public SelfStorage()
        {
            ShowTypes = Data.Enums.ShowTypes.Waiting;

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
            Shows.ShowItems[0].AddLink("");
            Shows.ShowItems[0].AddEpisode(1, "Episodes 1", "");
            Shows.ShowItems[0].AddEpisode(2, "Episodes 2", "");
            Shows.ShowItems[0].AddEpisode(3, "Episodes 3", "");
            Shows.ShowItems[0].AddEpisode(4, "Episodes 4", "");

            Shows.Add("Series  2");
            Shows.ShowItems[1].AddLink("");
            Shows.ShowItems[1].AddEpisode(1, "Episodes 1", "");
            Shows.ShowItems[1].AddEpisode(2, "Episodes 2", "");
            Shows.ShowItems[1].AddEpisode(3, "Episodes 3", "");
            Shows.ShowItems[1].AddEpisode(4, "Episodes 4", "");
        }
    }
}