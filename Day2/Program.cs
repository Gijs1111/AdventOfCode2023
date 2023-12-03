using Day2.DataAccess;
using Day2.Models;
using Day2.Services;

namespace Day2
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\gijsd\source\repos\AdventOfCode2023\Day2\Data\GameData.txt";
            List<Game> games = GameFileReader.ReadGamesFromFile(filePath);

            var gameService = new GameService();
            var sumOfPowers = gameService.CalculateSumOfPowers(games);

            Console.WriteLine($"Sum of powers of minimum sets of cubes: {sumOfPowers}");
        }
    }
}