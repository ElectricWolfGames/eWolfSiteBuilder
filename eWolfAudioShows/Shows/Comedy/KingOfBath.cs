using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class KingOfBath : AudioBaseDetails
    {
        public KingOfBath()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "King of Bath";
            Year = 1999;
            DateAdded = "";

            Description = "In the fashionable spa town of Bath, one man is the arbiter of taste and the epitome of elegance: the self-proclaimed ‘King of Bath’, Beau Nash. In his capacity as Master of Ceremonies, he presides over the city’s social life, arranging balls and concerts for the ‘ton’, keeping a discreet eye on distinguished visitors and smoothing over any quarrels or disagreements.";

            Casts.Add("Beau Nash", "David Bamber");
            Casts.Add("Annie", "Eiry Thomas");
            Casts.Add("Lucy", "Lynn Seymour");
            Casts.Add("Hazlitt", "Peter Gunn");
            Casts.Add("Fanny", "Alice Arnold");
            Casts.Add("Dr Cheyne / Count von Richthofen/ Sir Percy", "Andrew Wincott");
            Casts.Add("Mr Trout / Daniel Brewster", "Simon Ludders");
            Casts.Add("Fintan Fitzgerald", "Richard Nichols");
            Casts.Add("Poppy", "Lesley Rooney");
            Casts.Add("Lady Huntingdon", "Rosamund Shelley");
            Casts.Add("Pryderi", "Iestyn Jones");
            Casts.Add("Widow Perkins", "Stevie Parry");
            Casts.Add("Ambrose", "James Westaway");
            Casts.Add("Mr Whistle", "Brendan Charleson");
            Casts.Add("Joshua", "James Greene");
            Casts.Add("Dr Collins", "Patrick Collins");
            Casts.Add("Mrs Collins", "Manon Edwards");
            Casts.Add("Ned", "Stephen Thorne");
            Casts.Add("Sophia", "Claire Cage");

            Production.Add("WRITER", "Arnold Evans");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "Alison Hindell");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "By Any Other Name", "");
            Shows.Shows[0].AddEpisode(2, "Merely Players", "");
            Shows.Shows[0].AddEpisode(3, "Ars Brevis", "");
            Shows.Shows[0].AddEpisode(4, "Suffer Little Children", "");
            Shows.Shows[0].AddEpisode(3, "Blessed Are We", "");
            Shows.Shows[0].AddEpisode(4, "The Clockwork Man", "");
        }
    }
}