using System;

namespace _07_Example_Delegate_Add_Union
{
    class Program
    {
        // Оголошуємо делегат Message 
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
        private static void NotUseMethod()
        {
            Console.WriteLine("NotUseMethod!?");
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Створюємо змінну делегата
            Message myListMessage1 = Hello; // делегат вказує на метод Hello
            myListMessage1 += Hello;

            Message myListMessage2 = HowAreYou; // делегат вказує на метод Hello
            myListMessage2 += HowAreYou;

            Message resultDelegate = myListMessage1 + myListMessage2; // об'єднуємо делегати

            // викликаються всі методи з myListMessage1 і myListMessage2 (скільки?)
            resultDelegate();  

            Console.ReadKey();
        }
    }
}
