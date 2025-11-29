using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class Gush : AudioBaseDetails
    {
        public Gush()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Gush";
            Year = 1994;
            DateAdded = "";
            OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\032 Gush\\";

            Description = "Gush is the stunning saga of the bitter rivals Foxwell Cravate and Max Pomeroy whose destinies are tragically intertwined. Set in Durban at the Transworld Oil Conference and packed with the flair, fun and parody of the best TV mini-series of the 90s, this is comedy that will have you laughing out loud.\r\n";

            Casts.Add("Foxwell Cravate", "Martin Jarvis");
            Casts.Add("Max Pomeroy", "Mac McDonald");
            Casts.Add("Arabella Derbyshire", "Felicity Montagu");
            Casts.Add("Iolanthe Diamond", "Caroline Quentin");
            Casts.Add("Charles Ambrose Fortescue de Vere", "Jonathan Coy");
            Casts.Add("Prince Saudi", "Julian Dutton");
            Casts.Add("", "Toby Longworth");
            Casts.Add("", "Mandy Knight");
            Casts.Add("", "Steve Steen");
            Casts.Add("", "John Whitehal");

            Production.Add("WRITER", "Ian Hislop");
            Production.Add("WRITER", "Nick Newman");
            Production.Add("PRODUCER", "Colin Swash");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series 1");
            Shows.Shows[0].AddEpisode(1, "Episode One", "What could divide two close friends, the aristocratic Foxwell Cravate and American tycoon Max Pomeroy so far apart that their rivalry has come to threaten the human race? There's only one way to find out - with flashbacks.");
            Shows.Shows[0].AddEpisode(2, "Episode Two", "Could Cravate and Pomeroy's bitter rivalry ruin Prince Saudi's oil deal for world peace?");
            Shows.Shows[0].AddEpisode(3, "Episode Three", "Cravate and Pomeroy face execution. Can Lady Arabella win them a last-minute reprieve?");
            Shows.Shows[0].AddEpisode(4, "Episode Four", "Cravate and Pomeroy are joined by another prisoner and they plan their escape.");
            Shows.Shows[0].AddEpisode(5, "Episode Five", "Foxwell Cravate and Max Pomeroy come to an arrangement about the incriminating photograph.");
            Shows.Shows[0].AddEpisode(6, "Episode Six", "Cravate and Pomeroy achieve freedom, but soon find themselves on a collision course.");
        }
    }
}