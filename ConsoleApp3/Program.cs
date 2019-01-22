using System;

namespace ConsoleApp3
{
    class Program //program 4
    {
        static void Main(string[] args)
        {
            int i, val, sum = 0;
            int t = 1;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series :\n");
            Console.Write("\n\n");
            Console.Write("Input from user:");
            val = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= val; i++)
            {
                Console.Write("{0} + ", t);
                sum = sum + t;
                t = (t) + 1;
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
            Console.ReadLine();
        }
    }
}
