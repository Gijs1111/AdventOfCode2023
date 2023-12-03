using AdventOfCode2023.Dataprocessing.Models;

namespace AdventOfCode2023.Dataprocessing.Utilities
{
    public class FileReaderUtility
    {
        public IEnumerable<CalibrationLine> ReadLines(string filePath)
        {
            foreach (var line in File.ReadAllLines(filePath))
            {
                yield return new CalibrationLine(line);
            }
        }
    }

}
