namespace eWolfAudioShows.Shows_OLD.Comedy._Live2025;

public class DetectiveSergeantNickMohammed : AudioBaseDetailsOLD
{
    public DetectiveSergeantNickMohammed()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

        Title = "Detective Sergeant Nick Mohammed";
        Year = 2011;
        DateAdded = "2025/07/11";
        OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\16 Detective Sergeant Nick Mohammed\\";

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
        Shows.ShowItems[0].AddLink("xqc4gzd7QG0");
        Shows.ShowItems[0].AddEpisode(1, "Episodes 1", "Gosh, there's been a murder... Ouch! Nick and company try to solve it.");
        Shows.ShowItems[0].AddEpisode(2, "Episodes 2", "Someone has been kidnapped... Yikes! Nick tackles the hostage negotiations.");
        Shows.ShowItems[0].AddEpisode(3, "Episodes 3", "There's a riot going on... topical! Nick tackles a full-on student protest.");
        Shows.ShowItems[0].AddEpisode(4, "Episodes 4", "Uh oh, not another bank heist... ker-ching! Nick and co try to solve it.");

        Shows.Add("Series  2");
        Shows.ShowItems[1].AddLink("VzNEx-V-daM");
        Shows.ShowItems[1].AddEpisode(1, "Forgery", "DS Nick Mohammed is immersed in the art world when a forgery ring is discovered.");
        Shows.ShowItems[1].AddEpisode(2, "Jury", "DS Nick Mohammed has his day in court, but the judge seems unimpressed...");
        Shows.ShowItems[1].AddEpisode(3, "Fugitive", "DS Nick Mohammed is on the trail of a fugitive, with the help of Colin and Anna.");
        Shows.ShowItems[1].AddEpisode(4, "Security", "DS Nick Mohammed is asked to provide additional security for a major event.");
    }
}
