namespace BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes". One day John was tired of waiting and decided he needed a program, which prints the time after 30 minutes, so he could come back after exactly 30 minutes. He is not able to write the program by himself, so he asks for help.

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours >= 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
