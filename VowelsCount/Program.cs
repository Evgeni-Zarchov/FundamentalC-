namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Vowels(input));
        }

        static int Vowels(string input)
        {
            int counter = 0;

            foreach (var words in input)
            {
                if (isVowels(words))
                {
                    counter++;
                }
            }

            return counter;
        }

        static bool isVowels(char character)
        {
            return "aeiouAEIOU".IndexOf(character) >= 0;
        }
    }
}
