using System;
using System.Text;

namespace life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class GameParameters
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public string State { get; set; }
    }

    public class GameOfLife
    {
        public string NextState(GameParameters p)
        {
            return string.Empty;
        }
    }
}
