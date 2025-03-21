using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class DoNothingTilYouHearFromMe : AudioBaseDetails
    {
        public DoNothingTilYouHearFromMe()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Do Nothing 'Til You Hear from Me";
            Year = 2004;
            DateAdded = "2025/04/04";

            Description = "Sitcom about a cantankerous trombone player. Stars Ram John Holder, Yvonne Brewster, George Layton, Sam Kelly, Caroline Lee Johnson and more.\r\n";

            Casts.Add("Roy Walker", "Ram John Holder");
            Casts.Add("Roy Walker (Series 2)", "Don Warrington");
            Casts.Add("Violet", "Yvonne Brewster");
            Casts.Add("Barry", "George Layton");
            Casts.Add("George", "Sam Kelly");
            Casts.Add("Bernadette", "Caroline Lee Johnson");
            Casts.Add("Victor", "Marcus Powell");

            Production.Add("WRITER", "John Byrne");
            Production.Add("WRITER", "Marcus Powell  (Series 2)");
            Production.Add("PRODUCER", "Carol Smith");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("2P4c9cEoChY");
            Shows.Shows[0].AddEpisode(1, "Body and Soul", "At a bandmate's funeral, musicians Roy and George face up to their own mortality.");
            Shows.Shows[0].AddEpisode(2, "Let's Face the Music", "Will musicians Roy and George live up to the billing at their comeback gig?");
            Shows.Shows[0].AddEpisode(3, "The Folks Who Live on the Hill", "Vi is sick, and Roy is no help. Then unexpected guests arrive for Victor's birthday party.");
            Shows.Shows[0].AddEpisode(4, "Round Midnight", "When an old musician friend turns up after 40 years abroad, Roy begins to smell a rat.");
            Shows.Shows[0].AddEpisode(5, "I Could Write a Book", "Roy must face up to life after the loss of Leonard, his beloved trombone.");
            Shows.Shows[0].AddEpisode(6, "She's Funny That Way", "Could the return of an old flame mark the end of Roy and George's musical marriage?");

            Shows.Add("Series  2");
            Shows.Shows[1].AddLink("ITQnEglySlk");
            Shows.Shows[1].AddEpisode(1, "Lulu's Back in Town", "Musician Roy panics when his wife's vivacious sister takes best pal George out for dinner.");
            Shows.Shows[1].AddEpisode(2, "I Get Along Without You Very Well", "When Barry's wife walks out, Roy knows the best way to get her back, until rum intervenes.");
            Shows.Shows[1].AddEpisode(3, "Swingin' Down the Lane", "Can musicians Roy and George settle a 50-year-old score with their former bandleader?");
            Shows.Shows[1].AddEpisode(4, "Thanks for the Memory", "Can Roy lift George's spirits by organising a very special celebration?");
        }
    }
}