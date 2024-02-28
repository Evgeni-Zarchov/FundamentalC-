namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(firstNumber,power));
        }

        static double MathPower(double firstNumber, double power)
        {
            double sum = 1;

            for (int i = 1; i <= power; i++)
            {
                sum *= firstNumber;
            }
            return sum;
        }
    }
}
