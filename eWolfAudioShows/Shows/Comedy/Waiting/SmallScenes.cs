using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy.Waiting
{
    public class SmallScenes : AudioBaseDetails
    {
        public SmallScenes()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Small Scenes";
            Year = 2012;
            DateAdded = "2025/12/01";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\28 Small Scenes\\";

            Description = "Small Scenes is a Radio 4 sketch show which features overblown, melodramatic scenes from modern life.";

            Casts.Add("Various", "Daniel Rigby");
            Casts.Add("Various", "Henry Paker");
            Casts.Add("Various", "Mike Wozniak");
            Casts.Add("Various (Series 2 - 4)", "Cariad Lloyd ");
            Casts.Add("Various (Series 4)", "Freya Parker");
            Casts.Add("Various (Series 3)", "Jessica Ransom");
            Casts.Add("Various (Series 1 - 2)", "Sara Pascoe ");

            Production.Add("WRITER", "Henry Paker");
            Production.Add("WRITER", "Mike Wozniak");
            Production.Add("WRITER", "Benjamin Partridge");
            Production.Add("WRITER", "Daniel Rigby (Series 1 - 2)");
            Production.Add("WRITER", "Sara Pascoe (Series 1 - 2)");

            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series 1");
            Shows.ShowItems[0].AddLink("7Ot4ZiIfjHQ");
            Shows.ShowItems[0].AddEpisode(1, " Episode One", "Featuring commentary from the World Ham Shouting Championships and a couple who are being harassed by a former England football hero.");
            Shows.ShowItems[0].AddEpisode(2, " Episode Two", "Featuring a pair of long-lost brothers meeting for the first time, a moth that runs amok on a submarine and the world's most literal voiceover artist.");
            Shows.ShowItems[0].AddEpisode(3, " Episode Three", "In this episode we hear about the cosmetic benefits of old men's legs and the Witness Protection Conference 2013.");
            Shows.ShowItems[0].AddEpisode(4, " Episode Four", "Comedy sketch series with Daniel Rigby, Henry Paker, Mike Wozniak and Sara Pascoe.");

            Shows.Add("Series 2");
            Shows.ShowItems[1].AddLink("Of7lK2ZD_50");
            Shows.ShowItems[1].AddEpisode(1, " Episode One", "A man uncovers a great Australian conspiracy, and a financial advisor starts a sideline as an assassin's assistant.");
            Shows.ShowItems[1].AddEpisode(2, " Episode Two", "Oxford Zoo is annexed by its own monkey kingdom, and a young woman falls under the romantic spell of the Great Dimbleby.");
            Shows.ShowItems[1].AddEpisode(3, " Episode Three", "A man gets lost in a breakfast buffet, and a stag party goes very wrong.");
            Shows.ShowItems[1].AddEpisode(4, " Episode Four", "A visit to The Golden Woofers, Grimsby's number one dog show, and a farmer genetically engineers some living sausages.");

            Shows.Add("Series 3");
            Shows.ShowItems[2].AddLink("if8kIdDLqP0");
            Shows.ShowItems[2].AddEpisode(1, " Episode One", "A woman uncovers the conspiracy behind cryptic crosswords, and a saxophonist is tortured by his inability to play the solo from Baker Street.");
            Shows.ShowItems[2].AddEpisode(2, " Episode Two", "A smooth radio station continues broadcasting during civil unrest, we meet a man who can't stop offering people lifts, and drop in on the Depressing Foreign Zoo.");
            Shows.ShowItems[2].AddEpisode(3, " Episode Three", "A visit to a magic warehouse, plus a couple who buy the house Chris de Burgh used to own, and a man whose complaints are easily settled on receipt of something free.");
            Shows.ShowItems[2].AddEpisode(4, " Episode Four", "A man can't stop accidentally discovering dead bodies, a hotel guest keeps asking for more towels, someone gets too close to the bats he's supposed to studying, and the show goes on board a luxury Seasun cruise.");

            Shows.Add("Series 4");
            Shows.ShowItems[3].AddLink("UCKALwUH3Gs");
            Shows.ShowItems[3].AddEpisode(1, " Episode One", "Featuring more overblown, melodramatic scenes from modern life, including a visit to the first ever Crufts for Cats and a terrifying reminder as to why you should never try and cancel your membership of The National Trust.");
            Shows.ShowItems[3].AddEpisode(2, " Episode Two", "A woman discovers why there are so many Cornish pasty shops in British train stations and a man tries to return a sleeping bag to John Lewis with dramatic consequences.");
            Shows.ShowItems[3].AddEpisode(3, " Episode Three", "Featuring the World Small Talk Championships, and a look at a nationwide drug network that operates along the rambling paths of Great Britain.");
            Shows.ShowItems[3].AddEpisode(4, " Episode Four", "A man's his life starts to spiral into chaos.");
        }
    }
}