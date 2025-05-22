using System;

namespace TextConverter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string raw = "Primus ...... Michael Cochrane\r\nCordelia ...... Maggie Steed\r\nGerald ...... David Horovitch\r\nEdith ...... Elizabeth Spriggs\r\nReverend Brontë / Prosser ...... Geoffrey Whitehead\r\nCharlotte Brontë ...... Sarah Jane Holm\r\nMrs Gaskell / Emily Brontë / Katie Joiner / Mrs Prosser ...... Frances Jeater\r\nEquity / Waiter / George Eliot / Thackeray ...... David Antrobus\r\nRichard Burton ...... Norman Rodway\r\nWilkie Collins ...... David Timson\r\nSimeon ...... Charles Simpson\r\nPrince Albert / Smiles / Trollope ...... Ioan Meredith\r\nJohn / Rossetti / Cab driver ...... Stephen Critchlow\r\nMrs Quirk ...... Joan Sims\r\nLizzie Siddal ...... Becky Hindley\r\nMrs Beeton ...... Rachel Atkins\r\nBeeton ...... Gerard McDermott";

            Names(raw);
        }

        private static void Names(string raw)
        {
            string[] lines = raw.Split('\n');

            foreach (string line in lines)
            {
                var updated = line.Replace("\r", "");
                //string[] parts = updated.Split("….");
                string[] parts = updated.Split("....");
                if (parts.Length > 1)
                    // Casts.Add("Curtis Lark", "Vincent Price");
                    Console.WriteLine($"Casts.Add(\"{parts[0].Trim()}\" , \"{parts[1].Trim()}\");");
            }
        }

        private static void NamesRoleName(string raw)
        {
            string[] lines = raw.Split('\n');

            foreach (string line in lines)
            {
                var updated = line.Replace("\r", "");
                string[] parts = updated.Split(" - ");

                // Casts.Add("Curtis Lark", "Vincent Price");
                Console.WriteLine($"Casts.Add(\"{parts[0].Trim()}\" , \"{parts[1].Trim()}\");");
            }
        }
    }
}