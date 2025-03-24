using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class AnythingLegal : AudioBaseDetails
    {
        public AnythingLegal()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Anything Legal";
            Year = 1980;
            DateAdded = "2025/02/14";

            Description = "Best friends George and Charles have been commuting to work together for 15 years. Then, one fateful day, they both find out that they're being laid off. For a while, they keep the news secret and carry on as normal, but eventually, they have no choice but to admit the truth. It's time to take action and find alternative employment - but how?";

            Casts.Add("Charles", "Donald Hewlett");
            Casts.Add("George", "Michael Knowles");
            Casts.Add("Hilary", "Norma Ronald");
            Casts.Add("GJ", "Tony Anholt");
            Casts.Add("Futuristic Manager", "David Ryall");
            Casts.Add("Billy", "Michael Bilton");
            Casts.Add("Harry the Publican", "Colin Starkey");

            Production.Add("WRITER", "Wally K Daly");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("NMFsrNr9kc4");
            Shows.Shows[0].AddEpisode(1, "Episodes 1", "Charles and George are laid off, but afraid to tell anyone.");
            Shows.Shows[0].AddEpisode(2, "Episodes 2", "Admitting they've been laid off, Charles and George take action.");
            Shows.Shows[0].AddEpisode(3, "Episodes 3", "They earn their first cash, but at what cost?");
            Shows.Shows[0].AddEpisode(4, "Episodes 4", "A horrid child and a bizarre giant.");
            Shows.Shows[0].AddEpisode(5, "Episodes 5", "George and Charles hire a secretary to boost business.");
            Shows.Shows[0].AddEpisode(6, "Episodes 6", "Charles and George's new business course sets tongues wagging");
            Shows.Shows[0].AddEpisode(7, "Episodes 7", "Charles and George's DIY skills arouse their wives' suspicions.");
            Shows.Shows[0].AddEpisode(8, "Episodes 8", "George's nanny comes to the rescue.");
        }
    }
}