using System;

namespace _06_Example_Delegate_Add_Del_Methods
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
            Message myListMessage = Hello; // делегат вказує на метод Hello
            myListMessage += HowAreYou;  // тепер делегат myListMassage вказує на два метода
            myListMessage += Hello;  // тепер делегат myListMassage вказує на три метода
            myListMessage += Hello;  // тепер делегат myListMassage вказує на 4 метода

            Console.WriteLine($"викликаються всі 4 методи - Hello, HowAreYou, Hello, Hello"); 
            myListMessage(); // викликаються всі 4 методи - Hello, HowAreYou, Hello, Hello
            // ніякої специфіки наявності множини методів!
            Console.WriteLine($"myListMessage = {myListMessage}");

            myListMessage -= HowAreYou; // Видаляємо не останній метод! 
            Console.WriteLine($"викликаються всі 3 методи - Hello, Hello, Hello");
            myListMessage();
            // ніякої специфіки наявності множини методів!
            Console.WriteLine($"myListMessage = {myListMessage}");

            // Спроба видалення неіснуючого метода в делегаті
            myListMessage -= NotUseMethod; // Спроба видалити метод NotUseMethod, якого не має
            myListMessage -= HowAreYou;
            Console.WriteLine($"викликаються методи після видалення NotUseMethod, HowAreYou");
            myListMessage();

            Console.ReadKey();
        }
    }
}
