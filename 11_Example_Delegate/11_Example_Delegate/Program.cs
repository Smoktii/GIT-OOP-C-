using System;

namespace _11_Example_Delegate
{
    class Program
    {
        // 1. Оголошуємо делегат Message
        delegate string Message();
        
        // Оголошуємо метод GoodMorning()
        private static string GoodMorning()
        {
            Console.WriteLine("Good Morning");
            return "Good Morning";
        }
        // Оголошуємо метод GoodEvening()
        private static string GoodEvening()
        {
            Console.WriteLine("Good Evening");
            return "Good Evening";
        }

        private static void MyFunc()
        {
            Console.WriteLine("MyFunc");
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            // 2. Створюємо змінну делегата
            Message mes;
            // mes = MyFunc; 
            if (DateTime.Now.Hour < 12)
            {
                // 3. Надаємо цієї змінної адресу методу
                mes = GoodMorning; 
            }
            else
            {
                // 3. Надаємо цієї змінної адресу методу
                mes = GoodEvening;
            }
            // 4. Викликаємо метод
            Console.WriteLine($"mes = {mes}, mes() = {mes()} ");
            Console.ReadKey();
        }
    }
}
