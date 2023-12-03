using Day2.Models;

namespace Day2.Services
{
    public class GameService
    {
        // Calculate the sum of the powers of the minimum sets of cubes required for each game.
        public int CalculateSumOfPowers(List<Game> games)
        {
            int totalPower = 0;
            foreach (var game in games)
            {
                var minSet = FindMinimumSetOfCubes(game);
                int power = minSet["red"] * minSet["green"] * minSet["blue"];
                totalPower += power;
            }
            return totalPower;
        }

        // Find the minimum set of cubes required for a game.
        private Dictionary<string, int> FindMinimumSetOfCubes(Game game)
        {
            var minCubes = new Dictionary<string, int> { { "red", 0 }, { "green", 0 }, { "blue", 0 } };

            foreach (var reveal in game.Reveals)
            {
                if (minCubes[reveal.Color] < reveal.Count)
                {
                    minCubes[reveal.Color] = reveal.Count;
                }
            }

            return minCubes;
        }
    }
}
