using System.Diagnostics;

namespace Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modify the program from the previous problem, so it will print "Failed!", if the grade is lower than 3.00.

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
