namespace elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elevateN = int.Parse(Console.ReadLine());
            int capacityP = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)elevateN / capacityP);

            Console.WriteLine(courses);
        }
    }
}
