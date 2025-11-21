using System;

namespace MyProject
{
    class Task4
    {
        // Separate methods for each operation
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            char choice = 'Y';

            while (choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Press any following key to perform an arithmetic operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.Write("Your choice: ");

                int op = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Value 1: ");
                double val1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Value 2: ");
                double val2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                string symbol = "";

                // Switch-case for operation choice
                switch (op)
                {
                    case 1:
                        result = Add(val1, val2);
                        symbol = "+";
                        break;

                    case 2:
                        result = Subtract(val1, val2);
                        symbol = "-";
                        break;

                    case 3:
                        result = Multiply(val1, val2);
                        symbol = "*";
                        break;

                    case 4:
                        if (val2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            goto AskAgain;
                        }
                        result = Divide(val1, val2);
                        symbol = "/";
                        break;

                    default:
                        Console.WriteLine("Your choice is invalid! Please try again.");
                        goto AskAgain;
                }

                // Display formatted result
                Console.WriteLine($"{val1} {symbol} {val2} = {result}");

            AskAgain:
                Console.Write("Do you want to continue again (Y/N)? ");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("All done! Thanks for trying the calculator.");
        }
    }
}
