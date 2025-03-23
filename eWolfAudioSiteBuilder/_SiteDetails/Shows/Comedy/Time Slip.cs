using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class TimeSlip : AudioBaseDetails
    {
        public TimeSlip()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Time Slip";
            Year = 1983;
            DateAdded = "2025/01/03";

            Description = "Paul Williamson arrives home, only to find himself already there. What exactly is going on?";

            Casts.Add("Paul", "Paul Daneman");
            Casts.Add("Frank", "Donald Hewlett");
            Casts.Add("Margaret", "Gwen Watford");
            Casts.Add("Faye", "Norma Ronald");
            Casts.Add("Harold the Barman", "Eric Allan");

            Production.Add("WRITER", "Wally K Daly");
            Production.Add("PRODUCER", "Martin Jenkins");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("pjz2CaUZRqs");
        }
    }
}