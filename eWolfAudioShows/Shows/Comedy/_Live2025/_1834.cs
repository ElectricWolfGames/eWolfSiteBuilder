using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live
{
    public class _1834 : AudioBaseDetails
    {
        public _1834()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "1834";
            Year = 2003;
            DateAdded = "2025/06/03";

            Description = "Jason Slater is a 21st-century English teacher from Cheadle Hulme who wakes in 19th-century Macclesfield. He discovers he's now Tarquin, third son of Lord Belport with a faithful valet, Ned who can't explain what's happened. He's also acquired a suspicious brother, Henry; a spurned ex-girlfriend, Millicent, now going out with Henry; and an over excited Luddite-cum-cauliflower farmer.";

            Casts.Add("Jason Slater ", "Michael Begley");
            Casts.Add("Ned", "Joe Caffrey");
            Casts.Add("Hoskins", "Kenneth Alan Taylor");
            Casts.Add("Lord Belport", "Mark Chatterton");
            Casts.Add("Henry", "James Nickerson");
            Casts.Add("Luddite", "Toby Hadoke");
            Casts.Add("Millicent", "Julia Rounthwaite");

            Production.Add("WRITER", "Jim Poyser");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "Polly Thomas");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.ShowItems[0].AddLink("hTF_VrwpaF8");
            Shows.ShowItems[0].AddEpisode(1, "What Century Are You Living In?", "After a few drinks, English teacher Jason Slater wakes up in the 19th century.");
            Shows.ShowItems[0].AddEpisode(2, "The Time Machine", "Jason decides that the invention of the toasted sandwich maker will sort out his new 19th century life.");
            Shows.ShowItems[0].AddEpisode(3, "Strong Continental Lager", "What 19th century Macclesfield really needs is a decent pub, serving decent lager. Jason is just the man to organise it, or so he thinks.");
            Shows.ShowItems[0].AddEpisode(4, "Dentists And Lovers", "Ned needs root canal work, but 21st century Jason needs lessons in 19th century courting.");
            Shows.ShowItems[0].AddEpisode(5, "London", "Bored witless by one street Macclesfield, Jason suggests a trip to London, to general delight. But a mint popping highwayman soon changes everyone's plans.");
            Shows.ShowItems[0].AddEpisode(6, "Victorian Principles", "The young Queen Victoria is coming to Woolsley House for a visit. When Jason invents the electric guitar, he unwittingly changes the course of history.");
        }
    }
}