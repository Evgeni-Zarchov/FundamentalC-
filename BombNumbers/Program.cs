
namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = command[0];
            int detonatePower = command[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];

                if (target == bomb)
                {
                    BombNumbers(numbers, detonatePower, i);
                }
            }

            Console.WriteLine(numbers.Sum());
        }

        private static void BombNumbers(List<int> numbers, int detonatePower, int index)
        {
            int start = Math.Max(0, index - detonatePower);
            int end = Math.Min(numbers.Count - 1, index + detonatePower);

            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
