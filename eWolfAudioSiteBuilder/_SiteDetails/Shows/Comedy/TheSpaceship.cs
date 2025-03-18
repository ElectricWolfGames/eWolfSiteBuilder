using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class TheSpaceship : AudioBaseDetails
    {
        public TheSpaceship()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "The Spaceship";
            Year = 2005;
            Description = "What you are about to hear took place live, four years ago, 70,000 light years from home…\r\n";

            Casts.Add("Captain Gordon Taylor", "James Fleet");
            Casts.Add("Melissa Patterson", "Emily Joyce");
            Casts.Add("Karen", "Rose Cavaliero");
            Casts.Add("Stuart", "Paul Barnhill");
            Casts.Add("Clive", "Neil Warhurst");
            Casts.Add("Princess Urrgh", "Stephen Hogan");
            Casts.Add("Urrgh Emperor", "Jason Chan");
            Casts.Add("Narrator", "Nicholas Boulton");

            Production.Add("WRITER", "Paul Barnhill");
            Production.Add("WRITER", "Neil Warhurst");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "Sally Avens");
            Production.Add("COMPOSER", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("s28PTJNQJHk");
            Shows.Shows[0].AddEpisode(1, "s01e01: Lost", "The crew is responsible for taking care of the princess of the Urg.");
            Shows.Shows[0].AddEpisode(2, "s01e02: Indestructible", "Why does The Indestructible III explode for no reason?");
            Shows.Shows[0].AddEpisode(3, "s01e03: Monster", "Who or what is in the hold of The Really Invincible III.");
            Shows.Shows[0].AddEpisode(4, "s01e04: Dirty", "Clive 55’s experiment with dark matter goes awry.");
            Shows.Shows[0].AddEpisode(5, "s01e05: Enemies", "The crew prepare to meet the Duhwop-eye.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("oE2dpxrjr5w");
            Shows.Shows[1].AddEpisode(1, "s02e01: Hole", "While dealing with the unpleasant consequences of the first ever incident of travel through a black hole, the crew faces a race of call-centre operative plants.");
            Shows.Shows[1].AddEpisode(2, "s02e02: Manhood", "Scientist Clive 55 reconstructs a dead space pirate and before long he's running the ship.");
            Shows.Shows[1].AddEpisode(3, "s02e03: Rude", "The crew have some space tourists on board, but it turns into a holiday from hell.");
            Shows.Shows[1].AddEpisode(4, "s02e04: Sick ", "The crew contract a mystery virus which makes them age at an alarming rate.");
            Shows.Shows[1].AddEpisode(5, "s02e05: The End", "The End: The crew find themselves at the end of the universe.");
        }
    }
}