using System;

namespace _04._2_Example_Applied_Aspects_array_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };
            int count = 0;
            Console.WriteLine($"Цикл foreach");
            foreach (int i in numbers)
            {
                count++;
                Console.WriteLine($"count = {count}, i = {i}");
                // Неможливо змінити i
                // i = i * i;
            }

            Console.WriteLine($"Цикл for");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"i = {i}, numbers[i] = {numbers[i]}");
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine($"i = {i}, numbers[i] (x^2) = {numbers[i]}");
            }


            Console.ReadKey();
        }
    }
}
