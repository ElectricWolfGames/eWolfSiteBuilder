using eWolfAudioSiteBuilder.Data;

namespace eWolfAudioSiteBuilder._SiteDetails.Shows.Comedy
{
    public class Ansgstrom : AudioBaseDetails
    {
        public Ansgstrom()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Ansgstrom";
            Year = 2018;
            DateAdded = "2025/03/07";

            Description = "Knut Angström is a brooding, alcoholic, maverick Swedish detective from the tough streets of Oslo. Following the death of his wife, he is posted to the Njalsland peninsula where he becomes embroiled in a labyrinthine murder (or possibly not-murder) case that bears an eerie similarity to the Askeladden killings - a case from his distant past.";

            Casts.Add("Knut Ångström", "Matthew Holness");
            Casts.Add("Nina Oblong", "Nadia Kamil");
            Casts.Add("", "Morgana Robinson");
            Casts.Add("", "David Reed");
            Casts.Add("", "Freya Parker");
            Casts.Add("", "Kevin Eldon");
            Casts.Add("", "Simon Kane");

            Production.Add("WRITER", "Jason Hazeley");
            Production.Add("WRITER", "Joel Morris");
            Production.Add("PRODUCER", "Lyndsay Fenner");
            Production.Add("DIRECTOR", "");

            Shows.Add("Series  1");
            Shows.Shows[0].AddLink("SW39Lf435rI");
            Shows.Shows[0].AddEpisode(1, "The Man Who Wasn't Dead", "A body goes missing from a crime scene. But was it ever even there in the first place?");
            Shows.Shows[0].AddEpisode(2, "The Two Faces of Benny from Abba", "Angstrom and Mina try to find out who tried to frame him for the death of Councillor Birgid Lundstrom, a trail which leads them straight to the door of Benny from ABBA. But when that door opens, why is Benny from ABBA now Mexican?");
            Shows.Shows[0].AddEpisode(3, "Into the Mad Mind of Madness", "A clue left by the killer leads Angström and Mina to the Schmilsson novelty troll factory, where Angstrom's brooding threatens to get out of control.");
            Shows.Shows[0].AddEpisode(4, "The Hunter Is The Hunted And The Hunter", "The investigation takes Angstrom and Mina to the remote Celibate Puffin Island (but it's all one word in Swedish) where they find a possible connection between the Askeladden murders and the sinister Bolax Corporation, bringing them closer to finally discovering the identity of the mysterious Ash Lad..");
        }
    }
}