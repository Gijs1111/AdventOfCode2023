using AdventOfCode2023.Dataprocessing.Models;
using System.Text.RegularExpressions;

namespace AdventOfCode2023.Dataprocessing.Services
{
    public class CalibrationExtractorService
    {
        private readonly Dictionary<string, string> _numberWords = new Dictionary<string, string>
        {
            { "one", "1" }, { "two", "2" }, { "three", "3" }, { "four", "4" }, { "five", "5" },
            { "six", "6" }, { "seven", "7" }, { "eight", "8" }, { "nine", "9" }
        };

        public int ExtractCalibrationValue(CalibrationLine line)
        {
            string numericLine = ConvertWordsToDigits(line.RawLine);
            var matches = Regex.Matches(numericLine, @"\d");

            if (matches.Count > 0)
            {
                string firstDigit = matches.First().Value;
                string lastDigit = matches.Last().Value;
                return int.Parse(firstDigit + lastDigit);
            }

            return 0;
        }

        private string ConvertWordsToDigits(string line)
        {
            foreach (var pair in _numberWords)
            {
                line = Regex.Replace(line, pair.Key, pair.Value);
            }
            return line;
        }
    }
}
