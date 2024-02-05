namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputChar = char.Parse(Console.ReadLine());

            if (inputChar >= 64 && inputChar <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
