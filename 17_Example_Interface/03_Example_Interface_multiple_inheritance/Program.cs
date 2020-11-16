using System;

namespace _03_Example_Interface_multiple_inheritance
{
    interface IAccount
    {
        int CurrentSum { get; }  // Поточна сума на рахунку
        void Put(int sum);       // Покласти гроші на рахунок
        void Withdraw(int sum);  // Взяти з рахунку
    }
    interface IClient
    {
        string Name { get; set; }
    }
    class Client : IAccount, IClient
    {
        int _sum; // Змінна для зберігання суми
        public string Name { get; set; }
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }

        public int CurrentSum { get { return _sum; } }

        public void Put(int sum) { _sum += sum; }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Client client = new Client("Tom", 200);
            client.Put(30);
            Console.WriteLine($"client.CurrentSum = {client.CurrentSum}"); //230

            client.Withdraw(100);
            Console.WriteLine($"client.CurrentSum = {client.CurrentSum}"); //130

            // Всі об'єкти Client є об'єктами IAccount 
            IAccount account = new Client("Том", 200);
            account.Put(200);
            Console.WriteLine($"account.CurrentSum = {account.CurrentSum}"); // 400

            // Не всі об'єкти IAccount є об'єктами Client, 
            // необхідно явне приведення
            Client client2 = (Client) account;
            // Інтерфейс IAccount не має властивості Name, 
            // необхідно явне приведення
            string clientName = ((Client)account).Name;

            Console.ReadKey();
        }
    }
}
