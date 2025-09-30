using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live
{
    public class DinnerLadies : AudioBaseDetails
    {
        public DinnerLadies()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Dinner Ladies";
            Year = 1997;
            DateAdded = "2025/10/10";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\25 Dinner Ladies\\";

            Description = "Comedy drama series about the dinner ladies of Old Dale School. Stars Barbara Dickson, Jean Heywood, Brigit Forsyth, Jack Smethurst, Bill Dean";

            Casts.Add("Bev", "Barbara Dickson ");
            Casts.Add("Sally", "Jean Heywood");
            Casts.Add("Mrs Ollerenshaw", "Brigit Forsyth");
            Casts.Add("Bob", "Jack Smethurst");
            Casts.Add("Stan", "Bill Dean");
            Casts.Add("Gary", "Tim Dantay");
            Casts.Add("Sheila", "Joyce Gibbs");
            Casts.Add("Jo", "Kaye Wragg");
            Casts.Add("Sophie", "Debbie Chazen");
            Casts.Add("Rita", "Maxine Finch");
            Casts.Add("Mr. Wright", "Andrew Wincott");
            Casts.Add("Kevin", "Stephen Hoyle");
            Casts.Add("Shelly", "Sally Walsh");
            Casts.Add("Indrani", "Vinny Dhillon");

            Production.Add("WRITER", "Turan Ali");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "Turan Ali");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("cAhKXpneHcI");
            Shows.Shows[0].AddEpisode(1, "Surprise Parties", "Bad news gets served up in the kitchen at Old Dale School.");
            Shows.Shows[0].AddEpisode(2, "Hare-Brained Schemes", "Faced with no jobs, Sheila has an idea - but bad news follows.");
            Shows.Shows[0].AddEpisode(3, "A Motley Crew", "In memory of Sheila, all the women battle to win the contract.");
            Shows.Shows[0].AddEpisode(4, "The Professionals", "Rejected by the bank, the ladies battle on to win the contract.");
            Shows.Shows[0].AddEpisode(3, "Taking the Bull by the Horns", "The battling school cooks hand in their tender and await the verdict.");
            Shows.Shows[0].AddEpisode(4, "A Very Mixed Grilling", "Can Bev's battling cooks win their tender for school meals?");
        }
    }
}