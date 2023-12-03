using Day2.Models;

namespace Day2.Services
{
    public class GameService
    {
        // Bereken de som van de ID's van de mogelijke spellen, gegeven de limieten van de kubussen.
        public int CalculateSumOfPossibleGameIds(List<Game> games, Dictionary<string, int> cubeLimits)
        {
            int sum = 0;
            foreach (var game in games)
            {
                if (IsGamePossible(game, cubeLimits))
                {
                    sum += game.Id;
                }
            }
            return sum;
        }

        // Bepaalt of een spel mogelijk is op basis van de maximale kubuslimieten.
        private bool IsGamePossible(Game game, Dictionary<string, int> cubeLimits)
        {
            var maxCubesShown = new Dictionary<string, int> { { "red", 0 }, { "green", 0 }, { "blue", 0 } };

            foreach (var reveal in game.Reveals)
            {
                if (maxCubesShown[reveal.Color] < reveal.Count)
                {
                    maxCubesShown[reveal.Color] = reveal.Count;
                }
            }

            return maxCubesShown.All(mc => mc.Value <= cubeLimits[mc.Key]);
        }
    }
}
