using eWolfAudioShows.Data;

namespace eWolfAudioShows.Shows.Comedy._Live
{
    public class Bookcases : AudioBaseDetails
    {
        public Bookcases()
        {
            ShowTypes = Data.Enums.ShowTypes.Comedy;

            Title = "Bookcases";
            Year = 1998;
            DateAdded = "2025/07/18";

            OutputPath = "E:\\_AudioTemp\\Comedy\\_Uploading_B\\17 Bookcases\\";

            Description = "London, 1853, and the sedate religious publishing house of Spavin and Spavin is about to experience a radical shake-up. Vivacious actress Cordelia is on the hunt for her next  husband and has her eye on Gerald, one of the firm's partners, while her son, Primus, has ambitions to take over the firm. And when he does, it'll be out with the Bibles and in with the best sellers - starting with Charlotte Brontë's latest blockbuster....";

            Casts.Add("Primus", "Michael Cochrane");
            Casts.Add("Cordelia", "Maggie Steed");
            Casts.Add("Gerald", "David Horovitch");
            Casts.Add("Edith", "Elizabeth Spriggs");
            Casts.Add("Reverend Brontë / Prosser", "Geoffrey Whitehead");
            Casts.Add("Charlotte Brontë", "Sarah Jane Holm");
            Casts.Add("Mrs Gaskell / Emily Brontë / Katie Joiner / Mrs Prosser", "Frances Jeater");
            Casts.Add("Equity / Waiter / George Eliot / Thackeray", "David Antrobus");
            Casts.Add("Richard Burton", "Norman Rodway");
            Casts.Add("Wilkie Collins", "David Timson");
            Casts.Add("Simeon", "Charles Simpson");
            Casts.Add("Prince Albert / Smiles / Trollope", "Ioan Meredith");
            Casts.Add("John / Rossetti / Cab driver", "Stephen Critchlow");
            Casts.Add("Mrs Quirk", "Joan Sims");
            Casts.Add("Lizzie Siddal", "Becky Hindley");
            Casts.Add("Mrs Beeton", "Rachel Atkins");
            Casts.Add("Beeton", "Gerard McDermott");

            Production.Add("WRITER", "Martyn Wade");
            Production.Add("WRITER", "");
            Production.Add("PRODUCER", "");
            Production.Add("DIRECTOR", "Cherry Cookson");

            Shows.Add("Series  1");
            Shows.ShowItems[0].AddLink("C70HuoX9zJg");
            Shows.ShowItems[0].AddEpisode(1, "Bronte Country", "London 1853, and a firm of religious publishers is transformed by an actress and her son.");
            Shows.ShowItems[0].AddEpisode(2, "Gone for a Burton", "1855 - Primus's latest publishing coup is an explorer, but he seems to have lost his way.");
            Shows.ShowItems[0].AddEpisode(3, "The Man in White", "Bored by Gerald, Cordelia is having fun with struggling novelist Wilkie Collins.");
            Shows.ShowItems[0].AddEpisode(4, "The Prosser Prize", "Primus does his utmost to ensure one of his books will win a literary award.");

            Shows.Add("Series  2");
            Shows.ShowItems[1].AddLink("mgM9IRx16x8");
            Shows.ShowItems[1].AddEpisode(1, "Self Help", "1860 London. Publishing sitcom with Maggie Steed and Elizabeth Spriggs.");
            Shows.ShowItems[1].AddEpisode(2, "Great Expectations", "Ailing Victorian publishers Spavin and Spavin hope Charles Dickens can save them.");
            Shows.ShowItems[1].AddEpisode(3, "Terminal Journals", "Primus plots to save the firm by publishing deathbed memoirs of the famous.");
            Shows.ShowItems[1].AddEpisode(4, "Merger Most Foul", "Edith’s refusal to let Primus publish her books sparks desperate merger talks.");
        }
    }
}