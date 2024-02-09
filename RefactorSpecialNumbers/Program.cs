namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            int currentSum = 0;

            bool isTrue = false;

            for (int i = 1; i <= input; i++)

            {

                currentSum = i;

                while (i > 0)

                {

                    sum += i % 10;

                    i = i / 10;

                }

                isTrue = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", currentSum, isTrue);

                sum = 0;

                i = currentSum;

            }
        }
    }
}
