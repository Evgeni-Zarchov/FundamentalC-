using System.Security.Cryptography.X509Certificates;

namespace SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            SignNumbers(numbers);
        }

        static void SignNumbers(int numbers)
        {
            if (numbers > 0 )
            {
                Console.WriteLine($"The number {numbers} is positive.");
            }
            else if (numbers < 0 )
            {
                Console.WriteLine($"The number {numbers} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {numbers} is zero.");
            }
        }
    
    }
}
