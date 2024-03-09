using System;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command.StartsWith("exchange"))
                {
                    int index = int.Parse(command.Split().Last());
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    array = Exchange(array, index);
                }
                else if (command.StartsWith("max"))
                {
                    var condition = command.Split().Last();
                    MaxIndex(array, condition == "even");
                }
                else if (command.StartsWith("min"))
                {
                    var condition = command.Split().Last();
                    MinIndex(array, condition == "even");
                }
                else if (command.StartsWith("first"))
                {
                    string[] condition = command.Split();
                    int count = int.Parse(condition[1]);
                    FirstElements(array, count, condition.Last() == "even");
                }
                else if (command.StartsWith("last"))
                {
                    var condition = command.Split();
                    int count = int.Parse(condition[1]);
                    LastElements(array, count, condition.Last() == "even");
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        static int[] Exchange(int[] array, int index)
        {
            return array.Skip(index + 1).Take(array.Length - index)
                .Concat(array.Take(index + 1)).ToArray();
        }

        static void MaxIndex(int[] array, bool isEven)
        {
            if (!array.Any(number => isEven == (number % 2 == 0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int max = array.Where(number => isEven == (number % 2 == 0)).Max();
                Console.WriteLine(Array.LastIndexOf(array, max));
            }
        }

        static void MinIndex(int[] array, bool isEven)
        {
            if (!array.Any(number => isEven == (number % 2 == 0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = array.Where(number => isEven == (number % 2 == 0)).Min();
                Console.WriteLine(Array.LastIndexOf(array, min));
            }
        }

        static void FirstElements(int[] array, int count, bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(number => isEven == (number % 2 == 0)).Take(count).ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", result));
            }
        }

        static void LastElements(int[] array, int count, bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(number => isEven == (number % 2 == 0)).TakeLast(count).ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", result));
            }
        }
    }
}
