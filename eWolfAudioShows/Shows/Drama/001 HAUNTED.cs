using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class Haunted : AudioBaseEpisodesShowDetails
{
    public Haunted()
    {
        ShowTypes = Data.Enums.ShowTypes.None;

        Title = "HAUNTED: TALES OF THE SUPERNATURAL";

        Year = 1980;
        DateAdded = "";
        OutputPath = null;

        Description = "A BBC WORLD SERVICE, series of twenty-six episodes, broadcast from 1980-84. It included both classic and original ghost stories in a 30 minute format. They were dramatized by Derek Hoddinott and directed by him, unless otherwise noted. HUGE thanks to Internet Archive user thecoolerking for sending along the episodes I was missing so here’s the complete series.";

        var ep = Episodes.Add("Little Girl Lost");
        ep.Description = "With the recent death of her second husband, Mrs. Grove now stays with her son from her first marriage, Herbert, and his wife, Sally. Sally and Herbert think she has gone mad as she continually talks to her late second husband, John, so they've called in a doctor to take a look at her. But Janet, Herbert and Sally's daughter, believes that Mrs. Grove can talk to her late husband and wants to be able to hear his voice, too. Sally feels she is losing control over her daughter as she gets closer with Mrs. Grove and begs her husband to stop it.";
        ep.Casts.Add("Sally Lake", "Jenny Lyndon");
        ep.Casts.Add("Herbert Lake", "John Carson");
        ep.Casts.Add("Mrs. Grove", "Ruth Dunning");
        ep.Casts.Add("Janet Lake", "Bernadette Windsor");
        ep.Casts.Add("Doctor Raven / John Grove", "Adrian Eagan");

        ep.Production.Add("WRITER", "Rosemary Timperley");
        ep.OutputPath = "E:\\Aduio_Uploads\\Drama\\2026\\01 Haunted (BBC)\\01 Little Girl Lost\\";
    }
}