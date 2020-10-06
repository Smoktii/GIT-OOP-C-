using System;

namespace Example_Static_Methods
{
    class Account
    {
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Неприпустима сума!");
            Sum = sum; 
            Rate = rate;
        }
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        /* Змінна minSum і властивість MinSum представляють мінімальну суму, 
         * яка допустима для створення рахунку. Цей показник не відноситься до якогось 
         * конкретного рахунку, а відноситься до всіх рахунків в цілому. Якщо ми змінимо 
         * цей показник для одного рахунку, то він також повинен змінитися і для іншого рахунку. 
         * Тобто на відміну від властивостей Sum і Rate, які зберігають стан об'єкта, 
         * змінна minSum зберігає стан для всіх об'єктів даного класу
        */

        private static decimal minSum = 100; // мінімальна допустима сума для всіх рахунків

        // Автовластивості (не Static - тобто для кожного рахунка (об'єкта) - власні!)
        public decimal Sum { get; private set; }    // сума на рахунку
        public decimal Rate { get; private set; }   // процентна ставка

        // підрахунок суми на рахунку через певний період за певною ставкою

        /* обчислює суму на рахунку через певний період за певною відсотковою ставкою для певної  
         * початкової суми. Виклик і результат цього методу не залежить від конкретного об'єкта 
         * або його стану.         */

        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // Помилка - немає доступу до змінної minSum
            // Console.WriteLine(Account.minSum);      // 100

            Console.WriteLine($"Account.MinSum (def) = {Account.MinSum}");   // 100
            Account.MinSum = 200; // 200 
            Console.WriteLine($"Account.MinSum (200) = {Account.MinSum}");   // 200

            // (1000 + 1000 * 0.1) * 1.1 * 1.1 * 1.1 * 1.1 = 1610,51  
            Console.WriteLine($"Account.GetSum(1000, 10, 5) = {Account.GetSum(1000, 10, 5)}");  

            Console.ReadKey();
        }
    }
}
