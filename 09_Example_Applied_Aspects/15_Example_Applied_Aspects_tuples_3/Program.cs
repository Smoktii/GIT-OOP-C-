using System;

namespace _15_Example_Applied_Aspects_tuples_3
{
    class Program
    {
        private static (int, int) GetValues()
        {
            var result = (1, 3);
            return result;
        }
        private static (int sum, int count) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }
        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            var tuple = GetValues();
            Console.WriteLine($"tuple.Item1 = {tuple.Item1}"); // 1
            Console.WriteLine($"tuple.Item2 = {tuple.Item2}"); // 3

            var tuple2 = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine($"tuple2.count = {tuple2.count}");
            Console.WriteLine($"tuple2.sum = {tuple2.sum}");

            // Визначаємо нові змінні різних типів
            var (name, age) = GetTuple(("Tom", 23), 12);
            Console.WriteLine($"name = {name}");    // Tom
            Console.WriteLine($"age = {age}");      // 35
            
            Console.ReadKey();
        }
    }
}
