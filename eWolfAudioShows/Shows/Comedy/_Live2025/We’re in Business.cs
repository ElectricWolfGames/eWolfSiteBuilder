using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live2025
{
    public class WereinBusiness : AudioBaseDetails
    {
        public WereinBusiness()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "We’re in Business";
            Year = 1959;
            DateAdded = "2025/12/12";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\29 We’re in Business\\";

            Description = "Dudley Grosvenor a dodgy small-time businessman Dudley Grosvenor, who’s always looking to make a fast buck with his crooked schemes - usually at the expense of his hapless sidekick, Harry. Dudley spends his life lurching from one crisis to another.";

            Casts.Add("Dudley Grosvenor", "Peter Jones");
            Casts.Add("Harry", "Harry Worth");
            Casts.Add("Granny / Miss Jubilee Boot", "Irene Handl");
            Casts.Add("Lady Crabbe", "Beryl Reid");
            Casts.Add("Sid / Mr Trumpet", "Dick Emery");
            Casts.Add("Parrot", "Peter Hawkins");
            Casts.Add("Various", "Hugh Paddick");
            Casts.Add("Various", "Doris Hare");
            Casts.Add("Various", "Vivienne Martin");
            Casts.Add("Various", "Paddy Edwards");
            Casts.Add("Various", "Wallas Eaton");
            Casts.Add("Various", "John Graham");
            Casts.Add("Various", "Frederick Treves");

            Production.Add("WRITER", "Peter Jones");
            Production.Add("WRITER", "George Wadmore");
            Production.Add("WRITER", "George Evans");
            Production.Add("WRITER", "Marty Feldman");
            Production.Add("WRITER", "Barry Took");
            Production.Add("PRODUCER", "Charles Maxwell");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.ShowItems[0].AddLink("QN6pWa_hq5w");
            Shows.ShowItems[0].AddEpisode(1, "Conscience Money", "After a win on the horses, Dudley splashes the cash, and his mother also has money to burn");
            Shows.ShowItems[0].AddEpisode(2, "The Newspaper Business", "Can Dudley and Harry make a go of it in the newspaper business?");
            Shows.ShowItems[0].AddEpisode(3, "The Parrot", "Dudley and Harry's rent is overdue. Can a new visitor help them out? From 1960.");
            Shows.ShowItems[0].AddEpisode(4, "The Regimental Dinner", "Can Dudley and Harry help the Major organise his regimental dinner?");
            Shows.ShowItems[0].AddEpisode(5, "The Gorilla", "When he breaks the major's stuffed gorilla, Dudley, Harry and Miss Boot seek a replacement");
            Shows.ShowItems[0].AddEpisode(6, "Changing Rooms", "Can Dudley and Harry get along in their new noisy lodgings?");
            Shows.ShowItems[0].AddEpisode(7, "Dudley and Harry's Reunion", "With Dudley behind bars, surely Harry is safe from his crooked scheming?");
            Shows.ShowItems[0].AddEpisode(8, "Dudley's Granny", "Dudley and Harry end up at the mercy of a devious criminal.");
        }
    }
}