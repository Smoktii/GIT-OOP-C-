using System;

namespace _04_Example_Delegate_Setting_Values
{
    class Program
    {
        delegate int Operation(int x, int y);
        private static int Add(int x, int y) { return x + y; }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            // 1) безпосередньо присвоювати посилання на метод
            Operation myOper1 = Add;  // Чому можливо використати private static int Add(int x, int y)?

            // 2) створення об'єкта делегата за допомогою конструктора, в який передається потрібний метод
            Operation myOper2 = new Operation(Add);

            Console.WriteLine($"myOper1(4, 5) = {myOper1(4, 5)}"); // 9
            Console.WriteLine($"myOper2(40, 50) = {myOper2(40, 50)}");  // 90

            Console.ReadKey();
        }

    }
}
