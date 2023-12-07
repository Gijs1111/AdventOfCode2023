using System.Text.RegularExpressions;

namespace Day3.Utilities
{
    public class RegexUtilities
    {
        public MatchCollection GetNumberMatches(string input)
        {
            var numberRegex = new Regex(@"\d+");
            return numberRegex.Matches(input);
        }

        public MatchCollection GetSymbolMatches(string input)
        {
            var symbolRegex = new Regex(@"[^\d.]");
            return symbolRegex.Matches(input);
        }
    }
}
