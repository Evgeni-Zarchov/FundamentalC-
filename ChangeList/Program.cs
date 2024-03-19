namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();

                string action = input[0];

                if (action == "Delete")
                {
                    int elementsToDelete = int.Parse(input[1]);
                    numbers.RemoveAll(el => el == elementsToDelete);
                }
                else if (action == "Insert")
                {
                    int numberToInsert = int.Parse(input[1]);
                    int idx = int.Parse(input[2]);
                    numbers.Insert(idx, numberToInsert);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
