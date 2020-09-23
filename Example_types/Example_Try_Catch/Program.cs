using System;

namespace Example_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            int y = x / 0;
            Console.WriteLine($"Результат: {y}");
            Console.WriteLine("Конец программы");
            Console.Read();
            */ 
            
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();
             
        }
    }
}
