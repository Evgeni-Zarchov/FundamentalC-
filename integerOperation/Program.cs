using Microsoft.VisualBasic;

namespace integerOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());
            int multiply = int.Parse(Console.ReadLine());

            int finalSum = (firstNum + secondNum) / divider * multiply;

            Console.WriteLine(finalSum);
        }
    }
}
