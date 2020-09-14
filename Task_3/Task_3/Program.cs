using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            long c;
            string s;
            Console.Clear();
            s = Console.ReadLine();
            a = Int32.Parse(s);
            s = Console.ReadLine();
            b = double.Parse(s);
            c = long.Parse(s);
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
