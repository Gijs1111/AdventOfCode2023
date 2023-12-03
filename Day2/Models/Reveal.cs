namespace Day2.Models
{
    public class Reveal
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
