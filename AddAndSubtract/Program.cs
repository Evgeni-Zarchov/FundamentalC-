namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(firstInteger, secondInteger) - Substract(thirdInteger));
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }

        static int Substract(int last)
        {
            return last;
        }

    }
}
