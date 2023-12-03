using AdventOfCode2023.Dataprocessing.Models;
using AdventOfCode2023.Dataprocessing.Services;
using AdventOfCode2023.Dataprocessing.Utilities;

namespace AdventOfCode2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\gijsd\\source\\repos\\AdventOfCode2023\\AdventOfCode2023\\Input\\input.txt";
            var fileReader = new FileReaderUtility();
            var extractor = new CalibrationExtractorService();

            var lines = fileReader.ReadLines(filePath);
            var totalSum = lines.Select(line => extractor.ExtractCalibrationValue(line)).Sum();

            Console.WriteLine($"Totale som van kalibratiewaarden: {totalSum}");
        }
    }
}