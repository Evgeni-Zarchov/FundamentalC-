using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue = true;

            if (!IsLengthValid(password))
            {
                isTrue = false;

                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!ContainsOnlyLetterAndDgiti(password))
            {
                isTrue = false;

                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsHaveTwoDigit(password))
            {
                isTrue = false;

                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsLengthValid(string password)
        {
            return password.Length is >= 6 and <= 10;
        }

        static bool ContainsOnlyLetterAndDgiti(string password)
        {
            return password.All(char.IsLetterOrDigit);
        }

        static bool IsHaveTwoDigit(string password)
        {
            return password.Count(char.IsDigit) >= 2;
        }
    }
}
