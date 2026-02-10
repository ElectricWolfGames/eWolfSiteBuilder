using System.Diagnostics;
using System.Drawing;

namespace eWolfAudioShows.Shows_OLD.Comedy;

public class MasteringTheUniverse : AudioBaseDetailsOLD
{
    public MasteringTheUniverse()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.None;

        Title = "Mastering The Universe";
        Year = 2005;
        DateAdded = "";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\037 Mastering The Universe\\";

        Description = "Radio comedy series starring Dawn French as Professor Joy Klamp, a specialist in the art of spoiling other people's pleasure.";

        Casts.Add("Professor Joy Klamp", "Dawn French");
        Casts.Add("Ensemble Actor", "Christopher Douglas");
        Casts.Add("Ensemble Actor", "Sally Grace");
        Casts.Add("Ensemble Actor", "Dan Tetsell");
        Casts.Add("Ensemble Actor(Series 1)", "Lucy Montgomery");
        Casts.Add("Ensemble Actor(Series 2)", "Katy Brand");
        Casts.Add("Announcer", "Brian Perkins");

        Production.Add("WRITER", "Christopher Douglas");
        Production.Add("WRITER", "Nick Newman");
        Production.Add("PRODUCER", "Simon Nicholls");
        Production.Add("DIRECTOR", "");

        Shows.Add("Series 1");
        Shows.ShowItems[0].AddLink("");
        Shows.ShowItems[0].AddEpisode(1, " The Workplace", "Professor Joy Klamp thinks everyone deserves to feel the fulfilling empowerment of spoiling someone else's fun. This week Joy focuses on the most fertile environment for the manipulation of relationships through non-enjoyment techniques - the workplace.");
        Shows.ShowItems[0].AddEpisode(2, " The Joy Of Sulks", "This week Professor Joy Klamp looks at the role of the sulk in modern relationships.");
        Shows.ShowItems[0].AddEpisode(3, " Party On Down", "In this week's guide, Joy Klamp is looking at the joy of parties, and how to take control of these social situations... and spoil them.");
        Shows.ShowItems[0].AddEpisode(4, " Holidays", "This week's Mastering The Universe looks at how to extract the maximum emotional leverage from the most precious two weeks of the year, the annual holiday.");
        Shows.ShowItems[0].AddEpisode(5, " Food And Drink", "For the dedicated passive-aggressive wanting to create tension, induce guilt and exercise control, there's nowhere quite like the dinner table.");
        Shows.ShowItems[0].AddEpisode(6, " Christmas", "In the final episode of the series, Professor Joy Klamp explains how to overcome the difficult challenge of ruining the season of goodwill.");

        Shows.Add("Series 2");
        Shows.ShowItems[1].AddLink("");
        Shows.ShowItems[1].AddEpisode(1, " DIY", "Investigating the fun that can be had, at other people's expense, through DIY.");
        Shows.ShowItems[1].AddEpisode(2, " Travel", "Investigating the fun that can be had, at other people's expense, through travel.");
        Shows.ShowItems[1].AddEpisode(3, " Children", "Investigating the fun that can be had, at other people's expense, through the gift of children.");
        Shows.ShowItems[1].AddEpisode(4, " Weekends", "Investigating the fun that can be had by spoiling other peoples' weekend.");
    }
}
