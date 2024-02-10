namespace sumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] sum = input.ToCharArray();
            int finalSum = 0;
            
            for (int value = 0; value < sum.Length; value++)
            {
                finalSum += int.Parse(sum[value].ToString());
            }
            Console.WriteLine(finalSum);
        }
    }
}
