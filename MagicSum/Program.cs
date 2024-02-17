namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] magicSum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < magicSum.Length; i++)
            {
                for (int j = i + 1; j < magicSum.Length; j++)
                {
                    int currentSum = magicSum[i] + magicSum[j];

                    if (currentSum == number)
                    {
                        Console.WriteLine("{0} {1}", magicSum[i], magicSum[j]);
                    }
                }
            }
        }
    }
}
