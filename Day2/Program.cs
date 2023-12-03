namespace Day2
{
    internal class Program
    {
        static void Main()
        {
            var games = new List<Game>
        {
            new Game { Id = 1, Reveals = new List<Reveal> { new Reveal("blue", 3), new Reveal("red", 4), new Reveal("red", 1), new Reveal("green", 2), new Reveal("blue", 6), new Reveal("green", 2) } },
            new Game { Id = 2, Reveals = new List<Reveal> { new Reveal("blue", 1), new Reveal("green", 2), new Reveal("green", 3), new Reveal("blue", 4), new Reveal("red", 1), new Reveal("green", 1), new Reveal("blue", 1) } },
            new Game { Id = 3, Reveals = new List<Reveal> { new Reveal("green", 8), new Reveal("blue", 6), new Reveal("red", 20), new Reveal("blue", 5), new Reveal("red", 4), new Reveal("green", 13), new Reveal("green", 5), new Reveal("red", 1) } },
            new Game { Id = 4, Reveals = new List<Reveal> { new Reveal("green", 1), new Reveal("red", 3), new Reveal("blue", 6), new Reveal("green", 3), new Reveal("red", 6), new Reveal("green", 3), new Reveal("blue", 15), new Reveal("red", 14) } },
            new Game { Id = 5, Reveals = new List<Reveal> { new Reveal("red", 6), new Reveal("blue", 1), new Reveal("green", 3), new Reveal("blue", 2), new Reveal("red", 1), new Reveal("green", 2) } }
        };

            var cubeLimits = new Dictionary<string, int> { { "red", 12 }, { "green", 13 }, { "blue", 14 } };
            var sumOfPossibleGameIds = CalculateSumOfPossibleGameIds(games, cubeLimits);

            Console.WriteLine($"Sum of IDs of possible games: {sumOfPossibleGameIds}");
        }

        static int CalculateSumOfPossibleGameIds(List<Game> games, Dictionary<string, int> cubeLimits)
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

        static bool IsGamePossible(Game game, Dictionary<string, int> cubeLimits)
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

    class Game
    {
        public int Id { get; set; }
        public List<Reveal> Reveals { get; set; }
    }

    class Reveal
    {
        public string Color { get; }
        public int Count { get; }

        public Reveal(string color, int count)
        {
            Color = color;
            Count = count;
        }
    }
}