using System;

namespace _03_Example_Delegate_Another_Class
{
    class Math
    {
        public int Sum(int x, int y) 
        { 
            return x + y; 
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        private int PrivateMultiply(int x, int y)
        {
            return x * y;
        }
        static public int StaticMultiply(int x, int y)
        {
            return x * y;
        }
    }
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Створення екземпляру обєкта класу Math
            Math math = new Math();
            // Створюємо змінну делегата Math
            Operation myOper = math.Sum;
            int result = myOper(4, 5);     // math.Sum(4, 5)
            Console.WriteLine($"result = MyOper(4, 5), Operation myOper = math.Sum => {result}");

            myOper = math.Multiply;
            result = myOper(4, 5); // math.Multiply(4, 5)
            Console.WriteLine($"result = MyOper(4, 5), Operation myOper = math.Multiply => {result}");

            // Чи буде працювати ?
            // myOper = math.PrivateMultiply;

            // Чи буде працювати ?
            // myOper = math.StaticMultiply;

            // Чи буде працювати ?
            // myOper = Math.StaticMultiply;

            result = myOper(40, 50); // ??
            Console.WriteLine($"result = MyOper(40, 50) => {result}");

            Console.ReadKey();
        }
    }
}
