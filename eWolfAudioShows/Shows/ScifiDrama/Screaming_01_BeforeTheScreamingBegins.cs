using eWolfAudioShows.Data;
using System.Diagnostics.Metrics;

namespace eWolfAudioShows.Shows.ScifiDrama
{
    public class Screaming_01_BeforeTheScreamingBegins : AudioBaseDetails
    {
        public Screaming_01_BeforeTheScreamingBegins()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "Before the Screaming Begins";
            Year = 1978;
            DateAdded = "";
            OutputPath = null;

            Description = "Tom Harris' wedding anniversary takes a dramatic turn when he's abducted by aliens... What is their intent?";

            Casts.Add("A.P.Smith", "Donald Hewlett");
            Casts.Add("Tom Harris", "James Laurenson");
            Casts.Add("Sally Harris", "Jennifer Piercey");
            Casts.Add("Alien Voice", "Malcolm Gerrard");
            Casts.Add("Alien Controller", "Manning Wilson");
            Casts.Add("Prime Minister", "Patrick Troughton");
            Casts.Add("Silkine", "Peter Wickham");
            Casts.Add("Sgt.Forbes", "Robert Trotter");
            Casts.Add("Sally's Mother", "Catherine Parr");
            Casts.Add("Nurse Cabinet Minister", "Maggie Oleranshaw");
            Casts.Add("Desk Sgt.Opposition MP", "Peter Williams");

            Production.Add("WRITER", "Wally K Daly");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "");
        }
    }
}