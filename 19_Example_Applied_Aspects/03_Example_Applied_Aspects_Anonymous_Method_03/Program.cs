using System;

namespace _03_Example_Applied_Aspects_Anonymous_Method_03
{
    class Program
    {
        delegate int Operation(int x, int y);
        
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Operation operation = delegate (int x, int y)
            {
                return x + y;
            };

            int d = operation(4, 5);
            Console.WriteLine($"d = {d}"); // 9

            // Приклад доступу до змінних з анонімного методу
            int z = 8;
            Operation operation2 = delegate (int x, int y)
            {
                return x + y + z;
            };
            int result = operation2(4, 5);
            Console.WriteLine($"result = {result}"); // 9 + 8 = 17

            Console.ReadKey();
        }
    }
}
