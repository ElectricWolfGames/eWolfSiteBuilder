using System;

namespace TextConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string raw = "Grant D. Raskovich - Lee Patterson\r\nEli Raskovich - Carol Boyd\r\nGerry Lancoln Jr. - Peter Marinker\r\nThe Brigadier - Alan Cuthbertson\r\nThe Minister - Donald Hewlett\r\nThe President - Chris Barrie\r\nCIA Chief - Paul Maxwell\r\nCIA Operative - Sean Prendergast\r\nBomber Pilot - David Lerner\r\nCardinal Cross - David March\r\nThe Archbishop - David Desouza\r\nCindy - Annabelle Lanyon\r\nAirforce Chief - Garrard Green\r\nMafia Godfather - Gordon Reid\r\nMafia Thug - David Lerner\r\nCopper 1 - Sean Prendergast\r\nCopper 2 - John Church\r\nWaiter - John Church\r\nSimpson - Andrew Branch\r\nGlaswegian - Jeremy Roberts\r\nTV Producer - Ronald Herdman\r\nTV Announcer - Jeremy Roberts\r\nTV Secretary - Gordon Reid";

            NamesRoleName(raw);
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

                // Casts.Add("Curtis Lark", "Vincent Price");
                Console.WriteLine($"Casts.Add(\"{parts[0].Trim()}\" , \"{parts[1].Trim()}\");");

            }
        }
    }
}