using System;

namespace Example_Try_Catch_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 приклад try без finally та catch без параметрів
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch 
            {
                Console.WriteLine("1: Виник виняток");
            }

            // 2 приклад try без finally та catch з параметром без змінної
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("2: Виник виняток DivideByZeroException");
            }

            // 3 приклад try без finally та catch з параметром без змінної
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"3: Виник виняток {ex.Message}");
            }
        }
    }
}
