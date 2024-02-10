namespace sumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                char digit = char.Parse(Console.ReadLine());

                sum += (int)digit;
            }
            
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
