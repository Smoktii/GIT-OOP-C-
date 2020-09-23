using System;

namespace Example_Try_Catch_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Виникло виняток!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Кінець програми");
            Console.Read();

        }
    }
}
