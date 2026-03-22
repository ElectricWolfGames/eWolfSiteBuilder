using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class JourneyToTheCenterOfTheEarth : AudioBaseOneOffShowDetails
{
    public JourneyToTheCenterOfTheEarth()
    {
        ShowTypes = Data.Enums.ShowTypes.Drama;

        Title = "Journey to the Center of the Earth";
        TitleLine2 = "By Jules Verne";

        OutputPath = "E:\\Audio_Uploads\\Drama\\2026\\05 Journey to the Center of the Earth\\";

        YTPlayList = "https://www.youtube.com/playlist?list=PL5uFllPR3aCfHLshihw2oXDBbbjtlt2MJ";

        Year = 1963;
        DateAdded = "";
        StoryType = "Fiction / Adventure";

        Description = "1963 Version, Journey to the Centre of the Earth is a classic 1864 science fiction novel by Jules Verne. " +
            "It follows Professor Otto Lidenbrock, his nephew Axel, and their guide Hans as they descend into " +
            "Iceland’s volcano Snæfellsjökull, facing cave-ins, storms, an underground sea, and prehistoric creatures " +
            "on their journey toward the Earth’s core.";
        FullDescription = "Journey to the Centre of the Earth is a classic science fiction novel by Jules Verne. It was first published in French in 1864, then reissued in 1867 in a revised and expanded edition. Professor Otto Lidenbrock is the tale's central figure, an eccentric German scientist who believes there are volcanic tubes that reach to the very center of the earth. He, his nephew Axel, and their Icelandic guide Hans rappel into Iceland's celebrated inactive volcano Snæfellsjökull, then contend with many dangers, including cave-ins, subpolar tornadoes, an underground ocean, and living prehistoric creatures from the Mesozoic and Cenozoic eras.";

        Casts.Add("", "Bernard Horsfall");
        Casts.Add("", "Jeffrey Banks");

        Production.Add("WRITER", "Jules Verne");
        Production.Add("DIRECTED", "Howard Jones");
    }
}