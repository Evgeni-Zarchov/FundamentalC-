using System.Threading.Channels;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result1 = FactorialDivision(firstNum);
            double result2 = FactorialDivision(secondNum);

            Console.WriteLine($"{result1 / result2:F2}");
        }

        static double FactorialDivision(int number)
        {
            double result = 1;

            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }

    }
}
