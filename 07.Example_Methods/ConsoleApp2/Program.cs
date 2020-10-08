using System;

namespace Example_Methods
{
    class Program
    {
        static int Sum(int x, int y)
        {
            int c = x + y;
            x += 100;
            y += 300;
            return c;
        }
        static void Addition(ref int x, int y)
        {

            x += y;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            int a = 10;
            int b = 15;

            Console.WriteLine($"Sum(a, b) = {Sum(a, b)}"); // 25
            Console.WriteLine($"a = {a}, b = {b}");

            Addition(ref a, b); // визов метода
            Console.WriteLine($"Після Addition(ref a, b): a = {a}, b = {b}"); // 25  15 

            Console.ReadKey();
        }

    }
}
