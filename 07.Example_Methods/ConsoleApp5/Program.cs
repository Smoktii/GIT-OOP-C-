using System;

namespace Example_Methods
{
    class Program
    {
        static void GetData(in int x, int y, out int area, out int perim)
        {
            // x = x + 10; // не можна змінити значення параметра x
            y = y + 10;
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
            Console.WriteLine($"площа (10x(15+10)) = {area}, периметр (10x(15+10)) = {perimetr}");

            Console.ReadKey();
        }
    }
}
