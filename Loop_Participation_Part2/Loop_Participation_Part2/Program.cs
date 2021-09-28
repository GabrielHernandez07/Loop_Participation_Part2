using System;

namespace Loop_Participation_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double bankaccounts;
            string answer;

            Console.WriteLine("Hello User. I have a financial question.");
            do
            {
                Console.WriteLine("How many bank accounts do you have? >>");
                answer = Console.ReadLine();

                if (double.TryParse(answer, out bankaccounts) == false)
                {
                    Console.WriteLine($"{answer} is an invalid number. Please try again.");
                }
            } while (double.TryParse(answer, out bankaccounts)==false);

            Console.WriteLine("Please enter the amount of each bankaccount");
            double amount = 0;
            double average = 0;
            for (int i = 1; i <= bankaccounts; i++)
            {
                string amountAsString;
                do
                {
                    Console.WriteLine($"Enter the amount for the {i} account. >>");
                    amountAsString = Console.ReadLine();
                    if (double.TryParse(amountAsString, out amount) == false)
                    {
                        Console.WriteLine($"{amountAsString} is an invalid input. Please enter the correct amount. >>");
                    }
                } while (double.TryParse(amountAsString, out amount) == false);

                amount = amount+ Convert.ToDouble(amountAsString);
                average = amount / i;
            }


            Console.WriteLine($"Total of all accounts");
            Console.WriteLine(amount.ToString("C2"));
            
            Console.WriteLine("Average of all accounts");
            if (average >= 5000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(average.ToString("C2"));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(average.ToString("C2"));
            }


        }
    }
}
