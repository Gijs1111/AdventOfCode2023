using Day2.Models;
using Day2.Utilities;

namespace Day2.DataAccess
{
    // Verantwoordelijk voor het lezen van spelgegevens uit een bestand.
    public class GameFileReader
    {
        // Leest spelgegevens uit een bestand en geeft een lijst van games terug.
        public static List<Game> ReadGamesFromFile(string filePath)
        {
            var games = new List<Game>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var game = GameParser.ParseGameLine(line);
                if (game != null)
                {
                    games.Add(game);
                }
            }

            return games;
        }
    }
}
