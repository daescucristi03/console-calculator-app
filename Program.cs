using System;
using System.Linq;

namespace Calculator {
    class Program {
        // addition and subtraction methods
        private double addition(double a, double b) { return a + b; }
        // multiplication and division functions
        private double multiplication(double a, double b) { return a * b; }
        private double division(double a, double b) {
            try {
                // handle in case of division by zero
                return a / b;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        private void handleUserInput() {
            double result = 0;
            bool isRunning = true;

            while(isRunning) {
                // get first number
                Console.WriteLine("Enter a number:");
                double num1 = double.Parse(Console.ReadLine() ?? "0");

                // get operator
                Console.WriteLine("Enter an operator (+, -, *, /):");
                string? op = Console.ReadLine();

                // get second number
                Console.WriteLine("Enter another number:");
                double num2 = double.Parse(Console.ReadLine() ?? "0");

                switch (op) {
                    case "+":
                    // handle addition
                        result = addition(num1, num2);
                        break;
                    case "-":
                    // handle subtraction
                        result = addition(num1, num2 * (-1));
                        break;
                    case "*":
                    // handle multiplication
                        result = multiplication(num1, num2);
                        break;
                    case "/":
                    // handle division
                        result = division(num1, num2);
                        break;
                    default:
                    // handle default case
                        Console.WriteLine("Invalid operator");
                        break;
                }

                // display result
                Console.WriteLine($"Result: {result}");

                Console.WriteLine("Do you want to continue? (y/n)");
                string? answer = Console.ReadLine();

                if (answer?.ToLower() == "n") { isRunning = false; }

                Console.Clear();
            }
        }


        static void Main(string[] args) {
            // create an instance of the program
            Program prog = new Program();
            Console.Clear();

            // handle main function
            prog.handleUserInput();
            
        }
    }
}