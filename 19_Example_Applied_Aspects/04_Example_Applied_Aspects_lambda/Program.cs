using System;

namespace _04_Example_Applied_Aspects_lambda
{
    class Program
    {
        delegate int Operation(int x, int y);
        
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            // Визначення лябда-виразу (немає визначення типів даних!)
            Operation operationLambda = (x, y) => x + y;
            
            // Визначення еквівалентного коду
            Operation operation = delegate (int x, int y)
            {
                return x + y;
            };

            Console.WriteLine($"operationLambda(10, 20) = {operationLambda(10, 20)}"); // 30
            // Чи можна визвати так? Дивимося відповідність аргументів делегату
            // Console.WriteLine(operationLambda(10.5, 20.4));  
            
            Console.WriteLine($"operationLambda(40, 20) = {operationLambda(40, 20)}"); // 60

            Console.WriteLine($"operation(10, 20) = {operation(10, 20)}"); // 30
            Console.WriteLine($"operation(40, 20) = {operation(40, 20)}"); // 60

            Console.ReadKey();
        }
    }
}
