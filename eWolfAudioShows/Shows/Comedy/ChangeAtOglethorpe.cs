using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy
{
    public class ChangeAtOglethorpe : AudioBaseDetails
    {
        public ChangeAtOglethorpe()
        {
            ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

            Title = "Change At Oglethorpe";
            Year = 1995;
            DateAdded = "";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\30 Change At Oglethorpe\\";

            Description = "When Oglethorpe station gets a new station manager, a graduate trainee who has never worked on the railways, comic situations ensue.";

            Casts.Add("David Clare", "Peter Davison ");
            Casts.Add("George 'Rocket' Stephenson", "Michael Williams");
            Casts.Add("June Virgo", "Rosemary Martin");
            Casts.Add("Louise' Points' Pointer", "Phillippa Wilson");
            Casts.Add("Hattie", "Madge Hindle");
            Casts.Add("Mr Arthur Sod", "Chris Emmett ");

            Production.Add("WRITER", "Michael Williams");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("");
            Shows.Shows[0].AddEpisode(1, "Off the Rails", "A graduate trainee takes charge of a rural railway station and its eccentric staff.");
            Shows.Shows[0].AddEpisode(2, "The Thin Controller", "Trouble for the rural railway station's new manager when he sacks a member of staff.");
            Shows.Shows[0].AddEpisode(3, "The Brew That Is True", "The royal train's visit sparks turmoil for the rural railway station's new manager.");
            Shows.Shows[0].AddEpisode(4, "Remember, Remember the Fifth of September", "Birthday celebrations go awry for the rural railway station's cafe proprietor June.");
            Shows.Shows[0].AddEpisode(5, "The Unquiet American", "The rural station staff attempt to secure an old engine, but there is a big catch.");
            Shows.Shows[0].AddEpisode(6, "Foreign Parts", "As winter arrives on the rural railway, stationmaster David gets an exciting job offer.");
        }
    }
}