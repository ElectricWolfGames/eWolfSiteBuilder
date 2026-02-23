using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class TheRabidSummer : AudioBaseOneOffShowDetails
{
    public TheRabidSummer()
    {
        ShowTypes = Data.Enums.ShowTypes.Drama;

        Title = "The Rabid Summer";
        TitleLine2 = "By James Follett";

        OutputPath = "E:\\Audio_Uploads\\Drama\\2026\\04 The Rabid Summer by James Follett\\";

        YTPlayList = "https://www.youtube.com/playlist?list=PL5uFllPR3aCfHLshihw2oXDBbbjtlt2MJ";

        Year = 1980;
        DateAdded = "";
        StoryType = "Fiction / Thriller";

        Description = "On a hot August Bank Holiday in a small seaside town, panic and disaster strike when it is discovered that rabies has broken out. How did it enter the country? The outbreak must be controlled, people must be protected, the culprit must be found ... ";

        Casts.Add("David Coleman", "Patrick Barr");
        Casts.Add("Muriel Coleman", "Pauline Letts");
        Casts.Add("Collins/Receptionist", "Betty Baskcomb");
        Casts.Add("Margent", "John Ringram");
        Casts.Add("Swann", "Clifford Norgate");
        Casts.Add("Dr Menon", "Valerie Murray");
        Casts.Add("Harding", "Michael Tudor Barnes");
        Casts.Add("Blanchard/Townsman", "Leslie Heritage");
        Casts.Add("WilliS", "Keith Smith");
        Casts.Add("Major Latham", "Garard Green");
        Casts.Add("Tess Coleman", "Jo Manning Wilson");
        Casts.Add("Mathis", "Malcolm Reid");
        Casts.Add("Nurse/Townswoman", "Anne senfeld");
        Casts.Add("Mrs Fairchild/Nurse", "Diana Payan");
        Casts.Add("Kemp/Holidaymaker", "Peter Woodthorpe");
        Casts.Add("Animal effects", "Percy Edwards");

        Production.Add("WRITER", "James Follett");
        Production.Add("DIRECTED", "Kay Patrick");
    }
}