using System.Text.RegularExpressions;
using Day3.Utilities;

namespace Day3.EngineLogic
{
    public class SchematicProcessor
    {
        public int ProcessSchematic(string[] lines)
        {
            var numberRegex = new RegexUtilities().GetNumberMatches;
            int result = 0;

            for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {
                string lineAbove = lineIndex > 0 ? lines[lineIndex - 1] : null;
                string lineBelow = lineIndex < lines.Length - 1 ? lines[lineIndex + 1] : null;
                string line = lines[lineIndex];

                foreach (Match match in numberRegex(line))
                {
                    int number = int.Parse(match.Value);
                    int startIndex = match.Index;
                    int endIndex = match.Index + match.Length - 1;

                    if (lineAbove != null && CheckIfSymbolIsAroundNumber(lineAbove, startIndex, endIndex) ||
                        lineBelow != null && CheckIfSymbolIsAroundNumber(lineBelow, startIndex, endIndex) ||
                        CheckIfSymbolIsAroundNumber(line, startIndex, endIndex))
                    {
                        result += number;
                    }
                }
            }

            return result;
        }

        private bool CheckIfSymbolIsAroundNumber(string line, int startIndex, int endIndex)
        {
            var symbolRegex = new RegexUtilities().GetSymbolMatches;

            foreach (Match symbolMatch in symbolRegex(line))
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
