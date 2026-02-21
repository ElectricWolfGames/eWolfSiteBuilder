using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Drama;

public class ICE : AudioBaseOneOffShowDetails
{
    public ICE()
    {
        ShowTypes = Data.Enums.ShowTypes.Drama;

        Title = "ICE:";
        TitleLine2 = "By James Follett";

        OutputPath = "E:\\Audio_Uploads\\Drama\\2026\\02 ICE - James Follett\\";

        // YTPlayList = "https://www.youtube.com/playlist?list=PL5uFllPR3aCfYvj0shjRZaNAhfFZ0S-EU";

        Year = 1986;
        DateAdded = "";
        StoryType = "Fiction / Thriller";

        Description = "Eight thousand square miles of solid ice, which have become detached from the Antarctic, are drifting inexorably towards New York Harbor. The combined might of the US military seems powerless to avert the collision, but if it occurs, the whole city will 'ring like a bell'.";

        Casts.Add("Narrator", "Sean Barrett");
        Casts.Add("Julia Hammond", "Carol Drinkwater");
        Casts.Add("Glyn Sherwood", "Anthony Hyde");
        Casts.Add("Oaf", "Eric Allan");
        Casts.Add("Captain Hagan", "Ed Bishop");
        Casts.Add("Admiral Pearson", "Don Fellows");
        Casts.Add("US President", "Alan Tilvern");
        Casts.Add("Angus Brill", "Brian Hewlett");
        Casts.Add("Walter Krantz", "Peter Marinker");
        Casts.Add("TV reporter", "Kim Wall");
        Casts.Add("Maguire", "Bruce Boa");
        Casts.Add("Stevens", "Jonathan Tafler");
        Casts.Add("Steward", "Peter Howell");
        Casts.Add("Mason", "Andrew Branch");
        Casts.Add("Lt Klein", "David Goodland");
        Casts.Add("Greaser", "Stephen Hattersley");
        Casts.Add("Chief Engineer", "Paul Gregory");
        Casts.Add("TV announcer", "Rachel Gurney");

        Production.Add("WRITER", "James Follett");
        Production.Add("DIRECTED", "Alec Reid");
    }
}