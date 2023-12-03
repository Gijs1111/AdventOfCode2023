using Day2.DataAccess;
using Day2.Models;
using Day2.Services;
using System.Text.RegularExpressions;

namespace Day2
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\gijsd\source\repos\AdventOfCode2023\Day2\Data\GameData.txt";
            List<Game> games = GameFileReader.ReadGamesFromFile(filePath);

            var cubeLimits = new Dictionary<string, int> { { "red", 12 }, { "green", 13 }, { "blue", 14 } };
            var gameService = new GameService();
            var sumOfPossibleGameIds = gameService.CalculateSumOfPossibleGameIds(games, cubeLimits);

            Console.WriteLine($"Sum of IDs of possible games: {sumOfPossibleGameIds}");
        }
    }
}