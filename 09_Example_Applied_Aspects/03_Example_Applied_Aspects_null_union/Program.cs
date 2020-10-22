using System;

namespace _01_Example_Applied_Aspects_null
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            object x = null;
            object y = null;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            y ??= 100;  // дорівнює 100, так як y дорівнює null ?? 
            // x = x ?? 200;
            Console.WriteLine($"y (100) = {y}");

            y ??= 500;  // дорівнює 100, так як y не дорівнює null
            Console.WriteLine($"y (500) = {y}");

            y ??= x ??= 900;
            Console.WriteLine($"y (900) = {y}, x (900) = {x}"); // y = 100, x = null Чому???

            Console.ReadKey();
        }
    }
}
