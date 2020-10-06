using System;

namespace Example_Static
{
    class Account
    {
        public static decimal bonus = 100;
        public decimal totalSum;
        public Account(decimal sum)
        {
            totalSum = sum + bonus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Console.WriteLine(Account.bonus);      // 100
            Account.bonus += 200;                  // 300 

            Account account1 = new Account(150);
            Console.WriteLine($"account1.totalSum = {account1.totalSum}");   // 450

            Account account2 = new Account(1000);
            Console.WriteLine($"account1.totalSum = {account2.totalSum}");   // 1300

            Console.ReadKey();
        }
    }
 }
