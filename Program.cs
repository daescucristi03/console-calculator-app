using System;

namespace Calculator {
    class Program {
        // addition and subtraction methods
        private int addition(int a, int b) { return a + b; }
        private double addition(double a, double b) { return a + b; }
        // multiplication and division functions
        private int multiplication(int a, int b) { return a * b; }
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

        }
    }
}