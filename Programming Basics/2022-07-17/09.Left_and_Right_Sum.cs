using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    sum1 += input;
                }
                else
                {
                    sum2 += input;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}

