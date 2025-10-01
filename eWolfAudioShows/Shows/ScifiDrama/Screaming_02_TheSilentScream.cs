using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.ScifiDrama
{
    public class Screaming_02_TheSilentScream : AudioBaseDetails
    {
        public Screaming_02_TheSilentScream()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "The Silent Scream";
            Year = 1979;
            DateAdded = "";
            OutputPath = null;
            Description = "Earth prepares for an alien invasion. Tom Harris disappears into space but returns with new and astonishing powers. Put to good use, they will benefit humanity - but in the wrong hands they could have horrifying and nightmarish implications.";

            Casts.Add("Tom Harris", "James Laurenson");
            Casts.Add("A P Smith", "Donald Hewlett");
            Casts.Add("Sally Harris", "Hannah Gordon");
            Casts.Add("Prime Minister", "Colin Douglas");
            Casts.Add("Silkin", "Peter Wickham");
            Casts.Add("Brian Forbes", "Eric Allan");
            Casts.Add("Andy / Sam", "Elizabeth Lindsey");
            Casts.Add("1st Boy", "Andrew Branch");
            Casts.Add("1st Girl", "Alison Draper");
            Casts.Add("2nd Boy", "Tim Bentinck");
            Casts.Add("3rd Boy", "Susan Sheridan");
            Casts.Add("Constable / Sergeant", "Gregory De Polnay");
            Casts.Add("Alien Controller/ Cabinet Minister", "Manning Wilson");
            Casts.Add("Second Pilot / PC", "Gregory De Polnay");
            Casts.Add("Cabinet Minister/ Second Lieut", "Philip Voss");
            Casts.Add("Gloria / Cabinet Minister", "Brenda Kaye");
            Casts.Add("Opposition MP / Colonel", "Peter Williams");

            Production.Add("WRITER", "Wally K Daly");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "The Silent Scream", "");
        }
    }
}