namespace DemoExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNum, secondNum, thirdNum);
        }
        static void PrintSmallestNumber(int first, int second, int last)
        {
            if (first <= second && first <= last)
            {
                Console.WriteLine(first);
            }
            else if (second <= first && second <= last)
            {
                Console.WriteLine(second);
            }
            else if (last <= second && last <= first)
            {
                Console.WriteLine(last);
            }
        }
    }
}
