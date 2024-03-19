namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var partyList = new List<string>();
            for (int i = 0; i < counter; i++)
            {
                var command = Console.ReadLine().Split();

                string name = command[0];

                if (command.Length == 3)
                {
                    if (partyList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(name);
                    }
                }
                else if (command.Length == 4)
                {
                    if (!partyList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        partyList.Remove(name);
                    }
                }
            }

            foreach (string name in partyList)
            {
                Console.WriteLine(name);
            }
        }
    }
}

