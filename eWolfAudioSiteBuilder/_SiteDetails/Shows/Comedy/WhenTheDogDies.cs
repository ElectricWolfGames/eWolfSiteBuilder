using eWolfAudioSiteBuilder.Data;
using eWolfCommon.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Windows.Controls;
using System.Xml.Linq;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class WhenTheDogDies : AudioBaseDetails
    {
        // TODO: WhenTheDogDies
        public WhenTheDogDies()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "When The Dog Dies";
            Year = 2010;
            DateAdded = "2025/01/31";

            Description = "The stories revolve around Sandy's children's attempts to get him to 'downsize' or move into a retirement home (so they can sell his house and get the money) and the various relationships between his family members, Dolores, and the men in her life. Sandy refuses to go till his dog, Henry, dies.";

            Casts.Add("Sandy Hopper", "Ronnie Corbett ");
            Casts.Add("lodger Dolores", "Liza Tarbuck");
            Casts.Add("Sandy's Daughter Ellie", "Tilly Vosburgh ");
            Casts.Add("Ellie's husband Blake (series 1 - 3)", "Jonathan Aris");
            Casts.Add("Ellie's husband Blake (series 4)", "Dave Lamb");
            Casts.Add("Their son Tyson", "Daniel Bridle ");
            Casts.Add("Sandy's son Lance", "Philip Bird ");
            Casts.Add("Granddaughter Calais", "Grace Vance ");
            Casts.Add("Mrs Pompom", "Sally Grace ");

            Production.Add("WRITER", "Ian Davidson");
            Production.Add("WRITER", "Peter Vincent");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("Gn0zRZaEiQM");
            Shows.Shows[0].AddEpisode(1, "The Same Hymn Sheet", "Sandy wants to protect his grandson Tyson from his father's harsh training programme.");
            Shows.Shows[0].AddEpisode(2, "Spying is Believing", "Grandad Sandy has started snooping on his daughter-in-law Victoria.");
            Shows.Shows[0].AddEpisode(3, "The Rival Granddad", "Tyson's other grandad Rex is the bane of Sandy's life. Can he get even?");
            Shows.Shows[0].AddEpisode(4, "Portrait of the Artist as an Old Man", "Sandy's daughter is an artist. Her work never sells, until Sandy buys a canvas anonymously");
            Shows.Shows[0].AddEpisode(5, "Squeaky Shoes", "Sandy Hopper finds himself making more hospital visits and attending ever more funerals.");
            Shows.Shows[0].AddEpisode(6, "Desperately Seeking Dolores", "Can Sandy's dog spot Dolores among the charity runners dressed as chickens?");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("7ajyrX_nPTk");
            Shows.Shows[1].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[1].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[1].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[1].AddEpisode(4, "Episodes 4", "");
            Shows.Shows[1].AddEpisode(5, "Episodes 5", "");
            Shows.Shows[1].AddEpisode(6, "Episodes 6", "");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("BS6Cwg0QKPg");
            Shows.Shows[2].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[2].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[2].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[2].AddEpisode(4, "Episodes 4", "");
            Shows.Shows[2].AddEpisode(5, "Episodes 5", "");
            Shows.Shows[2].AddEpisode(6, "Episodes 6", "");

            Shows.Add("Series  4");
            Shows.Shows[3].AddLink("ahIGQwzNOs8");
            Shows.Shows[3].AddEpisode(1, "Episodes 1", "");
            Shows.Shows[3].AddEpisode(2, "Episodes 2", "");
            Shows.Shows[3].AddEpisode(3, "Episodes 3", "");
            Shows.Shows[3].AddEpisode(4, "Episodes 4", "");
            Shows.Shows[3].AddEpisode(5, "Episodes 5", "");
            Shows.Shows[3].AddEpisode(6, "Episodes 6", "");
        }
    }
}