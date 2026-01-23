using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live
{
    public class Relocation : AudioBaseDetails
    {
        public Relocation()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Relocation";
            Year = 2019;
            DateAdded = "2025/08/08";
            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\22 Relocation\\";

            Description = "Comedy about a couple in witness relocation in the Welsh Valleys";

            Casts.Add("John", "Clint Edwards");
            Casts.Add("Sarah", "Helen Monks");
            Casts.Add("Ioan", "Vern Griffiths");
            Casts.Add("Officer", "Robin Morgan");
            Casts.Add("Officer 'D' (Series 2)", "Steve Speirs");
            Casts.Add("Ensemble Actor", "Beth Granville");
            Casts.Add("Ensemble Actor (Series 2)", "Catrin Stewart");

            Production.Add("WRITER", "Robin Morgan");
            Production.Add("PRODUCER", "Rhys Waters");
            Production.Add("SOUND DESIGNER", "");
            Production.Add("DIRECTOR", "Robin Morgan");

            Shows.Add("Series  1");
            Shows.ShowItems[0].AddLink("KMxKzf_cie4");
            Shows.ShowItems[0].AddEpisode(1, "Episode One", "John and Sarah's life is turned upside down. As they're forced into a witness protection scheme, they wave goodbye to their life in London, change their names and embrace the charm of a Welsh town with a name they struggle to pronounce.");
            Shows.ShowItems[0].AddEpisode(2, "Episode Two", "John and Sarah adjust to a new life as Brian and Helen in Hirwaun, but robot babies and their neighbour knowing they are in witness protection start to complicate things.");
            Shows.ShowItems[0].AddEpisode(3, "Episode Three", "John and Sarah's motormouth neighbour Ioan now knows pretty much everything about them, and John faces some unwanted national attention.");
            Shows.ShowItems[0].AddEpisode(4, "Episode Four", "John finds out Ioan had been searching for the man he helped send to prison, and things take an unexpected and thoroughly unwelcome turn.");

            Shows.Add("Series  2");
            Shows.ShowItems[1].AddLink("Y-2YGqm3wps");
            Shows.ShowItems[1].AddEpisode(1, "Episode One", "John and Sarah face yet another spell in witness protection. If being new parents wasn't enough, now they're relocating to the hometown of the officer in charge of their safety.");
            Shows.ShowItems[1].AddEpisode(2, "Episode Two", "Sarah takes on an undercover mission to find the criminal her and husband John are hiding from. Meanwhile, John makes a surprising discovery about the leader of his baby class.");
            Shows.ShowItems[1].AddEpisode(3, "Episode Three", "It's Christmas, but living under a witness protection scheme means John and Sarah don't feel very festive, while Ioan receives the job offer of a lifetime. Toby forms a new team to hunt down murderer Darren Bayes, John experiences a case of mistaken identity at the baby class, and Sarah is invited to an incredibly dangerous dinner party.");
            Shows.ShowItems[1].AddEpisode(4, "Episode Four", "Things reach peak calamity in the world of witness protection.");
        }
    }
}