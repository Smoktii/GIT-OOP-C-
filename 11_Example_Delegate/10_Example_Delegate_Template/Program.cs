using System;

namespace _10_Example_Delegate_Template
{
  
    class Program
    {
        // Визначення узагальненого делегату з двома параметрами   
        delegate T Operation<T, K>(K val1, K val2);
        /*
         * Operation<double, double> operationDouble ;
         * delegate double Operation(double val1, double val2);
         * 
         * Operation<int, double> operation2;
         * delegate int Operation(double val1, double val2);
         * 
          * Operation<int, char> operation3;
         * delegate int Operation(char val1, char val2);        * 
         */

        private static int Add(int x, int y)
        {
            Console.WriteLine($"Add = {x + y}");
            return x + y;
        }
        private static double Add(double x, double y)
        {
            Console.WriteLine($"Add (double) = {x + y}");
            return x + y;
        }
        private static int Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract = {x - y}");
            return x - y;
        }
        private static double Subtract(double x, double y)
        {
            Console.WriteLine($"Subtract (double) = {x - y}");
            return x - y;
        }
        private static int Multiply(int x, int y)
        {
            Console.WriteLine($"Multiply = {x * y}");
            return x * y;
        }
        private static double Multiply(double x, double y)
        {
            Console.WriteLine($"Multiply (double) = {x * y}");
            return x * y;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Operation<int, int> operationInt = Add;
            Operation<double, double> operationDouble = Multiply;
            
            Console.WriteLine($"operationInt(3, 4) Add = {operationInt(3, 4)}");
            Console.WriteLine($"operationDouble(30, 40) Multiply = {operationDouble(30, 40)}");

            Console.ReadKey();
        }

    }
}
