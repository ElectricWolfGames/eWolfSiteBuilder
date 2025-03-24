using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class LifeAfterLife : AudioBaseDetails
    {
        public LifeAfterLife()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Life after Life";
            Year = 1998;
            DateAdded = "202/02/18";

            Description = "Uncle Sid's out of prison, on probation. He was serving a life sentence for armed robbery.  The only place he has to stay is back in good old Muswell Hill.  But the area has changed from his early days. Now he's with his middle-class niece and her nice middle-class family.";

            Casts.Add("Sid", "Warren Mitchell");
            Casts.Add("Val", "Kay Stonham");
            Casts.Add("Ian", "Simon Greenall");
            Casts.Add("Ada", "Avril Elgar");
            Casts.Add("Matthew", "Josh Freedman");
            Casts.Add("Molly", "Mollie Freedman");
            Casts.Add("Governor", "Will Ing");
            Casts.Add("Headmistress", "Annie Hulley");

            Production.Add("WRITER", "Kay Stonham");
            Production.Add("WRITER", "Simon Greenall");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "Jane Berthoud");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("AUJch9gkCOQ");
        }
    }
}