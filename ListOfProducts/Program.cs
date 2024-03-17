namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            int nTimes = int.Parse(Console.ReadLine());

            for (int i = 0; i < nTimes; i++)
            {
                string currProducts = Console.ReadLine();
                products.Add(currProducts);
            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

        }
    }
}
