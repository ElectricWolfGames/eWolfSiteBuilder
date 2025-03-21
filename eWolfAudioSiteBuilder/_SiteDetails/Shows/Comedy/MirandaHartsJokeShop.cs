using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class MirandaHartsJokeShop : AudioBaseDetails
    {
        public MirandaHartsJokeShop()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Miranda Harts Joke Shop";
            Year = 2007;
            DateAdded = "2025/03/10";

            Description = "Miranda is an unconventional woman. She's six feet tall, self-conscious and posh. And is frequently mistaken for a man. She's also invested her inheritance in a joke shop that she runs with her friend Stevie while trying to deal with her outrageously embarrassing mother.";

            Casts.Add("", "Miranda Hart");
            Casts.Add("", "Sarah Hadland,");
            Casts.Add("", "Patricia Hodge");
            Casts.Add("", "Tom Ellis.");

            Production.Add("WRITER", "");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("jQxW-OhBTC4");
            Shows.Shows[0].AddEpisode(1, "What A Flirt", "Miranda flirts with Gary, but is mistaken for a man by passers-by when she un-knowingly buys clothes from a shop for transvestites. Other mix-ups scare Gary away, as they make Miranda look like she is desperate for a baby.");
            Shows.Shows[0].AddEpisode(2, "What A Job", "Miranda tries to prove she can get a proper job away from the joke shop.");
            Shows.Shows[0].AddEpisode(3, "What A Wife", "Gary needs a pretend wife for the evening and for some reason he chooses Stevie over Miranda.");
            Shows.Shows[0].AddEpisode(4, "What An Excuse", "Miranda's mother tries desperately to play Cupid for Miranda.");
        }
    }
}