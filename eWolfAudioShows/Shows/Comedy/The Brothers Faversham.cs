using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy;

public class TheBrothersFaversham : AudioBaseDetails
{
    public TheBrothersFaversham()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

        Title = "The Brothers Faversham";
        Year = 2008;
        DateAdded = "";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\033 The Brothers Faversham\\";

        Description = "The Penny Dreadfuls (Humphrey Ker, David Reed & Thom Tuck), spoofing the square-jawed heroes of Victorian";

        Casts.Add("Various", "Humphrey Ker");
        Casts.Add("Various", "David Reed");
        Casts.Add("Various", "Thom Tuck");
        Casts.Add("Alexandra Faversham", "Ingrid Oliver");
        Casts.Add("Ensemble Actor", "Ingrid Oliver");
        Casts.Add("Narrator", "Miles Jupp");

        Production.Add("WRITER", "Humphrey Ker");
        Production.Add("WRITER", "David Reed");
        Production.Add("WRITER", "Thom Tuck");
        Production.Add("SCRIPT EDITOR", "Richard Turner");

        Shows.Add("Series 1");
        Shows.Shows[0].AddLink("");
        Shows.Shows[0].AddEpisode(1, "Horatius", "The Penny Dreadfuls present the story of Horatius, Victorian Britain's most decorated soldier and first born of the Faversham brothers.");
        Shows.Shows[0].AddEpisode(2, "Theseus", "The Penny Dreadfuls present the story of Theseus, a detective respected even more than Sherlock Holmes and second born of the Faversham brothers.");
        Shows.Shows[0].AddEpisode(3, "Leonidas", "The Penny Dreadfuls present the story of Leonidas, Victorian Britain's most reckless explorer and the third born of the Faversham Brothers.");
        Shows.Shows[0].AddEpisode(4, "Augustus", "The Penny Dreadfuls present the story of Augustus, the greatest illusionist in the history of Victorian Britain and the fourth born of the Faversham Brothers.");

        Shows.Add("Series 2");
        Shows.Shows[0].AddLink("");
        Shows.Shows[1].AddEpisode(1, "Titus", "The Penny Dreadfuls present the story of Titus, Victorian Britain's greatest sporting hero and the fifth born of the Faversham Brothers.");
        Shows.Shows[1].AddEpisode(2, "Maximillian", "The Penny Dreadfuls present the story of Maximillian, horror writer extraordinaire and the sixth born of the Faversham Brothers.");
        Shows.Shows[1].AddEpisode(3, "Marcus", "The Penny Dreadfuls present the story of Marcus, one of the Empire's greatest actors and the seventh born of the Faversham Brothers.");
        Shows.Shows[1].AddEpisode(4, "Perseus And Lucius", "The Penny Dreadfuls present the story of two twin brothers - kind-hearted Perseus and cruel, bitter Lucius, a pair for powerful and wealthy industrialists, and the eighth and ninth born of the Faversham Brothers.");
    }
}