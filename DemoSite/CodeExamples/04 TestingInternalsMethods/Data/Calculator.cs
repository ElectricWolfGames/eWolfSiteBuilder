using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Code.UnitTest")]

namespace Code
{
    public class Calculator
    {
        public string ProcessCalculation(string line)
        {
            string[] parts = line.Split(new[] { '+', '-' });

            float valueA = float.Parse(parts[0]);
            float valueB = float.Parse(parts[1]);

            if (line.Contains('+'))
                return Add(valueA, valueB).ToString();

            if (line.Contains('-'))
                return Sub(valueA, valueB).ToString();

            return "ERROR:";
        }

        internal float Add(float a, float b)
        {
            return a + b;
        }

        internal float Sub(float a, float b)
        {
            return a - b;
        }
    }
}