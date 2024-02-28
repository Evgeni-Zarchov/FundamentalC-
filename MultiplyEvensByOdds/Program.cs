namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumber = Console.ReadLine();
            int evenSum = EvenOrOdd(stringNumber, true);
            int oddSum = EvenOrOdd(stringNumber, false);

            int result = evenSum * oddSum;

            Console.WriteLine(result);

        }

        static int EvenOrOdd(string numbers, bool isTrue)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 48 && numbers[i] <= 57)
                {
                    int currNumber = int.Parse(numbers[i].ToString());

                    if (isTrue)
                    {
                        if (currNumber % 2 == 0 && isTrue)
                        {
                            sum += currNumber;
                        }
                    }
                    else
                    {
                        if (currNumber % 2 != 0 && !isTrue)
                        {
                            sum += currNumber;
                        }
                    }
                }
            }

            return sum;
        }
    }
}
