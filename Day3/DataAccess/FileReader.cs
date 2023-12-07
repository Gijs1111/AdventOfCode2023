namespace Day3.DataAccess
{
    public class FileReader
    {
        public string[] ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
