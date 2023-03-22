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
                return a / b;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return 0;
            }
        }


        static void Main(string[] args) {
            // create an instance of the program
            Program prog = new Program();
            Console.Clear();

            double result = 0;
            bool isRunning = true;

            while(isRunning) {
                Console.WriteLine("Enter a number:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter an operator (+, -, *, /):");
                string op = Console.ReadLine();

                Console.WriteLine("Enter another number:");
                double num2 = double.Parse(Console.ReadLine());

                switch (op) {
                    case "+":
                        result = prog.addition(num1, num2);
                        break;
                    case "-":
                        result = prog.addition(num1, num2 * (-1));
                        break;
                    case "*":
                        result = prog.multiplication(num1, num2);
                        break;
                    case "/":
                        result = prog.division(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }

                Console.WriteLine($"Result: {result}");

                Console.WriteLine("Do you want to continue? (y/n)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n") {
                    isRunning = false;
                }
                Console.Clear();
            }
        }
    }
}