using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class MirandaHartsJokeShop : AudioBaseDetails
    {
        // TODO: "Miranda Harts Joke Shop";
        public MirandaHartsJokeShop()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Miranda Harts Joke Shop";
            Year = 2099;
            DateAdded = "";

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

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "");
        }
    }
}