using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class ElephantsToCatchEels : AudioBaseDetails
    {
        public ElephantsToCatchEels()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Elephants to Catch Eels";
            Year = 2003;
            DateAdded = "2024/12/27";

            Description = "A comedy set in an 18th-century Cornish village from the writers of Dead Ringers";

            Casts.Add("Tamsyn Trelawney (series 1)", "Lucy Speed");
            Casts.Add("Tamsyn Trelawney (series 2)", "Sheridan Smith");
            Casts.Add("Jago ", "John Bowe");
            Casts.Add("Major Thomas Falcone", "Cameron Stewart");
            Casts.Add("Captain Marriot", "Andrew McGibbon");
            Casts.Add("Squire Bascombe", "Martin Hyder");
            Casts.Add("Mad Gilbert", "Martin Hyder");
            Casts.Add("Gullible Dewey", "Mark Felgate");

            Production.Add("WRITER", "Tom Jamieson");
            Production.Add("WRITER", "Nev Fountain");
            Production.Add("PRODUCER", "Jan Ravens");
            Production.Add("DIRECTOR", "");
            Production.Add("COMPOSER", "John Whitehall");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("TrE15rh20EY");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "18th-century Cornish village sitcom by the writers of Dead Ringers");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "Tamsyn Trelawny's band of 18th-century Cornish smugglers try to outwit customs officers.");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "A hairy folk band helps Tamsyn Trelawny and the Cornish smugglers to escape the law.");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "18th-century smuggler Tamsyn Trelawny tries to keep her love life out of the scandal rags.");
            Shows.Shows[0].AddEpisode(5, "Episodes 5", "When a new rival appears in town, 18th-century smuggler Tamsyn Trelawny tries to quit.");
            Shows.Shows[0].AddEpisode(6, "Episodes 6", "Smuggler Tamsyn Trelawny joins customs men to stop Courageous Kate from marrying her dad.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("fllK6LE6s5Q");
            Shows.Shows[1].AddEpisode(1, "Episodes 1", "18th-century smuggler Tamsyn Trelawny wants to win Peasants Personality of the Year.");
            Shows.Shows[1].AddEpisode(2, "Episodes 2", "18th-century smuggler Tamsyn's head is turned by hunky new band of outlaws 'Boyz 2 Rob'.");
            Shows.Shows[1].AddEpisode(3, "Episodes 3", "Can 18th-century smuggler Tamsyn escape the clutches of French revolutionaries?");
            Shows.Shows[1].AddEpisode(4, "Episodes 4", "It's Jesters' Relief Week, but must Cornish smuggler Tamsyn raise funds for Devonians?");
            Shows.Shows[1].AddEpisode(5, "Episodes 5", "Smuggler Jago is kidnapped, but can he survive in polite city society?");
            Shows.Shows[1].AddEpisode(6, "Episodes 6", "A surprise for 18th-century smuggler Tamsyn, and confusion aboard a boat to France.");
        }
    }
}