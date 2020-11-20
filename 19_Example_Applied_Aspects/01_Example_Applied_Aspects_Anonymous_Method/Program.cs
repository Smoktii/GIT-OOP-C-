using System;

namespace _01_Example_Applied_Aspects_Anonymous_Method
{
    class Program
    {
        // Визначення делегату
        delegate void MessageHandler(string message);
        
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Визначення анонімного методу
            MessageHandler handler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };

            handler("Привіт, ДонНУ!");
            Console.ReadKey();
        }
    }
}
