namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;

            string kegName = "";

            for (int i = 0; i < lines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double currentKegValue = Math.PI * Math.Pow(radius, 2) * height;

                if (currentKegValue > biggestKeg)
                {
                    biggestKeg = currentKegValue;
                    kegName = model;
                }
            }
            Console.WriteLine(kegName);
        }
    }
}
