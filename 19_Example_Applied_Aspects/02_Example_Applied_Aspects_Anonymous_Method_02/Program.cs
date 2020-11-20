using System;

namespace _02_Example_Applied_Aspects_Anonymous_Method_02
{
    class Program
    {
        delegate void MessageHandler(string message);

        static void ShowMessage(string mes, MessageHandler handler)
        {
            handler(mes);
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            // Передача пераметром анонімного метода як делегата

            ShowMessage("Привіт, ДонНУ (параметр)!", delegate (string mes)
            {
                Console.WriteLine(mes);
            });

            // Створення анонімного методу без параметрів
            MessageHandler myHandler = delegate
            {
                Console.WriteLine("анонімний метод без параметрів");
            };

            myHandler("Привіт, ДонНУ!");
            // Помилка! Чому? 
            // myHandler();

            Console.ReadKey();
        }
    }
}
