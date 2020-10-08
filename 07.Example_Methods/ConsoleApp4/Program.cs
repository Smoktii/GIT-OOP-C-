using System;

namespace Example_Methods
{
    class Program
    {
        static void GetData(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = (x + y) * 2;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            int x = 10;
            // Типовий варіант 1
            int area, perimetr;
            GetData(x, 15, out area, out perimetr);
            Console.WriteLine($"1 варіант площа = {area}, периметр = {perimetr}");

            // Особливий варіант 2 (визначення змінних під час виклику функції)
            GetData(x, 15, out int area_new, out int perimetr_new);
            Console.WriteLine($"2 варіант площа = {area_new}, периметр = {perimetr_new}");

            Console.ReadKey();
        }
    }
}
