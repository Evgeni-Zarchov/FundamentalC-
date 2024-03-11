﻿namespace SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3, 3, 6, 1 => 6, 1 final output => 12,1

            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
