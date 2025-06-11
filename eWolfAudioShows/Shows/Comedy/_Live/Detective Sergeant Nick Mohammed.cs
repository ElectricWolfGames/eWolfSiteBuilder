using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class DetectiveSergeantNickMohammed : AudioBaseDetails
    {
        public DetectiveSergeantNickMohammed()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Detective Sergeant Nick Mohammed";
            Year = 2011;
            DateAdded = "2025/07/11";

            Description = "Set at Tilford Road Police Station, Nick is joined by Sergeants Anna Crilly, Colin Hoult as they attempt to solve a different crime each week.";

            Casts.Add("Various", "Nick Mohammed");
            Casts.Add("Ensemble Actor", "Anna Crilly");
            Casts.Add("Ensemble Actor", "Colin Hoult");
            Casts.Add("", "Margaret Cabourn-Smith");
            Casts.Add("", "Will Andrews");

            Production.Add("WRITER", "Nick Mohammed");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "Victoria Lloyd");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "Gosh, there's been a murder... Ouch! Nick and company try to solve it.");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "Someone has been kidnapped... Yikes! Nick tackles the hostage negotiations.");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "There's a riot going on... topical! Nick tackles a full-on student protest.");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "Uh oh, not another bank heist... ker-ching! Nick and co try to solve it.");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("");
            Shows.Shows[1].AddEpisode(1, "Forgery", "DS Nick Mohammed is immersed in the art world when a forgery ring is discovered.");
            Shows.Shows[1].AddEpisode(2, "Jury", "DS Nick Mohammed has his day in court, but the judge seems unimpressed...");
            Shows.Shows[1].AddEpisode(3, "Fugitive", "DS Nick Mohammed is on the trail of a fugitive, with the help of Colin and Anna.");
            Shows.Shows[1].AddEpisode(4, "Security", "DS Nick Mohammed is asked to provide additional security for a major event.");
        }
    }
}