using Day2.Models;
using System.Text.RegularExpressions;

namespace Day2.Utilities
{
    // Biedt hulpmiddelen voor het parsen van spelgerelateerde strings.
    public static class GameParser
    {
        // Parsen van een regel tekst en maakt een Game-object.
        public static Game ParseGameLine(string line)
        {
            var match = Regex.Match(line, @"Game (\d+): (.+)");
            if (!match.Success) return null;

            int id = int.Parse(match.Groups[1].Value);
            var reveals = match.Groups[2].Value.Split(';')
                .SelectMany(r => r.Trim().Split(',').Select(c => ParseReveal(c.Trim())))
                .ToList();

            return new Game { Id = id, Reveals = reveals };
        }

        // Parst de details van een reveal.
        private static Reveal ParseReveal(string reveal)
        {
            var parts = reveal.Split(' ');
            return new Reveal(parts[1], int.Parse(parts[0]));
        }
    }
}
