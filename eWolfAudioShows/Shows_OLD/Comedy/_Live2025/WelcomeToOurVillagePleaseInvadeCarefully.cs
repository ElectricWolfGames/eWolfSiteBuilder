namespace eWolfAudioShows.Shows_OLD.Comedy._Live2025;

public class WelcomeToOurVillagePleaseInvadeCarefully : AudioBaseDetailsOLD
{
    public WelcomeToOurVillagePleaseInvadeCarefully()
    {
        ShowTypes = Data.Enums.ShowTypes.Comedy;

        Title = "Welcome To Our Village, Please Invade Carefully";
        Year = 2012;
        DateAdded = "2025/06/06";

        Description = "Sitcom about an alien invasion of a small village, starring Hattie Morahan";

        Casts.Add("Katrina Lyons", "Hattie Morahan(Series 1 & 2)");
        Casts.Add("Field Commander Uljabaan", "Julian Rhind - Tutt(Series 1)");
        Casts.Add("Field Commander Uljabaan", "Charles Edwards(Series 2)");
        Casts.Add("Richard Lyons", "Peter Davison");
        Casts.Add("Margaret Lyons", "Jan Francis");
        Casts.Add("Lucy Alexander", "Hannah Murray");
        Casts.Add("Computer", "John - Luke Roberts ");

        Production.Add("WRITER", "Eddie Robson");
        Production.Add("WRITER", "");
        Production.Add("PRODUCER", "Ed Morrish");
        Production.Add("DIRECTOR", "");

        Shows.Add("Series  1");
        Shows.ShowItems[0].AddLink("XqXuWN7SsY4");
        Shows.ShowItems[0].AddEpisode(1, "Taking Overs", "The Geonin alien invaders are challenged to a village cricket match.");
        Shows.ShowItems[0].AddEpisode(2, "Minimum Volume", "Katrina attempts to sabotage Uljabaan's post-invasion education programme.");
        Shows.ShowItems[0].AddEpisode(3, "Power Block", "A busy Uljabaan asks Margaret to help him to oppress the humans.");
        Shows.ShowItems[0].AddEpisode(4, "Little Green Lights", "Uljabaan prepares for an invasion assessment by his superior, Gryvook.");

        Shows.Add("Series  2");
        Shows.ShowItems[1].AddLink("e39dQyVKFYE");
        Shows.ShowItems[1].AddEpisode(1, "Counter Plot", "Richard is alarmed to find that Uljabaan has commandeered six allotments for an experiment");
        Shows.ShowItems[1].AddEpisode(2, "Tempting Fete", "Tempers rise preparing for the village fete, and Lucy discovers guitar irritates aliens.");
        Shows.ShowItems[1].AddEpisode(3, "Questioning Loyalties", "Collaboration loyalty cards ruin Uljabaan's plans and Richard's chances in the pub quiz.");
        Shows.ShowItems[1].AddEpisode(4, "Ctrl-Alt-Del", "The computer catches a very common virus, making the invasion doomed in more ways than one");
        Shows.ShowItems[1].AddEpisode(5, "Testing Times", "Lucy must either pass her A-levels or leave the resistance.");
        Shows.ShowItems[1].AddEpisode(6, "Exit Strategy", "Uljabaan is determined to fail his annual inspection, but he needs help...");
    }
}
