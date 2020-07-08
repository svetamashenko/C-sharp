using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetBufferSize(Console.LargestWindowHeight, Console.LargestWindowWidth); 
            Console.WriteLine("Wake up, Neo...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The Matrix has you...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Follow the white rabbit.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Knock, knock, Neo.");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
