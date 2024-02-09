namespace RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Im given a working code but i have to refactor it 
             //double dul, sh, V = 0;
            // the variable dul should become length;

            // Console.WriteLine("Length: ");

            // dul = double.Parse(Console.ReadLine());

            // Console.WriteLine("Width: ");

            // sh = double.Parse(Console.ReadLine())
            // sh should become width;

            // Console.WriteLine("Heigth: ");

            // V = double.Parse(Console.ReadLine());
            // V = (dul + sh + V) / 3;
            // Console.WriteLine($"Pyramid Volume: {V:f2}");

            // the formula is length * width * volume / 3;


            double length = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double height = double.Parse(Console.ReadLine());

            height = (length * width * height) / 3;

            Console.Write($"Pyramid Volume: {height:f2}");
            
        }
    }
}
