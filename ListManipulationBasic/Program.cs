namespace ListManipulationBasic
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

            while (command != "end")
            {

                string[] currInfo = command.Split();

                if (currInfo[0] == "Add")
                {
                    int number = int.Parse(currInfo[1]);
                    numbersInList.Add(number);
                }
                else if (currInfo[0] == "Remove")
                {
                    int number = int.Parse(currInfo[1]);
                    numbersInList.Remove(number);
                }
                else if (currInfo[0] == "RemoveAt")
                {
                    int number = int.Parse(currInfo[1]);
                    numbersInList.RemoveAt(number);
                }
                else if (currInfo[0] == "Insert")
                {
                    int number = int.Parse(currInfo[1]);
                    int idx = int.Parse(currInfo[2]);

                    numbersInList.Insert(idx, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbersInList));
        }
    }
}
