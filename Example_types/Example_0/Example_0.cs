using System;

namespace Example_0
{
    class Example_0
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("1: Привіт, ДонНУ");

            string s = Console.ReadLine();
            Console.WriteLine($"2: Привіт, ДонНУ {s}");
        }
    }
}
