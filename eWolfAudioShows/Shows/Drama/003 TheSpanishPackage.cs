using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class TheSpanishPackage : AudioBaseOneOffShowDetails
{
    public TheSpanishPackage()
    {
        ShowTypes = Data.Enums.ShowTypes.Drama;

        Title = "The Spanish Package";
        TitleLine2 = "By James Follett";

        OutputPath = "E:\\Audio_Uploads\\Drama\\2026\\03 The Spanish Package - James Follett\\";

        YTPlayList = "https://www.youtube.com/playlist?list=PL5uFllPR3aCfHLshihw2oXDBbbjtlt2MJ";

        Year = 1977;
        DateAdded = "";
        StoryType = "Fiction / Thriller";

        Description = "Peter and Jane have retired to Spain. Each year they look forward to a visit from their daughter, Clare. She was unable to come last year, but this year when they go to meet her at Alicante Airport....";

        Casts.Add("Jane", "Irene Sutcliffe");
        Casts.Add("Peter", "Michael Harbour");
        Casts.Add("Alan", "Gavin Campbell");
        Casts.Add("Gillian / Sarah", "Jane Knowles");
        Casts.Add("Customs Officer / Det-Sgt Reece / Third Tourist", "Michael Tudor Barnes");
        Casts.Add("Whitton", "Michael Goldie");
        Casts.Add("Mrs Read / Receptionist", "Shirley Dixon");
        Casts.Add("Dr Ryan", "Peter Howell");
        Casts.Add("Marsh", "James Thomason");
        Casts.Add("Maurice", "Jonathan Scott");
        Casts.Add("Ossie", "Walter Hall");
        Casts.Add("Mechanic/First Tourist/Ruffian", "Paul Meier");
        Casts.Add("Det Insp Boyd", "Bruce Beeby");
        Casts.Add("Angela / Second Tourist / Loud speaker voice", "Nicolette McKenzie");
        Casts.Add("Miss Grey", "Joan Matheson");

        Production.Add("WRITER", "James Follett");
        Production.Add("DIRECTED", "David H. Godfrey");
    }
}