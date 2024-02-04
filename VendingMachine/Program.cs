using System.Diagnostics;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are:0.1, 0.2, 0.5, 1 and 2

            string command = Console.ReadLine();
            double money = 0;

            while (command != "Start")
            {
                double inputMoney = double.Parse(command);

                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    money += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                command = Console.ReadLine();
            }

            // On the next lines, until the "End" command is given, you will start receiving products, which a customer wants to buy. The vending machine has only:
            // "Nuts" with a price of 2.0·
            // "Water" with a price of 0.7·
            // "Crisps" with a price of 1.5·
            // "Soda" with a price of 0.8·
            // "Coke" with a price of 1.0

            command = Console.ReadLine();
            double totalPrice = 0;
            while (command != "End")
            {

                switch (command)
                {
                    case "Nuts":
                        totalPrice = 2;
                        break;
                    case "Water":
                        totalPrice = 0.7;
                        break;
                    case "Crisps":
                        totalPrice = 1.5;
                        break;
                    case "Soda":
                        totalPrice = 0.8;
                        break;
                    case "Coke":
                        totalPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }
                if (money >= totalPrice)
                {
                    money -= totalPrice;

                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:F2}");
        }
    }
}
