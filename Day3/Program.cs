using Day3.DataAccess;
using Day3.EngineLogic;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\gijsd\source\repos\AdventOfCode2023\Day3\Data\day3data.txt";
            var fileReader = new FileReader();
            var lines = fileReader.ReadAllLines(filePath);

            var schematicProcessor = new SchematicProcessor();
            var result = schematicProcessor.ProcessSchematic(lines);

            Console.WriteLine(result);
        }
    }
}