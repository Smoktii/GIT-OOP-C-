using System;

namespace Example_Methods
{
    class Program
    {
        static int Addition(params int[] integers)
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
            Console.WriteLine($"Addition(1, 2, 3, 4, 5) = {Addition(1, 2, 3, 4, 5)}");

            int[] array = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"Addition(array), array~( 1, 2, 3, 4 ) = {Addition(array)}");

            Console.WriteLine($"Addition() = {Addition()}");
 
            Console.ReadKey();
        }
    }
}
