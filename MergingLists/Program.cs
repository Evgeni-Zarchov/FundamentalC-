namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int maxCount = Math.Max(list1.Count, list2.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (list1.Count > i)
                {
                    result.Add(list1[i]);
                }

                if (list2.Count > i)
                {
                    result.Add(list2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
