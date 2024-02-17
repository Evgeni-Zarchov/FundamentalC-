namespace ZigZagArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that creates 2 arrays.You will be given an integer n.On the next n lines, you will get 2 integers.Form 2 new arrays in a zig-zag pattern as shown below.

            int lines = int.Parse(Console.ReadLine());
            int[] evenArr = new int[lines];
            int[] oddArr = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenArr[i] = currentNumbers[0];
                    oddArr[i] = currentNumbers[1];
                }
                else
                {
                    evenArr[i] = currentNumbers[1];
                    oddArr[i] = currentNumbers[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenArr));
            Console.WriteLine(String.Join(" ", oddArr));
        }
    }
}
