using System;

namespace TicketPriceCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    if (age >= 0 && (age <= 12 || age >= 65))
                        Console.WriteLine("Ticket Price: GHC 7");
                    else if (age > 12 && age < 65)
                        Console.WriteLine("Ticket Price: GHC 10");
                    else
                        Console.WriteLine("Invalid age entered.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.Write("\nDo you want to calculate another ticket price? (y/n): ");
                continueProgram = Console.ReadLine()?.ToLower() == "y";
            }
            Console.WriteLine("Thank you for using the Ticket Price Calculator!");
        }
    }
}
