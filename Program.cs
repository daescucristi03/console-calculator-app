using System;

namespace Calculator {
    class Program {
        // create delegates for addition, subtraction, multiplication and division
        private delegate double BinaryOperation(double a, double b);
        private BinaryOperation addition = (a, b) => a + b;
        private BinaryOperation subtraction = (a, b) => a - b;
        private BinaryOperation multiplication = (a, b) => a * b;
        private BinaryOperation division = (a, b) => b == 0 ? throw new DivideByZeroException("Division by zero") : a / b;

        private void handleUserInput() {
            double result = 0;
            bool isRunning = true;

            while (isRunning) {
                // get first number
                Console.WriteLine("Enter a number:");
                double num1 = double.Parse(Console.ReadLine() ?? "0");

                // get operator
                Console.WriteLine("Enter an operator (+, -, *, /):");
                string? op = Console.ReadLine();

                // get second number
                Console.WriteLine("Enter another number:");
                double num2 = double.Parse(Console.ReadLine() ?? "0");

                // create a dictionary with the operations
                var operations = new Dictionary<string, BinaryOperation>() {
                    { "+", addition },
                    { "-", subtraction },
                    { "*", multiplication },
                    { "/", division }
                };

                // if the operator is valid, perform the operation
                if (operations.TryGetValue(op, out BinaryOperation? operation)) {
                    result = operation(num1, num2);
                    Console.WriteLine($"Result: {result}");
                } else {
                    Console.WriteLine("Invalid operator");
                }

                // ask user if they want to continue
                Console.WriteLine("Do you want to continue? (y/n)");
                string? answer = Console.ReadLine();

                if (answer?.ToLower() == "n") {
                    isRunning = false;
                }

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
