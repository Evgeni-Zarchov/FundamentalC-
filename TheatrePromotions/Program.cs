namespace TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A theatre sails tickets at discount and a program is needed to calculate the price of a single ticket. If the given age does not fit one of the categories, you should print "Error!".

            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                switch (typeOfTheDay)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("5$");
                        break;

                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (typeOfTheDay)
                {
                    case "Weekday":
                        Console.WriteLine("18$");
                        break;
                    case "Weekend":
                        Console.WriteLine("20$");
                        break;
                    case "Holiday":
                        Console.WriteLine("12$");
                        break;

                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (typeOfTheDay)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("10$");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
