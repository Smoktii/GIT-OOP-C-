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
        static User()
        {
            Console.WriteLine("Викликається статичний конструктор!");
            counter = 10;
        }
        public static decimal Counter
        {
            get { return counter; }
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

            Console.WriteLine($"Програма починає виконання");

            // Console.WriteLine($"User.Counter = {User.Counter}"); // Викликається статичний конструктор!

            Console.WriteLine($"Cтворення об'єкту user1");
            User user1 = new User();    // Викликається статичний конструктор!
            Console.WriteLine($"Cтворення об'єкту user2");
            User user2 = new User();
            Console.WriteLine($"Cтворення об'єкту user3");
            User user3 = new User();
            Console.WriteLine($"Cтворення об'єкту user4");
            User user4 = new User();
            Console.WriteLine($"Cтворення об'єкту user5");
            User user5 = new User();

            User.DisplayCounter(); // 5

            Console.ReadKey();
        }
    }
}
