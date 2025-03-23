using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class MyFirstPlanet : AudioBaseDetails
    {
        public MyFirstPlanet()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "My First Planet";
            Year = 2012;
            DateAdded = "2025/01/24";

            Description = "My First Planet is a British radio sitcom written by Phil Whelans. Set on a newly founded space colony, second-in-command Brian Palmer (Nicholas Lyndhurst) finds himself unexpectedly in charge when their intended leader dies and must work with the colonists to ensure their survival.\r\n";

            Casts.Add("Brian", "Nicholas Lyndhurst");
            Casts.Add("Lillian", "Vicki Pepperdine");
            Casts.Add("Mason", "Tom Goodman-Hill");
            Casts.Add("Archer", "Phil Whelans");
            Casts.Add("Carol (series 1)", "Cariad Lloyd");
            Casts.Add("Carol (series 2)", "Letty Butler");
            Casts.Add("Richard", "John Dorney");

            Production.Add("WRITER", "Phil Whelans");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "David Tyler");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("z5lks7pyUKc");
            Shows.Shows[0].AddEpisode(1, "The Landing Has Landed", "Day 1 on the colony and the inhabitants have lost the food, the air, the Commander and the mood music. Meanwhile, Chief Physician Lillian makes a terrible discovery about Project Adam.");
            Shows.Shows[0].AddEpisode(2, "Hairdresser from Space", "Day 7 on the colony and Mason stirs up an ethical nightmare involving a hairdressing clone. Richard, meanwhile, tries to find a purpose in the colony.");
            Shows.Shows[0].AddEpisode(3, "The Noticeboard of Doom", "Day 9 and the colonists are torn between Richard's newsletter and Archer's hot pants.");
            Shows.Shows[0].AddEpisode(4, "Inglorious Barters", "Day 12. A queue for the loo and a rogue backrub threaten to blow up the colony. With guest star Richard Bond.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("gY-xK9ZO-Zw");
            Shows.Shows[1].AddEpisode(1, "Sample of Terror", "Day 30 and Brian tries to save the contents of a freezer, while Mason tries to role-play in the nuclear core.");
            Shows.Shows[1].AddEpisode(2, "One Small Naughty Step For Man", "Day 32. The colony teacher shuts Carol and Richard in a room with some alcohol, Lillian attempts to cure the common cold and Mason invents a personal environment suit.");
            Shows.Shows[1].AddEpisode(3, "They Came to Test Our Brains", "Day 40. A pub quiz and a talking yam, who seems to be smarter than he, spells disaster for Brian when he discovers his I.Q.");
            Shows.Shows[1].AddEpisode(4, "Adjective From Space!", "Day 43. Lillian experiments with mind control and an election is called. Richard goes for the youth vote by talking nonsense while Brian's campaign is based on some nauseating protein.");
            Shows.Shows[1].AddEpisode(5, "Let Me Entertain Me", "Day 46. The colony is suffering from a lack of art and CCTV is the new entertainment. Despite the discovery of a poet, Archer gains popularity by scripting events, including a monster, a sword fight and a bomb.");
            Shows.Shows[1].AddEpisode(6, "Day Trip to Terror!", "Day 49. What better time for social media to kick in than on a dangerous mission on the surface?");
        }
    }
}