namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = countOfPeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = countOfPeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = countOfPeople * 10.46;
                }
                if (countOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = countOfPeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = countOfPeople * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = countOfPeople * 16;
                }
                if (countOfPeople >= 100)
                {
                    totalPrice -= totalPrice / countOfPeople * 10;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = countOfPeople * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = countOfPeople * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = countOfPeople * 22.50;
                }
                if (countOfPeople >= 10 && countOfPeople <= 10)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}