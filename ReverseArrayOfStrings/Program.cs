namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length / 2; i++)
            {
                string firstElements = input[i];

                string lastElement = input[(input.Length - 1) - i];

                string tempElements = firstElements;

                input[i] = lastElement;
                input[(input.Length - 1) - i] = tempElements;
            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
