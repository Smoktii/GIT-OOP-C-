using System;

namespace Example_Static_Counter
{
    class User
    {
        private static int counter = 0;
        public User()
        {
            counter++;
        }

        public static void DisplayCounter()
        {
            Console.WriteLine($"Створено {counter} об'єктів User");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();

            User.DisplayCounter(); // 5

            Console.ReadKey();
        }
    }
}
