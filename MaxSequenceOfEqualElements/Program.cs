using System.Linq;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] inputSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequence = 0;
            int currentElements = 1;
            int inputElement = 0;

            for (int i = 0; i < inputSequence.Length - 1; i++)
            {
                if (inputSequence[i] == inputSequence[i + 1])
                {

                    currentElements++;

                }
                else
                {
                    currentElements = 1;
                }

                if (currentElements > maxSequence)
                {
                    maxSequence = currentElements;
                    inputElement = inputSequence[i];
                }
            }

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(inputElement + " ");
            }


        }
    }
}
