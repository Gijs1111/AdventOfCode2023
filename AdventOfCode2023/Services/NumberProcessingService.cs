using AdventOfCode2023.Utilities;
using System.Text.RegularExpressions;

namespace AdventOfCode2023.Services
{
    public class NumberProcessingService
    {
        private readonly NumberWordConverter _converter;

        public NumberProcessingService()
        {
            _converter = new NumberWordConverter();
        }

        // Verwerkt een lijst van regels en berekent de totale som.
        public int ProcessLines(IEnumerable<string> lines)
        {
            return lines.Sum(line => ProcessLine(line));
        }

        // Verwerkt een enkele regel en berekent het resulterende getal.
        private int ProcessLine(string line)
        {
            // Patroon om getalwoorden en cijfers te herkennen in de tekst.
            string pattern = string.Join("|", _converter.NumberWords.Keys) + "|\\d";
            var matches = Regex.Matches(line, pattern).Select(m => m.Value).ToList();

            // Converteer de eerste en laatste match naar een string en voeg ze samen.
            string resultNumber = _converter.ConvertToNumber(matches.First()).ToString() +
                                  _converter.ConvertToNumber(matches.Last()).ToString();

            return int.Parse(resultNumber);
        }
    }
}
