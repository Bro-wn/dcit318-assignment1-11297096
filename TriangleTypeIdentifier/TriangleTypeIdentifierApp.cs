using System;

namespace TriangleTypeIdentifierApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                try
                {
                    Console.Write("Enter side A: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter side B: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter side C: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    if (a + b > c && a + c > b && b + c > a)
                    {
                        if (a == b && b == c)
                            Console.WriteLine("Triangle Type: Equilateral");
                        else if (a == b || b == c || a == c)
                            Console.WriteLine("Triangle Type: Isosceles");
                        else
                            Console.WriteLine("Triangle Type: Scalene");
                    }
                    else
                    {
                        Console.WriteLine("The values entered cannot form a valid triangle.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }

                Console.Write("\nDo you want to identify another triangle? (y/n): ");
                continueProgram = Console.ReadLine()?.ToLower() == "y";
            }
            Console.WriteLine("Thank you for using the Triangle Type Identifier!");
        }
    }
}
