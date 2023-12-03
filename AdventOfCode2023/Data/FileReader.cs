namespace AdventOfCode2023.Data
{
    public class FileReader
    {
        // Leest alle regels uit een tekstbestand en retourneert ze als een lijst van strings.
        public IEnumerable<string> ReadLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
