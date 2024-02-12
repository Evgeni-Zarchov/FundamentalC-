namespace WaterOverFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int lines = int.Parse(Console.ReadLine());

            const int MAX_CAPACITY = 255;

            int totalQuantity = MAX_CAPACITY;

            for (int i = 0; i < lines; i++)
            {
                int currQuantity = int.Parse(Console.ReadLine());

                if (totalQuantity - currQuantity >= 0)
                {
                    totalQuantity -= currQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            int finalQuantity = MAX_CAPACITY - totalQuantity;

            Console.WriteLine(finalQuantity);
        }
    }
}
