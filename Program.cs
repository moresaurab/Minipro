using System;

namespace Minipro
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, fact = 1, n;
            Console.Write("Enter any number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write("factorial of   " + n + "  is  " + fact);

        }
    }
}
