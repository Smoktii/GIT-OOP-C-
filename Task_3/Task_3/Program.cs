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
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("введіть зміну типу int");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.WriteLine("введіть зміну типу double");
            s = Console.ReadLine();
            b = double.Parse(s);
            Console.WriteLine("введіть зміну типу long");
            s = Console.ReadLine();
            c = long.Parse(s);
            Console.WriteLine($"a = {a}; b = {b}; с = {c}");
        }
    }
}
