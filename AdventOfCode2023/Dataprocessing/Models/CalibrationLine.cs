namespace AdventOfCode2023.Dataprocessing.Models
{
    public class CalibrationLine
    {
        public string RawLine { get; private set; }

        public CalibrationLine(string line)
        {
            RawLine = line;
        }
    }
}
