﻿using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.ScifiDrama
{
    public class AliensOfTheMind : AudioBaseDetails
    {
        public AliensOfTheMind()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "Aliens of the Mind";
            Year = 1976;
            DateAdded = "2025/04/02";

            Description = "The six-part drama centres around the discovery, on a remote Scottish island, of a community of ‘human mutants’ capable of telepathy. A plan is in place to use them to control the British Government, and friends Curtis Lark (Vincent Price) and Hugh Baxter (Peter Cushing) join forces to combat them.";

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
            Shows.Shows[0].AddLink("f0RJOEO3PVU");
            Shows.Shows[0].AddEpisode(1, "Island Genesis");
            Shows.Shows[0].AddEpisode(2, "Hurried Exodus");
            Shows.Shows[0].AddEpisode(3, "Unexpected Visitations");
            Shows.Shows[0].AddEpisode(4, "Official Intercessions");
            Shows.Shows[0].AddEpisode(5, "Genetic Revelation");
            Shows.Shows[0].AddEpisode(6, "Final Tribulations");
        }
    }
}