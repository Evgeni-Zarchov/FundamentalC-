namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                char temporary = firstChar;
                firstChar = secondChar;
                secondChar = temporary;
            }

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write("{0}", (char)i + " ");
            }
        }
    }
}
