namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                PartOfTriangle(1, i);
            }

            for (int i = number - 1; i >= 0; i--)
            {
                PartOfTriangle(1, i);
            }
        }

        static void PartOfTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
