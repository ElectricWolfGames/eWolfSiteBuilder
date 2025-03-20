using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class BigJimTheFigaroClub : AudioBaseDetails
    {
        public BigJimTheFigaroClub()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Big Jim & The Figaro Club";
            Year = 1987;
            DateAdded = "";

            Description = "Comedy series set on a seaside town building site during the booming but restrictive post-war 1950s.";


            Casts.Add("Big Jim", "Norman Rossington");
            Casts.Add("Harold Perkins", "Roland Curram");
            Casts.Add("Old Ned", "Harold Goodwin");
            Casts.Add("Nimrod", "David John");
            Casts.Add("Chick", "David Beckett");
            Casts.Add("Turps", "Sylvester McCoy");
            Casts.Add("The Farmer", "Douglas Blackwell");
            Casts.Add("The Farmer’s Daughter", "Karen Ascoe");
            Casts.Add("Storyteller", "Bernard Cribbins");


            Production.Add("WRITER", "Ted Walker");
            Production.Add("WRITER", "Colin Rose");
            Production.Add("PRODUCER", "Martin Fisher");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Transport of Delight", "Demobbed Old Ned heads south after the war and joins a special construction team.");
            Shows.Shows[0].AddEpisode(2, "The French Connection", "The post-war construction team's Potts and Perkins hurl insults - and then onions.");
            Shows.Shows[0].AddEpisode(3, "On the Line", "Perkins can't get a site phone, so his workmates get him a handset and more besides.");
            Shows.Shows[0].AddEpisode(4, "Up the Pole", "When Perkins befriends the Carnival Queen, the workmates plot a little sabotage.");
            Shows.Shows[0].AddEpisode(5, "Boning Up on History", "Perkins wants to dig for post-war Britain, but the workmates decide to soil his plans.");
            Shows.Shows[0].AddEpisode(6, "The Old Dunkirk Spirit", "Perkins has no materials to rebuild post-war Britain, which well suits the workmates.");
        }
    }
}