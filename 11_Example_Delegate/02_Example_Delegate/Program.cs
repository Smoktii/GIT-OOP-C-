using System;

namespace _02_Example_Delegate
{
    class Program
    {
        // 1. Оголошуємо делегат Operation с 2 параметрами (int x, int y)
        delegate int Operation(int x, int y);
        
        // Оголошуємо 2 різні методи з 2 параметрами 
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            // присвоєння адреси методу через конструктор
            Operation myOper = Add; // делегат вказує на метод Add
            int result = myOper(4, 5); // фактично Add (4, 5) 
            Console.WriteLine($"result = MyOper(4, 5), MyOper = Add  => {result}");
            Console.WriteLine($"MyOper = {myOper}"); // Що буде виведено?

            myOper = Multiply; // тепер делегат вказує на метод Multiply
            result = myOper(4, 5); //фактично Multiply (4, 5)
            Console.WriteLine($"result = MyOper(4, 5) , MMyOper = Multiply  => {result}");
            Console.WriteLine($"MyOper = {myOper}"); // Що буде виведено?

            Console.ReadKey();
        }

    }
}
