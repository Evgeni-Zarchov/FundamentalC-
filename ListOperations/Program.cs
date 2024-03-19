using System;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":

                        int index = int.Parse(command[2]);

                        if (index <= numbers.Count - 1 && index >= 0)
                        {
                            int numberToInsert = int.Parse(command[1]);
                            numbers.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }


                        break;
                    case "Remove":

                        int idx = int.Parse(command[1]);

                        if (idx <= numbers.Count - 1 && idx >= 0)
                        {
                            numbers.RemoveAt(idx);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        int counter = int.Parse(command[2]);

                        if (command[1] == "left")
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < counter; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
