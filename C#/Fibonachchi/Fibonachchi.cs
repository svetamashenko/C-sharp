using System;

namespace Fibonachchi
{
    class Program
    {
        public static int Fib(int arg)
        {
            int i = 3, frst = 1, scnd = 1, fibonachchi = 0;
            while (i <= arg)
            {
                fibonachchi = frst + scnd;
                frst = scnd;
                scnd = fibonachchi;
                i++;
            }
            return fibonachchi;
        }
        static void Main()
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fibonachchi;
            fibonachchi = n == 0 ? 0 : (n == 1 ? 1 : (n > 1 ? Fib(n) : -1));
            if (fibonachchi > 0)
                Console.WriteLine(fibonachchi);
            else
                Console.WriteLine("Error");
        }
    }
}
