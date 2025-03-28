using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.ScifiDrama
{
    public class _625Y : AudioBaseDetails
    {
        public _625Y()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "625Y";
            Year = 1999;
            DateAdded = "";

            Description = "Research scientist Kate Brown makes a dramatic discovery in her laboratory about human genes. Scientists try to hang on to the news that they've found a way to extend human life. First the politicians, and then the people, find out. Very quickly things turn very nasty.";

            Casts.Add("Kate Brown", "Amanda Root");
            Casts.Add("Professor Slingsby", "Geoffrey Whitehead");
            Casts.Add("Joe Barnard", "Jon Strickland");
            Casts.Add("Reporter", "Elizabeth Conboy");
            Casts.Add("Prime Minister", "Chris Tranchell");
            Casts.Add("Minister of Defence", "Ian Masters");
            Casts.Add("Major Peters", "Brett Usher");
            Casts.Add("Danny Flowers", "Stuart Milligan");
            Casts.Add("Lab Technician", "Harry Myers");
            Casts.Add("Minister of Health", "Sandra Clark");

            Production.Add("DIRECTOR: ", "Gordon House");
            Production.Add("WRITER", "Wally K Daly");

            Shows.Add(string.Empty);
            Shows.Shows[0].AddLink("o2UVjYukEFI");
        }
    }
}