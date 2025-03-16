using eWolfAudioSiteBuilder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eWolfAudioSiteBuilder.SiteDetails.Shows.Comedy
{
    public class Party : AudioBaseDetails
    {
        public Party()
        {
            Title = "Party";
            Year = 2009;

            Casts.Add(string.Empty, "Tom Basden");
            Casts.Add(string.Empty, "Tim Key");
            Casts.Add(string.Empty, "Jonny Sweet");
            Casts.Add(string.Empty, "Anna Crilly");
            Casts.Add(string.Empty, "Katy Wix");
            Casts.Add(string.Empty, "");
            Casts.Add(string.Empty, "");

            Production.Add("WRITER", "Tom Basden");
            Production.Add("PRODUCER", "Julia McKenzie");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("https://youtu.be/QZ9D6ZMdn_8");
            Shows.Shows[0].AddEpisode(1, string.Empty);
            Shows.Shows[0].AddEpisode(2, string.Empty);
            Shows.Shows[0].AddEpisode(3, string.Empty);
            Shows.Shows[0].AddEpisode(4, string.Empty);

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("https://youtu.be/qdowZkV77I8");
            Shows.Shows[1].AddEpisode(1, "All Publicity Is Good Publicity");
            Shows.Shows[1].AddEpisode(2, "It's Technology, Stupid");
            Shows.Shows[1].AddEpisode(3, "Prison Ain't All That Bad");
            Shows.Shows[1].AddEpisode(4, "Is The Party Over?");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("https://youtu.be/UEECxzfSMME");
            Shows.Shows[2].AddEpisode(1, "The Curry");
            Shows.Shows[2].AddEpisode(2, "The Grundy");
            Shows.Shows[2].AddEpisode(3, "The Splits");
            Shows.Shows[2].AddEpisode(4, "Radio");

            Shows.Add("Series  4");
            Shows.Shows[3].AddLink("https://youtu.be/tYjKzY8M0MY");
            Shows.Shows[3].AddEpisode(1, "Christmas Special");
        }
    }
}