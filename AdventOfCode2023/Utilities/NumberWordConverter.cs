namespace AdventOfCode2023.Utilities
{
    public class NumberWordConverter
    {
        // Woordenboek om getalwoorden te koppelen aan hun numerieke waarde.
        public Dictionary<string, int> NumberWords { get; } = new Dictionary<string, int>
        {
            {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
            {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
        };

        // Converteert een getalwoord of cijfer in stringvorm naar een integer.
        public int ConvertToNumber(string wordOrDigit)
        {
            return NumberWords.ContainsKey(wordOrDigit) ? NumberWords[wordOrDigit] : int.Parse(wordOrDigit);
        }
    }
}
