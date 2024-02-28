namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine(StringRepeater(words, counter));
        }

        static string StringRepeater(string words, int counter)
        {
            string text = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                text += words;
            }

            return text;
        }
    }
}
