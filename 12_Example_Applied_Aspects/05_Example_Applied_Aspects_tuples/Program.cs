using System;

namespace _05_Example_Applied_Aspects_tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            var tuple = (5, 10);
            Console.WriteLine($"tuple.Item1 = {tuple.Item1}"); // 5
            Console.WriteLine($"tuple.Item2 = {tuple.Item2}"); // 10
            tuple.Item1 += 26;
            Console.WriteLine($"tuple.Item1 = {tuple.Item1}"); // 31
            Console.ReadKey();

        }
    }
}
