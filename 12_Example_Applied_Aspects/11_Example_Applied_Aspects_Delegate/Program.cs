using System;

namespace _11_Example_Applied_Aspects_Delegate
{
    // Визначимо клас, що описує рахунок в банку
    class Account
    {
        int _sum; // Змінна для зберігання суми

        // Конструктор
        public Account(int sum)
        {
            _sum = sum;
        }

        // Властивість CurrentSum (тільки для читання)
        public int CurrentSum
        {
            get { return _sum; }
        }

        // Покласти суму на рахунок
        public void Put(int sum)
        {
            _sum += sum;
        }

        // Вивести суму з рахунка
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
            }
        }

        /* Припустимо, в разі виведення грошей за допомогою методу Withdraw нам 
         * треба якось повідомляти про це самого клієнта і, може бути, інші об'єкти. 
         * Для цього створимо делегат AccountStateHandler. 
         * Щоб використовувати делегат, нам треба створити змінну цього делегата, 
         * а потім привласнити йому метод, який буде викликатися делегатом.
         * */

        // оголошуємо делегат
        public delegate void AccountStateHandler(string message, bool isCorrect);
        // Створюємо змінну делегата
        AccountStateHandler _callBackFunc;

        // Метод для реєстрації делегата
        public void RegisterHandler(AccountStateHandler callBackFunc)
        {
            _callBackFunc = callBackFunc;
        }
        // Нова версія методу Withdraw
        public void WithdrawVer2(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;

                if (_callBackFunc != null)
                    _callBackFunc($"Сума {sum} знята з рахунка", true);
            }
            else
            {
                if (_callBackFunc != null)
                    _callBackFunc("Недостатньо грошей на рахунку", false);
            }
        }

        // Метод для реєстрації делегата Ver2
        public void RegisterHandlerVer2(AccountStateHandler callBackFunc)
        {
            _callBackFunc += callBackFunc; // додаємо делегат
        }
        // Скасування реєстрації делегата
        public void UnregisterHandlerVer2(AccountStateHandler callBackFunc)
        {
            _callBackFunc -= callBackFunc; // видаляємо делегат
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // створюємо банківський рахунок
            Account account = new Account(200);
            // Додаємо в делегат посилання на метод Show_Message
            // а сам делегат передається як параметр методу RegisterHandler
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            // Два рази поспіль намагаємося зняти гроші
            account.WithdrawVer2(100);
            account.WithdrawVer2(150);

            // Передати декілька методів для визова
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message)+ new Account.AccountStateHandler(Show_Message));
            account.Put(100);
            // Два рази поспіль намагаємося зняти гроші
            Console.WriteLine($"\nМаємо два метода в делегаті");
            account.WithdrawVer2(100);
            account.WithdrawVer2(150);

            // Передати декілька методів для визова VER2
            Account accountVer2 = new Account(200);
            Account.AccountStateHandler colorDelegate = 
                                new Account.AccountStateHandler(Color_Message);

            // Додаємо в делегат посилання на метод
            accountVer2.RegisterHandlerVer2(new Account.AccountStateHandler(Show_Message));
            accountVer2.RegisterHandlerVer2(colorDelegate);

            Console.WriteLine($"\nМаємо два метода в делегаті Ver2");
            // Два рази поспіль намагаємося зняти гроші
            accountVer2.WithdrawVer2(100);
            accountVer2.WithdrawVer2(150);

            // видаляємо делегат
            accountVer2.UnregisterHandlerVer2(colorDelegate);
            Console.WriteLine($"\nПісля видалення метода colorDelegate");
            accountVer2.WithdrawVer2(50);

            Console.ReadKey();
        }
        private static void Show_Message(String message, bool isCorrect)
        {
            Console.WriteLine($"message = {message}, isCorrect = {isCorrect}");
        }
        private static void Color_Message(string message, bool isCorrect)
        {
            if (!isCorrect)
            {
                // Встановлюємо червоний колір символів
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Color_Message: message = {message}, isCorrect = {isCorrect}");
                Console.ResetColor();
            }
            else
                Console.WriteLine($"Color_Message: message = {message}, isCorrect = {isCorrect}");
        }

    }
}
