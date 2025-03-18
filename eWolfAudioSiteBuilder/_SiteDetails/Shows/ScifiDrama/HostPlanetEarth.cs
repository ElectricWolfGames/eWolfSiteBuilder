using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.ScifiDrama
{
    public class HostPlanetEarth : AudioBaseDetails
    {
        public HostPlanetEarth()
        {
            Title = "Host Planet Earth";
            Year = 1967;
            Description = "It detailed the course of a strange disease which first affects scientists working on a British rocketry programme. When British astronauts fall prey to the sickness in space, can they be allowed to return?\r\n";

            Casts.Add("Claire Stewart", "Brenda Bruce");
            Casts.Add("Professor Ormskirk", "Clive Morton");
            Casts.Add("David Holland", "Alexander John");
            Casts.Add("Nat Blakey", "Nigel Anthony");
            Casts.Add("Bill Cape", "Ian Thompson");
            Casts.Add("Rathbone", "Timothy Bateson");
            Casts.Add("Joseph Banks", "Peter Tuddenham");
            Casts.Add("Mrs Hemming", "Betty Hardy");
            Casts.Add("Rosemary Manning", "Barbara Mitchell");
            Casts.Add("Technician", "Preston Lockwood");

            Production.Add("WRITER", "Anne Howell");
            Production.Add("WRITER", "Colin Cooper");
            Production.Add("PRODUCER", "Nesta Pain");
            Production.Add("EFFECTS", "BBC Radiophonic Workshop");
            Production.Add("MUSIC", "Clive Webster");

            Shows.Add(string.Empty);
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "The Beginning");
            Shows.Shows[0].AddEpisode(2, "The Empty Minds");
            Shows.Shows[0].AddEpisode(3, "The Pattern Emerges");
            Shows.Shows[0].AddEpisode(4, "The Gemini Factor");
            Shows.Shows[0].AddEpisode(5, "The Arrival");
            Shows.Shows[0].AddEpisode(6, "The Price of Freedom");
        }
    }
}