using System;

namespace Example_Methods
{
    class Program
    {
        static int ExampleParamDefault(int x, int y, int z = 5, int s = 7)
        {
            return x + y + z + s;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // 1 + 2 + 3 + 4 = 10
            Console.WriteLine($"ExampleParamDefault(s:4,z:3,x:1,y:2) = {ExampleParamDefault(s:4, z:3, x:1, y:2)}");

            // Необов'язковий параметр z використовує значення за замовчуванням
            // 3 + 2 + 5 (!) + 10 = 20
            Console.WriteLine($"ExampleParamDefault(y:2,x:3,s:10) = {ExampleParamDefault(y: 2, x: 3, s: 10)}");

            // 3 + ? + 2 + 10 = 42 - ERROR
            // Console.WriteLine($"ExampleParamDefault(y:2,x:3,s:10) = {ExampleParamDefault(z: 2, x: 3, s: 10)}");

            Console.ReadKey();
        }

    }
}
