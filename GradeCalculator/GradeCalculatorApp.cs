using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Write("Enter a grade (0 - 100): ");
                if (int.TryParse(Console.ReadLine(), out int grade))
                {
                    if (grade >= 90 && grade <= 100)
                        Console.WriteLine("Letter Grade: A");
                    else if (grade >= 80)
                        Console.WriteLine("Letter Grade: B");
                    else if (grade >= 70)
                        Console.WriteLine("Letter Grade: C");
                    else if (grade >= 60)
                        Console.WriteLine("Letter Grade: D");
                    else if (grade >= 0)
                        Console.WriteLine("Letter Grade: F");
                    else
                        Console.WriteLine("Invalid grade. Must be between 0 and 100.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.Write("\nDo you want to calculate another grade? (y/n): ");
                continueProgram = Console.ReadLine()?.ToLower() == "y";
            }
            Console.WriteLine("Thank you for using the Grade Calculator!");
        }
    }
}
