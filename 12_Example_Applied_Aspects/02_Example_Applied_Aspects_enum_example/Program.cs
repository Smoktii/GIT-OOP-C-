using System;

namespace _02_Example_Applied_Aspects_enum_example
{
    class Program
    {
        enum MyOperation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }
        static double MathOperation(double x, double y, MyOperation op)
        {
            double result = 0.0;

            switch (op)
            {
                case MyOperation.Add:
                    result = x + y;
                    break;
                case MyOperation.Subtract:
                    result = x - y;
                    break;
                case MyOperation.Multiply:
                    result = x * y;
                    break;
                case MyOperation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine($"Результат операції {x} {op} {y} дорівнює {result}");
            return result;
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Тип операції задаємо за допомогою константи MyOperation.Add, яка дорівнює 1
            MathOperation(10, 5, MyOperation.Add);
            // Тип операції задаємо за допомогою константи MyOperation.Multiply, яка дорівнює 3
            MathOperation(11, 5, MyOperation.Multiply);

            Console.ReadKey();
        }
    }
}
