using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class Party : AudioBaseDetails
    {
        public Party()
        {
            Title = "Party";
            Year = 2009;
            Description = "The series surrounds young idealists who want to get into British politics but are naïve and have no idea how to.";

            Casts.Add(string.Empty, "Tom Basden");
            Casts.Add(string.Empty, "Tim Key");
            Casts.Add(string.Empty, "Jonny Sweet");
            Casts.Add(string.Empty, "Anna Crilly");
            Casts.Add(string.Empty, "Katy Wix");

            Production.Add("WRITER", "Tom Basden");
            Production.Add("PRODUCER", "Julia McKenzie");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("QZ9D6ZMdn_8");
            Shows.Shows[0].AddEpisode(1, "Episodes 1");
            Shows.Shows[0].AddEpisode(2, "Episodes 2");
            Shows.Shows[0].AddEpisode(3, "Episodes 3");
            Shows.Shows[0].AddEpisode(4, "Episodes 4");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("qdowZkV77I8");
            Shows.Shows[1].AddEpisode(1, "All Publicity Is Good Publicity");
            Shows.Shows[1].AddEpisode(2, "It's Technology, Stupid");
            Shows.Shows[1].AddEpisode(3, "Prison Ain't All That Bad");
            Shows.Shows[1].AddEpisode(4, "Is The Party Over?");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("UEECxzfSMME");
            Shows.Shows[2].AddEpisode(1, "The Curry");
            Shows.Shows[2].AddEpisode(2, "The Grundy");
            Shows.Shows[2].AddEpisode(3, "The Splits");
            Shows.Shows[2].AddEpisode(4, "Radio");

            Shows.Add("Series  4");
            Shows.Shows[3].AddLink("tYjKzY8M0MY");
            Shows.Shows[3].AddEpisode(1, "Christmas Special");
        }
    }
}