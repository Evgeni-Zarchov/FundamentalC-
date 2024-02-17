namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;

                }

                for (int leftNum = i; leftNum > 0; leftNum--)
                {
                    int nextLeftNum = leftNum - 1;
                    
                    if (leftNum >0)
                    {
                        leftSum += numbers[nextLeftNum];
                    }
                }

                for (int j = i; j < numbers.Length; j++)
                {
                    int nextNum = j + 1;
                    if (j < numbers.Length - 1)
                    {
                        rightSum += numbers[nextNum];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
