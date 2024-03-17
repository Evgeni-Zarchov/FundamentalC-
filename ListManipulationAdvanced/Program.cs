namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string command = Console.ReadLine();

            bool hadChange = false;

            while (command != "end")
            {

                string[] currInfo = command.Split();

                if (currInfo[0] == "Add")
                {
                    int number = int.Parse(currInfo[1]);
                    numbersInList.Add(number);
                    hadChange = true;
                }
                else if (currInfo[0] == "Remove")
                {
                    int number = int.Parse(currInfo[1]);
                    numbersInList.Remove(number);
                    hadChange = true;
                }
                else if (currInfo[0] == "RemoveAt")
                {
                    int number = int.Parse(currInfo[1]);
                    numbersInList.RemoveAt(number);
                    hadChange = true;
                }
                else if (currInfo[0] == "Insert")
                {
                    int number = int.Parse(currInfo[1]);
                    int idx = int.Parse(currInfo[2]);

                    numbersInList.Insert(idx, number);
                    hadChange = true;
                }
                else if (currInfo[0] == "Contains")
                {
                    int number = int.Parse(currInfo[1]);

                    if (numbersInList.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (currInfo[0] == "PrintEven")
                {
                    for (int i = 0; i < numbersInList.Count; i++)
                    {
                        if (numbersInList[i] % 2 == 0)
                        {
                            Console.Write(numbersInList[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (currInfo[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbersInList.Count; i++)
                    {
                        if (numbersInList[i] % 2 != 0)
                        {
                            Console.Write(numbersInList[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (currInfo[0] == "GetSum")
                {
                    int sum = 0;
                    foreach (int number in numbersInList)
                    {
                        sum += number;
                    }

                    Console.WriteLine(sum);
                }
                else if (currInfo[0] == "Filter")
                {
                    string condition = currInfo[1];
                    int number = int.Parse(currInfo[2]);

                    if (condition == "<")
                    {
                        foreach (var item in numbersInList)
                        {
                            if (item < number)
                            {
                                Console.Write(item + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (condition == ">")
                    {
                        foreach (var item in numbersInList)
                        {
                            if (item > number)
                            {
                                Console.Write(item + " ");
                            }

                        }

                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        foreach(var item in numbersInList)
                        {
                            if (item <= number)
                            {
                                Console.Write(item + " ");
                            }

                        }

                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        foreach (var item in numbersInList)
                        {
                            if (item >= number)
                            {
                                Console.Write(item + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            if (hadChange)
            {
                Console.WriteLine(string.Join(" ", numbersInList));
            }
           
        }
    }
}
