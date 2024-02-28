using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace GreaterOfTwoValue
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstNum, secondNum));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar,secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString,secondString));
                    break;
            }

        }

        static int GetMax(int firstValue, int secondVlue)
        {
            if (firstValue > secondVlue)
            {
                return firstValue;
            }

            return secondVlue;
        }

        static char GetMax(char firstValue, char secondVlue)
        {
            if (firstValue > secondVlue)
            {
                return firstValue;
            }

            return secondVlue;
        }

        static string GetMax(string firstValue, string secondVlue)
        {
            int result = firstValue.CompareTo(secondVlue);
            if (result > 0)
            {
                return firstValue;
            }

            return secondVlue;
        }
    }
}
