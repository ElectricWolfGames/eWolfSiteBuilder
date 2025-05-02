using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live
{
    public class Dot : AudioBaseDetails
    {
        public Dot()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Dot";
            Year = 2015;
            DateAdded = "2025/05/23";

            Description = "Rollicking wartime comedy set in the personnel department of the Cabinet War Rooms. Sitcom by Ed Harris.";

            Casts.Add("Dot", "Fenella Woolgar");
            Casts.Add("Myrtle", "Kate O'Flynn");
            Casts.Add("Millicent", "Jane Slavin");
            Casts.Add("Peabody", "David Acton");
            Casts.Add("Peg", "Freya Parker");

            Production.Add("WRITER", "Ed Harris");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "Jessica Brown");
            Production.Add("DIRECTOR", "Jessica Brown");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("mFGN6EyyJBU");
            Shows.Shows[0].AddEpisode(1, "The Astonishing Adventures Of Agent Whiff-Whaff", "Dot and the gals from personnel are getting squiffy over Agent Bertie Whiff-Whaff. Bertie wants Dot promoted, but can Dot handle life on the other side of the hallway?");
            Shows.Shows[0].AddEpisode(2, "The Extraordinary Example Of The Ha'penny Exchange", "A little East End snotling has found her way into the Cabinet War Rooms. How will Dot dispose of her?");
            Shows.Shows[0].AddEpisode(3, "The Mystery At St. Horribly-Vulture's School For Boys", "Dot is sent to back to school to enlist a teacher for 'Shhh Bletchley Park', but is he of sound material?");
            Shows.Shows[0].AddEpisode(4, "Eenie Meenie Miney... Spy!", "The Russian ambassador is in town, Dot and the gals are on surveillance duty. Can they snaffle the Russian secrets?");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("36kiJsPJ2VM");
            Shows.Shows[1].AddEpisode(1, "Teeth", "The fellas are going gaga for Myrtle's new gnashers. As Hollywood beckons, how will Dot take the news she is no longer the star of her own show.");
            Shows.Shows[1].AddEpisode(2, "Psychology", "Peabody's not been the full shilling recently and now Dr Pinkly has arrived to test who is the psychological 'weak link' and everyone's a suspect. Who will be deemed sane and who will be sent to Sunnyside Sanatorium?");
            Shows.Shows[1].AddEpisode(3, "Meat", "The American ambassador is coming to town, and Dot is in charge of cooking up a storm. She must prepare a delicious cut of veal to woo the Ambassador. It's a shame she just ate it. How will they wriggle out of this one?");
            Shows.Shows[1].AddEpisode(4, "Trees", "Dot and the gals are tasked with a top secret mission in the countryside. A German plane crashes nearby, will this be Dot's big chance for promotion?");

            Shows.Add("Series  3");
            Shows.Shows[2].AddLink("0XXqHNxEl6U");
            Shows.Shows[2].AddEpisode(1, "Saucepans for Spitfires!", "A national initiative to boost morale causes havoc in the War Rooms.");
            Shows.Shows[2].AddEpisode(2, "Dial M for Myrtle", "A suspicious death leaves the gals from personnel with no options other than to investigate.");
            Shows.Shows[2].AddEpisode(3, "Dig for Victory!", "The Women's Land Army are on the hunt for volunteers, and Dot and the gals are whisked off to the countryside to work the land. It is not long before Dot is planning a great escape.");
            Shows.Shows[2].AddEpisode(4, "London Can Take It", "Can Dot use her resemblance to Vera Lynn to get one over on Millicent as the they seek to ingratiate themselves with the PM?");
            // Shows.Shows[2].AddEpisode(5, "Dot and the Russian Dossier", "May, 1941. The future of the war hangs in the balance, and Dot has been selected for a most perilous mission.");
        }
    }
}