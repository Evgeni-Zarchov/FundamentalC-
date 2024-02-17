namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            string[] firstArr = Console.ReadLine().Split(" ");
            string[] secondArr = Console.ReadLine().Split(" ");

            foreach (string currElement in firstArr)
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    string secondElement = secondArr[i];

                    if (secondElement == currElement)
                    {
                        Console.Write($"{secondElement} ");
                        break;
                    }
                }
            }
        }
    }
}
