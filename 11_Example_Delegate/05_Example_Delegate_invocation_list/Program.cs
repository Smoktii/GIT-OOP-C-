using System;

namespace _05_Example_Delegate_invocation_list
{
    class Program
    {
        // 1. Оголошуємо делегат Message 
        delegate void Message();
        // Оголошуємо 2 різні методи Hello та HowAreYou
        private static void Hello()
        {
            Console.WriteLine("Hello!");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Створюємо змінну делегата
            Message myListMessage = Hello; // делегат вказує на метод Hello
            myListMessage = HowAreYou;  // тепер делегат myListMassage вказує на два метода
            myListMessage -= HowAreYou;
            myListMessage(); // викликаються обидва методи - Hello і HowAreYou

            Console.ReadKey();
        }
    }
}
