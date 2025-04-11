using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class RobinWendysWetWeekends : AudioBaseDetails
    {
        public RobinWendysWetWeekends()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

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

            var show = Shows.Add("Series  1");
            show.AddLink("");
            show.AddEpisode(1, "Episodes 1", "The Heinrich Manoeuvre");
            show.AddEpisode(2, "Episodes 2", "A Fete Worse Than Death");
            show.AddEpisode(3, "Episodes 3", "A Cavalier Attitude");
            show.AddEpisode(4, "Episodes 4", "Police, Camera, Amphibian");
            show.AddEpisode(5, "Special", "Robin & Wendy's Wet Edinburgh Weekend");

            show = Shows.Add("Series  2");
            show.AddLink("");
            show.AddEpisode(1, "Episodes 1", "Them and Us", 
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\201.mp3",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\s02\s02e01 Them and Us.png");
            show.AddEpisode(2, "Episodes 2", "Take the High Road", 
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\202.mp3",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\s02\s02e02 Take the High Road.png");
            show.AddEpisode(3, "Episodes 3", "Entertaining Mr Stone",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\203.mp3",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\s02\s02e03 Entertaining Mr Stone.png");
            show.AddEpisode(4, "Episodes 4", "Lassie Go Home", 
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\204.mp3",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\s02\s02e04 Lassie Go Home.png");
            show.AddEpisode(5, "Episodes 5", "A Green Unpleasant Land",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\205.mp3",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\s02\s02e05 A Green Unpleasant Land.png");
            show.AddEpisode(6, "Episodes 6", "About Some Boys",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\206.mp3",
                @"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\s02\s02e06 About Some Boys.png");

            show = Shows.Add("Series  3");
            show.AddLink("");
            show.AddEpisode(1, "Episodes 1", "Alka Salsa");
            show.AddEpisode(2, "Episodes 2", "Dream Genie");
            show.AddEpisode(3, "Episodes 3", "Arrivederci Coma");
            show.AddEpisode(4, "Episodes 4", "Anniversary Waltz");

            show = Shows.Add("Series  4");
            show.AddLink("");
            show.AddEpisode(1, "Episodes 1", "Autumn Crocus");
            show.AddEpisode(2, "Episodes 2", "Congratulations, It's a Hob Nob");
            show.AddEpisode(3, "Episodes 3", "Baby Love");
            show.AddEpisode(4, "Episodes 4", "Ground Control to Major Derek");
        }
    }
}