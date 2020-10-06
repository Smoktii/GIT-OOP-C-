using System;

namespace Example_Static_Methods
{
    class Account
    {
        private static decimal minSum = 100; // мінімальна допустима сума для всіх рахунків

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

        public decimal Sum { get; private set; }    // сумма на счете
        public decimal Rate { get; private set; }   // процентная ставка

        // подсчет суммы на счете через определенный период по определенной ставке
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
            Console.WriteLine("Hello World!");
        }
    }
}
