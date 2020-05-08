using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int i;

            int n = 15;

            Console.WriteLine("Here are the Fibonacci Numbers: ");
            Console.Write(num1 + " " + num2 + " ");

            for (i = 2; i < n; i++)
            {
                int num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
