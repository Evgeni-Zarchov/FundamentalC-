namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersAsString = Console.ReadLine().Split("|").Reverse()
                .ToList();

            var numbers = new List<int>();
            foreach (var number in numbersAsString)
            {
                numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
