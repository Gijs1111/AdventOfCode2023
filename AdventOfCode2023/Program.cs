using AdventOfCode2023.Data;
using AdventOfCode2023.Services;

namespace AdventOfCode2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definieer het pad naar het inputbestand.
            var filePath = @"C:\Users\gijsd\source\repos\AdventOfCode2023\AdventOfCode2023\Input\input.txt";

            // Maak instanties van FileReader en NumberProcessingService.
            var fileReader = new FileReader();
            var processingService = new NumberProcessingService();

            // Lees de regels uit het bestand en verwerk deze.
            var lines = fileReader.ReadLines(filePath);
            int totalSum = processingService.ProcessLines(lines);

            // Print de totale som naar de console.
            Console.WriteLine($"Total Sum: {totalSum}");
        }
    }
}