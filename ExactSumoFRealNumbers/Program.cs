namespace ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= number; i++)
            {
                decimal currentSum = decimal.Parse(Console.ReadLine());

                sum += currentSum;
            }
            Console.WriteLine(sum);
        }
    }
}
