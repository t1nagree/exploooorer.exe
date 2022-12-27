using System.Numerics;
using System.Reflection.Metadata;

namespace fileexplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings();
            Explorer.Drives();
        }

        public static void Greetings()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine(Explorer.path);
            for (int i = 0; i < 120; i++) Console.Write("-");
            Console.WriteLine();
        }

    }

}