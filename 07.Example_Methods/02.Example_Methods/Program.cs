using System;

namespace Example_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // 1 + 2 + 3 + 4 = 10
            Console.WriteLine($"ExampleParamDefault(1,2,3,4) = {ExampleParamDefault(1, 2, 3, 4)}");

            // 10 + 20 + 30 + 7 = 67
            Console.WriteLine($"ExampleParamDefault(10,20,30) = {ExampleParamDefault(10, 20, 30)}");

            // 10 + 20 + 5 + 7 = 42
            Console.WriteLine($"ExampleParamDefault(10,20) = {ExampleParamDefault(10, 20)}");

            // 10 + ? + 5 + 7 = 42
            // ERROR 
            // Console.WriteLine($"ExampleParamDefault(10) = {ExampleParamDefault(10)}");

            Console.ReadKey();
        }
        static int ExampleParamDefault(int x, int y, int z = 5, int s = 7)
        {
            return x + y + z + s;
        }
    }
}
