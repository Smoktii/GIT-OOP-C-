using System;

namespace Example_Try_Catch
{
    class Example_Try_Catch_1
    {
        static void Main(string[] args)
        {
           
            int x = 5;
            int y = x / 0;
            Console.WriteLine($"Результат: {y}");
            Console.WriteLine("Конец программы");
            Console.Read();
             
        }
    }
}
