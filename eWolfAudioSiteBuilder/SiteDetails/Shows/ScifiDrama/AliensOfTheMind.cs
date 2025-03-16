using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder.SiteDetails.Shows.ScifiDrama
{
    public class AliensOfTheMind : AudioBaseDetails
    {
        public AliensOfTheMind()
        {
            Title = "Aliens of the Mind";
            Year = 1976;
            Casts.Add("Curtis Lark", "Vincent Price");
            Casts.Add("Hugh Baxter", "Peter Cushing");
            Casts.Add(string.Empty, "Henry Stamfer");
            Casts.Add(string.Empty, "Sandra Clark");
            Casts.Add(string.Empty, "Shirley Dickson");
            Casts.Add(string.Empty, "Irene Tucklef");

            Casts.Add(string.Empty, "Fraser Carr");
            Casts.Add(string.Empty, "Andrew Spear");
            Casts.Add(string.Empty, "Steve Titus");
            Casts.Add(string.Empty, "Joan Matheson");
            Casts.Add(string.Empty, "William Eagle");
            Casts.Add(string.Empty, "Clifford Norgate");
            Casts.Add(string.Empty, "Michael Harver");
            Casts.Add(string.Empty, "James Thomlinson");
            Casts.Add(string.Empty, "Richard Herndle");
            Casts.Add(string.Empty, "Joan Benom");

            Production.Add("WRITER", "Rene Bascilico");
            Production.Add("PRODUCER", "John Dyer");
            Production.Add("EFFECTS", "Chris Jenkins");

            Shows.Add(string.Empty);
            Shows.Shows[0].AddLink("https://youtu.be/f0RJOEO3PVU");
            Shows.Shows[0].AddEpisode(1, "Island Genesis");
            Shows.Shows[0].AddEpisode(2, "Hurried Exodus");
            Shows.Shows[0].AddEpisode(3, "Unexpected Visitations");
            Shows.Shows[0].AddEpisode(4, "Official Intercessions");
            Shows.Shows[0].AddEpisode(5, "Genetic Revelation");
            Shows.Shows[0].AddEpisode(6, "Final Tribulations");
        }
    }
}