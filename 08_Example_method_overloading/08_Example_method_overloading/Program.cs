using System;

namespace _08_Example_method_overloading
{
    class Calculator
    {
        public void Add(int a, int b)   // Add(int, int)
        {
            int result = a + b;
            Console.WriteLine($"Result Add(int a, int b) is {result}");
        }
        public void Add(int a, int b, int c)    // Add(int, int, int)
        {
            int result = a + b + c;
            Console.WriteLine($"Result Add(int a, int b, int c) is {result}");
        }
        public int Add(int a, int b, int c, int d)  // Add(int, int, int, int)
        {
            int result = a + b + c + d;
            Console.WriteLine($"Result Add(int a, int b, int c, int d) is {result}");
            return result;
        }
        public void Add(double a, double b) // Add(double, double)
        {
            double result = a + b;
            Console.WriteLine($"Result Add(double a, double b) is {result}");
        }

        // Signatures

        // Add(int, int)
        // Add(double, double)
        // Add(int, int, int)
        // Add(int, int, int, int)

        // ERROR
        /*
        public double Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Result Add(double a, double b) is {result}");
            return result;
        } 
        */
        public void Increment(ref int val) // Increment(ref int)
        {
            val++;
            Console.WriteLine($"Result Increment(ref int val) is {val}");
        }
        public void Increment(int val)     // Increment(int)
        {
            val++;
            Console.WriteLine($"Result Increment(int val) is {val}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Calculator calc = new Calculator();

            calc.Add(1, 2);         // 3
            calc.Add(1, 2, 3);      // 6
            calc.Add(1, 2, 3, 4);   // 10
            calc.Add(1.4, 2.5);     // 3.9

            int myVar = 7;
            calc.Increment(ref myVar); // myVar = 8
            Console.WriteLine($"myVar (after Increment(ref myVar)) = {myVar}");
            calc.Increment(myVar); // myVar = 8
            Console.WriteLine($"myVar (after calc.Increment(myVar)) = {myVar}");

            Console.ReadKey();
        }
    }
}
