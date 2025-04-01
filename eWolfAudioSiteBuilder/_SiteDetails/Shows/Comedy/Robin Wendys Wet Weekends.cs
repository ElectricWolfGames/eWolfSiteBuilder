using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class RobinWendysWetWeekends : AudioBaseDetails
    {
        public RobinWendysWetWeekends()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Robin and Wendys Wet Weekends";
            Channel = "BBC Radio 4";
            Year = 2001;
            DateAdded = "";

            Description = "It revolves around the mundane lives of Robin and Wendy Mayfield who live on an anonymous estate in Stevenage. Robin tends to be self-centred, demanding and controlling in his relationships. Wendy, however, always seems to see the positive side of any situation, and, while often frustrated, copes with Robin admirably. Both Robin and Wendy have relatively meaningless bureaucratic jobs. Robin manages shipping and receiving for a warehouse, and Wendy works in local government.";

            Casts.Add("Wendy", "Kay Stonham");
            Casts.Add("Robin (Series 1-2)", "Simon Greenall");
            Casts.Add("Robin (Series 3-4)", "Brian Capron");
            Casts.Add("Maureen (Series 1)", "Debra Stephenson");
            Casts.Add("Maureen (Series 2-4)", "Amelia Bullmore");
            Casts.Add("Derek (Series 1)", "Phil Cornwell");
            Casts.Add("Derek (Series 2-4)", "Martin Trenaman");

            Production.Add("WRITER", "Kay Stonham");
            Production.Add("WRITER", "Simon Greenall");
            Production.Add("PRODUCER (Series 1-2)", "Mario Stylianides");
            Production.Add("PRODUCER (Series 3)", "Helen Williams");
            Production.Add("PRODUCER (Series 4)", "Claire Bartlett");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "The Heinrich Manoeuvre");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "A Fete Worse Than Death");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "A Cavalier Attitude");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "Police, Camera, Amphibian");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("");
            Shows.Shows[1].AddEpisode(1, "Episodes 1", "Them and Us");
            Shows.Shows[1].AddEpisode(2, "Episodes 2", "Take the High Road");
            Shows.Shows[1].AddEpisode(3, "Episodes 3", "Entertaining Mr Stone");
            Shows.Shows[1].AddEpisode(4, "Episodes 4", "Lassie Go Home");
            Shows.Shows[1].AddEpisode(5, "Episodes 5", "A Green Unpleasant Land");
            Shows.Shows[1].AddEpisode(6, "Episodes 6", "About Some Boys");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("");
            Shows.Shows[2].AddEpisode(1, "Episodes 1", "Alka Salsa");
            Shows.Shows[2].AddEpisode(2, "Episodes 2", "Dream Genie");
            Shows.Shows[2].AddEpisode(3, "Episodes 3", "Arrivederci Coma");
            Shows.Shows[2].AddEpisode(4, "Episodes 4", "Anniversary Waltz");

            Shows.Add("Series  4");
            Shows.Shows[3].AddLink("");
            Shows.Shows[3].AddEpisode(1, "Episodes 1", "Autumn Crocus");
            Shows.Shows[3].AddEpisode(2, "Episodes 2", "Congratulations, It's a Hob Nob");
            Shows.Shows[3].AddEpisode(3, "Episodes 3", "Baby Love");
            Shows.Shows[3].AddEpisode(4, "Episodes 4", "Ground Control to Major Derek");
        }
    }
}