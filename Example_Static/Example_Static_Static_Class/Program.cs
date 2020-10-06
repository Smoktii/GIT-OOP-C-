using System;

namespace Example_Static_Static_Class
{
    static class Account
    {
        private static decimal minSum = 100; // мінімальна допустима сума для всіх рахунків
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        // підрахунок суми на рахунку через певний період за певною ставкою
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
        // ERROR: Автовластивості (не Static - тобто для кожного рахунка (об'єкта) - власні!)
        // public decimal Sum { get; private set; }    // сума на рахунку
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine($"Account.MinSum (def) = {Account.MinSum}");
            Account.MinSum = -200; // minSum = 100 
            Console.WriteLine($"Account.MinSum (-200) = {Account.MinSum}");
            Account.MinSum = 300; // minSum = 300 
            Console.WriteLine($"Account.MinSum (300) = {Account.MinSum}");

            Console.ReadKey();
        }
    }
}
