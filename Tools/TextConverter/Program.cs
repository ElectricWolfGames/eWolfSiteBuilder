using System;

namespace TextConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string raw = "Kate Brown …. Amanda Root\r\nProfessor Slingsby …. Geoffrey Whitehead\r\nJoe Barnard …. Jon Strickland\r\nReporter …. Elizabeth Conboy\r\nPrime Minister …. Chris Tranchell\r\nMinister of Defence …. Ian Masters\r\nMajor Peters …. Brett Usher\r\nDanny Flowers …. Stuart Milligan\r\nLab Technician …. Harry Myers\r\nMinister of Health …. Sandra Clark";

            Names(raw);
        }

        private static void Names(string raw)
        {
            string[] lines = raw.Split('\n');

            foreach (string line in lines)
            {
                var updated= line.Replace("\r", "");
                string[] parts = updated.Split("….");

                // Casts.Add("Curtis Lark", "Vincent Price");
                Console.WriteLine($"Casts.Add(\"{parts[0].Trim()}\" , \"{parts[1].Trim()}\");");

            }
        }
    }
}