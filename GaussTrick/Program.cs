namespace GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> gaussNum = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int nums = numbers[i] + numbers[numbers.Count - 1 - i];
                gaussNum.Add(nums);
            }


            if (numbers.Count % 2 != 0)
            {
                gaussNum.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", gaussNum));
        }
    }
}
