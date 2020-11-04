using System;

namespace _08_Example_Delegate_Invoke
{
    class Program
    {
        // Оголошуємо делегати 
        delegate int Operation(int x, int y);
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
        // Оголошуємо 3 різні методи для Operation
        private static int Add(int x, int y) 
        {
            Console.WriteLine($"Add = {x + y}");
            return x + y; 
        }
        private static int Subtract(int x, int y) 
        {
            Console.WriteLine($"Subtract = {x - y}"); 
            return x - y; 
        }
        private static int Multiply(int x, int y) 
        {
            Console.WriteLine($"Multiply = {x * y}");
            return x * y; 
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Message myListMessage1 = Hello;
            myListMessage1 += HowAreYou;
            Console.WriteLine($"викликається myListMessage1() - Hello, HowAreYou");
            myListMessage1();
                        
            Operation myListOperation1 = Add;
            myListOperation1 += Multiply;
            Console.WriteLine($"\nвикликається myListOperation1(3, 4) - Add, Multiply"); 
            Console.WriteLine($"myListOperation1(3, 4), Add, Multiply = {myListOperation1(3, 4)}"); ;

            // Інший спосіб виклику делегата представляє метод Invoke()
            Console.WriteLine($"\nвикликається myListMessage1.Invoke() - Hello, HelloHowAreYou");
            myListMessage1.Invoke();

            Console.WriteLine($"\nвикликається myListOperation1.Invoke(3, 4) - Add, Multiply");
            // незважаючи на наявність декількох методів в делегаті 
            // повертається значення останього метода, що визивається
            int result = myListOperation1.Invoke(3, 4); 
            Console.WriteLine($"myListOperation1.Invoke(3, 4), Add, Multiply = {result}"); ;

            // Перевірка на визов пустого делегата
            Message mes = null;
            // Помилка: делегат дорівнює null 
            // "Object reference not set to an instance of an object."
            // mes();  
            mes?.Invoke();        // помилки немає, делегат просто не викликається

            Operation op = Add;
            op -= Add;      // делегат op пустий!
            // op(3, 4);       // Помилка: делегат дорівнює null
            op?.Invoke(3, 4);  // помилки немає, делегат просто не викликається


            Console.ReadKey();
        }
    }
}
