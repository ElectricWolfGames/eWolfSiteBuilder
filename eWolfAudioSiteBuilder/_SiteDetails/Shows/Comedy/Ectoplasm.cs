using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class Ectoplasm : AudioBaseDetails
    {
        public Ectoplasm()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Ectoplasm ";
            Year = 2000;
            DateAdded = "";

            Description = "The stories follow the adventures of Lord Zimbabwe (Romero), a 'walker in the ether', or occult investigator; his friend and collaborator Doctor Lilac (Freedman), a German scientist who has invented various machines.";

            Casts.Add("Lord Zimbabwe", "Nick Romero");
            Casts.Add("Doctor Lilac", "Dan Freedman");
            Casts.Add("Theremin", "Peter Donaldson");
            Casts.Add("", "Sophie Aldred");
            Casts.Add("", "Owen Oakeshott");
            Casts.Add("", "Colin Guthrie");

            Production.Add("WRITER", "Dan Freedman");
            Production.Add("WRITER", "Nick Romero");
            Production.Add("PRODUCER", "Helen Williams");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "The Curse of Tutancommon", "");
            Shows.Shows[0].AddEpisode(2, "The Case of the Missing Lost Soul", "");
            Shows.Shows[0].AddEpisode(3, "The Affair of the Baddie's Niece", "");
            Shows.Shows[0].AddEpisode(4, "The Adventure of the Stupid, Ignorant Americans", "");
        }
    }
}