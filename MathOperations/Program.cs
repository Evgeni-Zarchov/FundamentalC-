using System.Transactions;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double lastNum = double.Parse(Console.ReadLine());

            double result = Calculations(firstNum, @operator, lastNum);
            Console.WriteLine(result );
        }

        static double Calculations(double firstNum, string @operator, double lastNum)
        {
            double sum = 0;

            switch (@operator)
            {
                case "/":
                    sum = firstNum / lastNum;
                    break;
                case "*":
                    sum = firstNum * lastNum;
                    break;
                case "+":
                    sum = firstNum + lastNum;
                    break;
                case "-":
                    sum = firstNum - lastNum;
                    break;
            }

            return sum;
        }
    }
}
