namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string inputPassword = Console.ReadLine();
            int loginCount = 0;
            while (inputPassword != password)
            {
                loginCount++;
                if (loginCount > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }
            if (inputPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
