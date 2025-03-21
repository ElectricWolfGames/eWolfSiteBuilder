using eWolfAudioSiteBuilder.Data;
using System.Windows.Xps;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class RudysRareRecords : AudioBaseDetails
    {
        public RudysRareRecords()
        {
            // TODO: RudysRarerRcords
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Rudy's Rare Records";
            Year = 2008;
            DateAdded = "2025/03/14";

            Description = "The plot follows Adam Sharpe, who returns to Birmingham from London after a breakdown, and is forced to move in with his father Rudy Sharpe. They squeeze into the flat above the eponymous Rudy's Rare Records, his dad's shambolic record shop selling reggae, ska and soul. While Adam is anxious and straight-laced, Rudy is exuberant, opinionated and brash. Other characters include Adam's adult son Richie, shop employee Tasha, the self-proclaimed first black goth girl in Handsworth, Doreen, Rudy's girlfriend, and Clifton, his friend.";

            Casts.Add("Rudy Sharpe", "Larrington Walker");
            Casts.Add("Adam Sharpe", "Lenny Henry");
            Casts.Add("Tasha", "Natasha Godfrey");
            Casts.Add("Richie Sharpe", "Joe Jacobs ");
            Casts.Add("Doreen", "Claire Benedict ");
            Casts.Add("Clifton", "Jeffery Kissoon ");
            Casts.Add("Alison", "Tracy-Ann Oberman");

            Production.Add("WRITER", "Danny Robins");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("ThmN4BdsSyM");
            Shows.Shows[0].AddEpisode(1, "Take Me Home, Country Roads", "");
            Shows.Shows[0].AddEpisode(2, "Roots Manoeuvres", "");
            Shows.Shows[0].AddEpisode(3, "Get Up, Stand Up", "");
            Shows.Shows[0].AddEpisode(4, "The Heart of Saturday Night", "");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("OU_yDr2vAoY");
            Shows.Shows[1].AddEpisode(1, "Ill Communication", "");
            Shows.Shows[1].AddEpisode(2, "Oh Carolina", "");
            Shows.Shows[1].AddEpisode(3, "Daddy Cool", "");
            Shows.Shows[1].AddEpisode(4, "Ride With Me", "");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("2mEcSaPZWD8");
            Shows.Shows[2].AddEpisode(1, "No Richie, No Cry", "");
            Shows.Shows[2].AddEpisode(2, "It's A Family Affair", "");
            Shows.Shows[2].AddEpisode(3, "Redemption Song", "");
            Shows.Shows[2].AddEpisode(4, "Rudy's Rare Record", "");
            Shows.Shows[2].AddEpisode(5, "Lights Out", "");
            Shows.Shows[2].AddEpisode(6, "Girls and Boys", "");

            Shows.Add("Series  4");
            Shows.Shows[3].AddLink("_A6aYijqc20");
            Shows.Shows[3].AddEpisode(1, "Three's a Crowd", "");
            Shows.Shows[3].AddEpisode(2, "Best Local Business", "");
            Shows.Shows[3].AddEpisode(3, "Let It Grow", "");
            Shows.Shows[3].AddEpisode(4, "It's Grim Up North", "");
            Shows.Shows[3].AddEpisode(5, "Miss Reenie Comes to Stay", "");
            Shows.Shows[3].AddEpisode(6, "Sound of da Police", "");
        }
    }
}