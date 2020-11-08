using System;

namespace _06_Example_Applied_Aspects_tuples_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Кортежі можуть визначатися неявно 
            var tuple = (5, 10);
            // Кортежі можуть визначатися явно
            (int, int) tupleInt = (5, 10);
            // В кортежі можуть бути різні типи даних
            (string, int, double) person = ("Tom", 25, 81.23);

            Console.WriteLine($"tuple = {tuple}");
            Console.WriteLine($"tupleInt = {tupleInt}");
            Console.WriteLine($"person = {person}");

            // Можемо дати назви полям кортежу
            var tupleNameField = (count: 5, sum: 10);
            Console.WriteLine($"tupleNameField.count = {tupleNameField.count}"); // 5
            Console.WriteLine($"tupleNameField.count = {tupleNameField.Item1}"); // 5
            Console.WriteLine($"tupleNameField.sum = {tupleNameField.sum}"); // 10

            Console.ReadKey();
        }
    }
}
