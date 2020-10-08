using System;

namespace Example_Methods
{
    class Program
    {
        // передача параметра з params
        static int Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            return result;
        }
        // передача масиву
        static int AdditionMas(int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine($"Addition(1, 2) = {Addition(1, 2)}");
            // Помилка 
            // Console.WriteLine($"AdditionMas(1, 2) = {AdditionMas(1, 2)}");
            int[] array1 = new int[] { 1, 2};
            Console.WriteLine($"AdditionMas(array1) = {AdditionMas(array1)}");

            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Addition(1, 2, 3, 4, 5) = {Addition(1, 2, 3, 4, 5)}");
            Console.WriteLine($"AdditionMas(array2) = {AdditionMas(array2)}");

            int[] array = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"Addition(array), array~( 1, 2, 3, 4 ) = {Addition(array)}");
            Console.WriteLine($"AdditionMas(array) = {AdditionMas(array)}");

            Console.WriteLine($"Addition() = {Addition()}");
            // Помилка 
            // Console.WriteLine($"AdditionMas() = {AdditionMas()}");

            Console.ReadKey();
        }
    }
}
