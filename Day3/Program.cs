using System.Text.RegularExpressions;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\gijsd\source\repos\AdventOfCode2023\Day3\Data\day3data.txt";
            var numberRegex = new Regex(@"\d+");
            var lines = File.ReadAllLines(filePath);
            var result = 0;

            for (int lineIndexNumber = 0; lineIndexNumber < lines.Length; lineIndexNumber++)
            {
                string lineAbove = null;
                string lineBelow = null;
                string line = lines[lineIndexNumber];
                
                if (lineIndexNumber > 0)
                {
                    lineAbove = lines[lineIndexNumber - 1];
                }

                if (lineIndexNumber < lines.Length -1)
                {
                    lineBelow = lines[lineIndexNumber + 1];
                }

                foreach (Match match in numberRegex.Matches(line))
                {
                    /**
                     * De code in deze loop voert hij uit voor elk nummer dat gevonden wordt in een line.
                     */

                    int number = int.Parse(match.Value);
                    int startIndex = match.Index;
                    int endIndex = match.Index + (match.Length - 1);

                    /**
                     * Is er een regel boven de regel met het nummer?
                     */
                    if (lineAbove != null)
                    {
                        if (CheckIfSymbolIsAroundNumber(lineAbove, startIndex, endIndex))
                        {
                            result += number;
                            continue;
                        }
                    }

                    /**
                     * Is er een regel onder de regel met het nummer?
                     */
                    if (lineBelow != null)
                    {
                        if (CheckIfSymbolIsAroundNumber(lineBelow, startIndex, endIndex))
                        {
                            result += number;
                            continue;
                        }
                    }

                    /**
                     * Is er een symbool voor/achter het getal?
                     */
                    if (CheckIfSymbolIsAroundNumber(line, startIndex, endIndex))
                    {
                        result += number;
                    }
                }
            }

            Console.WriteLine(result);
        }
        private static bool CheckIfSymbolIsAroundNumber(string line, int startIndex, int endIndex)
        {
            /**
             * Op meegegeven line wordt er gezocht naar een symbool
             */
            var symbolRegex = new Regex(@"[^\d.]");

            foreach (Match symbolMatch in symbolRegex.Matches(line))
            {
                int symbolIndex = symbolMatch.Index;

                if (symbolIndex >= startIndex - 1 && symbolIndex <= endIndex + 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}