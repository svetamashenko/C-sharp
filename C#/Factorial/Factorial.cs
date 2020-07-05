using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <=n; i++){
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial = " + factorial);
        }
    }
}
