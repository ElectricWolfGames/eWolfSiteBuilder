using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy;

// Dry Slopes
public class TheMisadventuresOfAngusDry : AudioBaseDetails
{
    public TheMisadventuresOfAngusDry()
    {
        ShowTypes = eWolfAudioShows.Data.Enums.ShowTypes.Comedy;

        Title = "The Misadventures Of Angus Dry [Dry Slopes]";
        Year = 1995;
        DateAdded = "2026/03/13";
        OutputPath = "E:\\_AudioTemp\\Comedy\\2026- Uploading\\034 The Misadventures Of Angus Dry\\";

        Description = "Angus Dry has no friends, no job and still lives at home with his mum. But he's quite happy to spend his time taking bubble baths, splashing his dole money on a motorised water laser and recapturing the joys of childhood. His busy mother has an international career as an arms dealer and a string of lovers. He feels terribly sorry for her.";

        Casts.Add("Angus Dry", "Nick Ball");
        Casts.Add("Mum", "Louisa Rix");

        Production.Add("WRITER", "Nick Ball");
        Production.Add("WRITER", "");
        Production.Add("PRODUCER", "Gareth Edwards");
        Production.Add("DIRECTOR", "");

        Shows.Add("Series  1");
        Shows.ShowItems[0].AddLink("5tipSDaNVWw");
        Shows.ShowItems[0].AddEpisode(1, "Episodes 1", "The Lost Boys");
        Shows.ShowItems[0].AddEpisode(2, "Episodes 2", "The Day of Judgement");
        Shows.ShowItems[0].AddEpisode(3, "Episodes 3", "Families and How to Conceive Them");
        Shows.ShowItems[0].AddEpisode(4, "Episodes 4", "Dry Wit");

        Shows.Add("Series  2");
        Shows.ShowItems[1].AddLink("WsMWI2i7KMU");
        Shows.ShowItems[1].AddEpisode(1, "Episodes 1", "Emma");
        Shows.ShowItems[1].AddEpisode(2, "Episodes 2", "Tick Tock");
        Shows.ShowItems[1].AddEpisode(3, "Episodes 3", "The Domino Effect");
        Shows.ShowItems[1].AddEpisode(4, "Episodes 4", "The Invisible Man");
    }
}