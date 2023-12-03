using AdventOfCode2023.Dataprocessing.Models;
using System.Text.RegularExpressions;

namespace AdventOfCode2023.Dataprocessing.Services
{
    public class CalibrationExtractorService
    {
        public int ExtractCalibrationValue(CalibrationLine line)
        {
            var matches = Regex.Matches(line.RawLine, @"\d");
            if (matches.Count > 0)
            {
                string firstDigit = matches.First().Value;
                string lastDigit = matches.Last().Value;
                return int.Parse(firstDigit + lastDigit);
            }

            return 0;
        }
    }
}
