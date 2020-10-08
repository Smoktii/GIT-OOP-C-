using System;

namespace Example_Methods
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
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

            Console.WriteLine($"Sum(a, b) = {Sum(a, b)}");
            Console.WriteLine($"a = {a}, b = {b}");

            Addition(ref a, b); // вызов метода
            Console.WriteLine($"Після Addition(ref a, b): a = {a}, b = {b}");

            Console.ReadKey();
        }

    }
}
