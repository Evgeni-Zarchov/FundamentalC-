namespace RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            double[] numbers = new double[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = double.Parse(values[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
