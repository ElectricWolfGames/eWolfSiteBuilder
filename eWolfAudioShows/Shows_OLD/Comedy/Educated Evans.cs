namespace eWolfAudioShows.Shows_OLD.Comedy;

public class EducatedEvans : AudioBaseDetailsOLD
{
    public EducatedEvans()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

        Title = "Educated Evans";
        Year = 1996;
        DateAdded = "2026/02/13";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\035 Educated Evans\\";

        Description = "Darkly comic tales from the underground world of horse racing.";

        Casts.Add("Educated Evans", "Charlie Chester");

        Production.Add("WRITER", "Sidney Nelson   ");
        Production.Add("WRITER", "Maurice Harrison ");
        Production.Add("WRITER", "Bernard Botting ");
        Production.Add("WRITER", "Charlie Hart    ");

        Production.Add("PRODUCER", "Eric Fawcett");
        Production.Add("DIRECTOR", "Eric Fawcett");
        Production.Add("CREATOR", "Edgar Wallace");

        Shows.Add("Series  1");
        Shows.ShowItems[0].AddLink("dkeHMp8nOck");
        Shows.ShowItems[0].AddEpisode(1, "Episodes 1", "The 1920s tipster gets an unlikely helping hand from a self-righteous police inspector.");
        Shows.ShowItems[0].AddEpisode(2, "Episodes 2", "Can the skint 1920s tipster plot revenge on a local informant and end up a winner too?");
        Shows.ShowItems[0].AddEpisode(3, "Episodes 3", "Can the tipster help a friend in trouble and acquire valuable information along the way?");
        Shows.ShowItems[0].AddEpisode(4, "Episodes 4", "Can the 1920s tipster avoid police plans and see off a new 'educated' rival?");
    }
}