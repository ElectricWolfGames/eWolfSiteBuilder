using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class LittleMonster : AudioBaseDetails
    {
        public LittleMonster()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Little Monster";
            Channel = "BBC Radio 4";
            Year = 2013;
            DateAdded = "";

            Description = "A darkly comic look at modern parenthood about a mother coming to grips with the fact that her new child Benjy is a little monster. Literally. With horns, scales, fangs and a habit of bringing in the remains of next door's chickens. But she still loves him/her/it anyway.";

            Casts.Add("Karen", "Sarah Hadland");
            Casts.Add("Nick", "Rufus Jones");
            Casts.Add("Val", "Geraldine James");
            Casts.Add("Benjy", "Cariad Lloyd");
            Casts.Add("Sammy", "Bridget Christie");
            Casts.Add("Nina / Receptionist", "Hannah Wood");
            Casts.Add("Security Guard", "Gerard Foster");

            Production.Add("WRITER", "Gerard Foster");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "Ed Morrish");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("ZPhYJ12bp8E");
        }
    }
}