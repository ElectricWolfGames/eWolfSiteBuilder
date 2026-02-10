namespace eWolfAudioShows.Shows_OLD.Comedy._Live2025;

public class CenturyVampire : AudioBaseDetailsOLD
{
    public CenturyVampire()
    {
        ShowTypes = Data.Enums.ShowTypes.Comedy;

        Title = "20th Century Vampire";
        Year = 1993;
        DateAdded = "2025/08/08";

        Description = "The adventures of trainee vampire Eloise, her boyfriend Wayne and her eccentric Transylvanian tutor, Lucretia";

        Casts.Add("Eloise", "Louise Lombard");
        Casts.Add("Lucretia", "Joanna Kanska");

        Casts.Add("Wayne", "William Ivory");
        Casts.Add("Debbie", "Jane Hazlegrove");
        Casts.Add("Mr. Jenkins", "Fine Time Fontayne");

        Production.Add("WRITER", "Joe Turner");
        Production.Add("WRITER", "");

        Production.Add("PRODUCER", "");
        Production.Add("DIRECTOR", "");

        Shows.Add("Series  1");
        Shows.ShowItems[0].AddLink("aJKuwyfKcjM");
        Shows.ShowItems[0].AddEpisode(1, "I Am a Vampire", "Eloise receives monumental news from her mysterious Aunt Lucretia; it seems the Co-op checkout girl is now a vampire!");
        Shows.ShowItems[0].AddEpisode(2, "Back to School", "GCSE vampirism exam-time, but at least there is a practical!");
        Shows.ShowItems[0].AddEpisode(3, "The Biggest Secret", "Bursting to share her news of her vampirism, Eloise tells each of her possible confidants a dark secret (all untrue) to see if they can be trusted.");
        Shows.ShowItems[0].AddEpisode(4, "Staff Outing", "Debbie is responsible for arranging the annual Co-op staff outing, and decides on a trip to donate blood.");
        Shows.ShowItems[0].AddEpisode(5, "Endangered Species", "Eloise and Lucretia discover that Mr Jenkins's blood is the rarest – and tastiest! – in the world.");
        Shows.ShowItems[0].AddEpisode(6, "Love Shack", "Left alone to castle-sit in Lucretia's absence, how far will Eloise let boyfriend Wayne go?");
    }
}
