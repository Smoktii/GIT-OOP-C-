using System;

namespace Example_Methods
{
    class Program
    {
        static int Sum(int x, int y, out int a)
        {
            a = x + y;
            return 1; // Якщо виникли проблеми в функції, то повернути 0
        }
        static void GetData(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = (x + y) * 2;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            int a = 10;
            int b = 15;
            int c = 0, result;

            Console.WriteLine($"Початкові значення a = {a}, b = {b}, c = {c}");
            result = Sum(a, 15, out c);
            Console.WriteLine($"Sum(a, 15, out c) = {result}");
            Console.WriteLine($"Після визову a = {a}, b = {b}, c = {c}");

            int x = 10;
            int area;
            int perimetr;
            GetData(x, 15, out area, out perimetr);
            Console.WriteLine("Площа (10x15) : " + area);
            Console.WriteLine("Периметр (10x15) : " + perimetr);

            Console.ReadKey();
        }
        // Помилкове визначення функції
        /* 
        static void Sum_Error(int x, int y, out int a)
        {
            Console.WriteLine(x + y);
        }
        */
    }
}
