using System;

namespace TextConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string raw = "Charles …. Donald Hewlett\r\nGeorge …. Michael Knowles\r\nHilary …. Norma Ronald\r\nGJ …. Tony Anholt\r\nFuturistic Manager …. David Ryall\r\nBilly …. Michael Bilton\r\nHarry the Publican …. Colin Starkey";

            Names(raw);
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
        private static void Names(string raw)
        {
            string[] lines = raw.Split('\n');

            foreach (string line in lines)
            {
                var updated = line.Replace("\r", "");
                string[] parts = updated.Split("…."); 
                //string[] parts = updated.Split("....");

                // Casts.Add("Curtis Lark", "Vincent Price");
                Console.WriteLine($"Casts.Add(\"{parts[0].Trim()}\" , \"{parts[1].Trim()}\");");

            }
        }
    }
}