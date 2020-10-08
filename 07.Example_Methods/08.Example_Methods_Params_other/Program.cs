using System;

namespace Example_Methods
{
    class Program
    {
        //Так НЕ ПРАЦЮЄ - ПОМИЛКА
        // static void Addition(params int[] integers, int x, string mes)
        static int Addition(int x, string mes, params int[] integers)
        {
            int result = x;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine($"x = {x}, mes = {mes}, result = {result}");
            return result;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine($"Addition(1000, 'Перший варіант', 1, 2) = {Addition(1000, "Перший варіант", 1, 2)}");
            Console.WriteLine($"Addition(1000, 'Другий варіант',1, 2, 3, 4, 5) = {Addition(1000, "Другий варіант", 1, 2, 3, 4, 5)}");

            int[] array = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"Addition(1000, 'Третій варіант', array), array~( 1, 2, 3, 4 ) = {Addition(1000, "Третій варіант", array)}");

            Console.WriteLine($"Addition(1000, 'Четвертий варіант') = {Addition(1000, "Четвертий варіант")}");

            Console.ReadKey();
        }
    }
}
