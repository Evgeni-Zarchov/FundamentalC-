namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DAILY_DECREASE = 10;
            const int MINE_YIELD = 100;
            const int CONSUMED_BY_WORKERS = 26;


            int startingYield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            double totalSpice = 0;

            while(startingYield >= MINE_YIELD)
            {
                totalSpice += startingYield - CONSUMED_BY_WORKERS;
                startingYield -= DAILY_DECREASE;
                daysCount++;

                if (startingYield < MINE_YIELD)
                {
                    totalSpice -= CONSUMED_BY_WORKERS;
                }
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(totalSpice);
        }
    }
}
