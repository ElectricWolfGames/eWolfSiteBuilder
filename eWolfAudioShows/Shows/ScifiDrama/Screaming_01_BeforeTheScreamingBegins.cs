using eWolfAudioShows.Data;
using System.Diagnostics.Metrics;

namespace eWolfAudioShows.Shows.ScifiDrama
{
    public class Screaming_01_BeforeTheScreamingBegins : AudioBaseDetails
    {
        public Screaming_01_BeforeTheScreamingBegins()
        {
            ShowTypes = Data.Enums.ShowTypes.SciFiDrama;

            Title = "The Scream Trilogy";
            TitleLine2 = "COMPLETE STORY\nBY WALLY K DALY";
            Year = 1978;

            DateAdded = "2025/12/12";
            OutputPath = "E:\\_AudioTemp\\Scifi\\_Uploading_SciFi\\11 The Scream Trilogy\\";

            Description = "The Scream Trilogy - Part 1, Tom Harris is abducted by aliens on his wedding anniversary, and returned with new, frightening mental powers. Part 2 sees the alien invasion gathering pace, and humanity struggling to fend off enemies from without and within. And in Part 3, the nations of Earth have formed a World Council to combat the threat they face. As the invaders' sinister plans are revealed, the Council takes action";

            Casts.Add("A.P.Smith", "Donald Hewlett");
            Casts.Add("Tom Harris", "James Laurenson");
            Casts.Add("Sally Harris", "Jennifer Piercey");

            // (Before the Screaming Begins)
            Casts.Add("Alien Voice", "Malcolm Gerrard (Before the Screaming Begins)");
            Casts.Add("Alien Controller", "Manning Wilson (Before the Screaming Begins)");
            Casts.Add("Prime Minister", "Patrick Troughton (Before the Screaming Begins)");
            Casts.Add("Silkine", "Peter Wickham (Before the Screaming Begins)");
            Casts.Add("Sgt.Forbes", "Robert Trotter (Before the Screaming Begins)");
            Casts.Add("Sally's Mother", "Catherine Parr (Before the Screaming Begins)");
            Casts.Add("Nurse Cabinet Minister", "Maggie Oleranshaw (Before the Screaming Begins)");
            Casts.Add("Desk Sgt.Opposition MP", "Peter Williams (Before the Screaming Begins)");

            // The Silent Scream
            Casts.Add("Prime Minister", "Colin Douglas v");
            Casts.Add("Silkin", "Peter Wickham (The Silent Scream)");
            Casts.Add("Brian Forbes", "Eric Allan (The Silent Scream)");
            Casts.Add("Andy / Sam", "Elizabeth Lindsey (The Silent Scream)");
            Casts.Add("1st Boy", "Andrew Branch (The Silent Scream)");
            Casts.Add("1st Girl", "Alison Draper (The Silent Scream)");
            Casts.Add("2nd Boy", "Tim Bentinck (The Silent Scream)");
            Casts.Add("3rd Boy", "Susan Sheridan (The Silent Scream)");
            Casts.Add("Constable / Sergeant", "Gregory De Polnay (The Silent Scream)");
            Casts.Add("Alien Controller/ Cabinet Minister", "Manning Wilson (The Silent Scream)");
            Casts.Add("Second Pilot / PC", "Gregory De Polnay (The Silent Scream)");
            Casts.Add("Cabinet Minister/ Second Lieut", "Philip Voss (The Silent Scream)");
            Casts.Add("Gloria / Cabinet Minister", "Brenda Kaye (The Silent Scream)");
            Casts.Add("Opposition MP / Colonel", "Peter Williams (The Silent Scream)");

            //  With a Whimper to the Grave
            Casts.Add("George", "Patrick Troughton (With a Whimper to the Grave)");
            Casts.Add("Prime Minister", "Angela Thorne (With a Whimper to the Grave)");
            Casts.Add("642", "Timothy West (With a Whimper to the Grave)");

            Production.Add("WRITER", "Wally K Daly");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add(string.Empty);
            Shows.Shows[0].AddLink("lSBlEuHYVsg");
            Shows.Shows[0].AddEpisode(1, "1 Before the Screaming Begins", "Tom Harris' wedding anniversary takes a dramatic turn when he's abducted by aliens... What is their intent?");
            Shows.Shows[0].AddEpisode(2, "2: The Silent Scream", "Earth prepares for an alien invasion. Tom Harris disappears into space but returns with new and astonishing powers. Put to good use, they will benefit humanity - but in the wrong hands they could have horrifying and nightmarish implications.");
            Shows.Shows[0].AddEpisode(3, "3: With a Whimper to the Grave", "The nations of Earth form a World Council with a cunning plan. The aliens reveal their true intentions. To combat the threat of an alien invasion, the nations of the Earth have formed a World Council. The aliens have given certain humans extraordinary 'sixth-sense' powers. But when these powers are abused the aliens prepare to leave and abandon the Earth to its fate. But are they really going? And what is the fate awaiting the peoples of the Earth?");
        }
    }
}