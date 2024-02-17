namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int moves = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < moves; rotation++)
            {
                int tempElement = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = tempElement;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
