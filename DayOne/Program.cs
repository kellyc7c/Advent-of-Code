using System;
using System.IO;
using System.Reflection;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ModuleMasses.txt");
            string[] files = File.ReadAllLines(path);

            int total = 0;

            foreach (var line in files)
            {
                var wasParsed = Int32.TryParse(line, out var mass);

                if (wasParsed) total += FuelCalculator.CalculateAllFuelRequiredFromMass(mass);
            }

            Console.WriteLine(total);
        }
    }
}
