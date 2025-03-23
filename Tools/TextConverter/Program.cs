using System;

namespace TextConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string raw = "Sid .... Warren Mitchell\r\nVal .... Kay Stonham\r\nIan .... Simon Greenall\r\nAda .... Avril Elgar\r\nMatthew .... Josh Freedman\r\nMolly .... Mollie Freedman\r\nGovernor .... Will Ing\r\nHeadmistress .... Annie Hulley";

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
                // string[] parts = updated.Split("…."); 
                string[] parts = updated.Split("....");

                // Casts.Add("Curtis Lark", "Vincent Price");
                Console.WriteLine($"Casts.Add(\"{parts[0].Trim()}\" , \"{parts[1].Trim()}\");");

            }
        }
    }
}