using eWolfAudioShows.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

namespace eWolfAudioShows.Shows.Comedy
{
    public class Married : AudioBaseDetails
    {
        public Married()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Married";
            Year = 1999;
            DateAdded = "";

            Description = "Sci-fi sitcom about Robin Lightfoot, a confirmed bachelor who wakes up one day in a parallel universe where he is married with two children.";

            Casts.Add("Robin Lightfoot", "Hugh Bonneville");
            Casts.Add("Leslie Lightfoot", "Josie Lawrence");
            Casts.Add("Dirk", "Stephen Frost");
            Casts.Add("Ned Lightfoot", "Sam Bradley");
            Casts.Add("Maxine Lightfoot", "Ann Gosling");
            Casts.Add("Arthur Smith", "Arthur Smith");
            Casts.Add("Julia Lightfoot", "Barbara Murray");

            Production.Add("WRITER", "Tony Bagley");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("iwFN3secQuE");
            Shows.Shows[0].AddEpisode(1, "Confirmed Bachelor", "Robin Lightfoot is grumpy yet happily single. Then one morning he wakes up to discover he's in a parallel universe. He's got a wife and two children.Is it a nightmare, a practical joke or something much more sinister ?");
            Shows.Shows[0].AddEpisode(2, "Family", "Robin Lightfoot has awoken in a parallel universe - not only does he have a family, but two half-brothers, both called Ian.");
            Shows.Shows[0].AddEpisode(3, "The Other Woman", "Bachelor Robin Lightfoot is feeling a little warmer towards his adopted 'wife' - but then he discovers 'his' past misdemeanours and his doppelganger's other woman turns up to rock the boat.");
            Shows.Shows[0].AddEpisode(4, "Arthur Smith", "Robin is starting like his life in a parallel universe as a married man. But he is completely thrown when the children's entertainer he has booked for his son's birthday party turns out to be comedian Arthur Smith from his old universe.");
            Shows.Shows[0].AddEpisode(3, "Back to Life", "Just as he is starting to make the most of his new life, Robin is whisked back to his old universe, where his doppelganger has been wreaking havoc.");
            Shows.Shows[0].AddEpisode(4, "Murder", "Robin is accused of murdering his new family and blackmailed for a divorce settlement.Two small questions: how is he going to win his new wife back, and how is he going to avoid the death penalty ?");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("uVwYzJpDR38");
            Shows.Shows[1].AddEpisode(1, "Churlish", "Life is about to change with Robin's divorce from the woman he was never married to in the first place.");
            Shows.Shows[1].AddEpisode(2, "The Truth Is Out There", "Robin uses a scam from his old universe to make himself rich in his new universe. In the process he attracts the attention of the security services and learns the horrible truth about Operation War of the Worlds.");
            Shows.Shows[1].AddEpisode(3, "Betrayal", "Divorced and penniless though he may be, Robin is about to discover that life can be sweet in his new universe - even if it is at someone else's expense.");
            Shows.Shows[1].AddEpisode(4, "Identity", "Robin has trouble with parallel worlds - there are 232 of him. Then he meets a woman he knew from another life. Confused? He is.");
            Shows.Shows[1].AddEpisode(5, "Serenity", "It has been a taxing few months for Robin in his new universe. But at last he seems to have tapped that well of inner peace. Or is there a more obvious explanation?");
            Shows.Shows[1].AddEpisode(6, "War Of The Worlds", "It is a fight to the death as Robin finally meets his doppelganger. When two universes collide, there can be only one winner.");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("ukdlCjcvE9s");
            Shows.Shows[2].AddEpisode(1, "Collided", "To his horror, Robin is going through a phase of being nice. But 'wife' Lesley is now an artist and doesn't want to know him. So Robin is left holding the baby - well, two teenagers and three babies.");
            Shows.Shows[2].AddEpisode(2, "Cafe Apocalypse", "The two universes have collided and Dirk sees an ideal opportunity to make money: he opens Cafe Apocalypse.");
            Shows.Shows[2].AddEpisode(3, "Powerbroker", "The King's ex, Adrian Turnball, quite literally drops in on Robin and Co after being trapped in a vortex for five weeks.");
            Shows.Shows[2].AddEpisode(4, "Texas", "Robin, Leslie and Dirk go for a drive - through a time anomaly - and find themselves in deepest, darkest Texas.");
            Shows.Shows[2].AddEpisode(5, "The Smiths", "Robin has encountered many strange phenomena since the universes collided. Today he has two Arthur Smiths for the price of one.");
            Shows.Shows[2].AddEpisode(6, "Discovery", "Grumpy bachelor Robin Lightfoot suddenly realises he must have been personally responsible for the two universes colliding when he travels back in time to the day he was born.");
        }
    }
}