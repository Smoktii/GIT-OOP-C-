using System;

namespace _02_Example_Applied_Aspects_null_if
{
    class User
    {
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
 
            User user = new User();
            // System.NullReferenceException: "Object reference not set to an instance of an object."
            // Console.WriteLine($"user.Phone.Company.Name = {user.Phone.Company.Name}");

            // В даному випадку властивість Phone не визначена, буде за замовчуванням 
            // мати значення null.Тому ми зіткнемося з виключенням NullReferenceException.
            // Щоб уникнути цієї помилки ми могли б використовувати умовну конструкцію 
            // для перевірки на null:

            // Variant 1
            if (user != null)
            {
                if (user.Phone != null)
                {
                    if (user.Phone.Company != null)
                    {
                        string companyName1 = user.Phone.Company.Name;
                        Console.WriteLine($"user.Phone.Company.Name = {companyName1}"); 
                    }
                }
            }

            // Variant 2
            if (user != null && user.Phone != null && user.Phone.Company != null)
            {
                string companyName2 = user.Phone.Company.Name;
                Console.WriteLine($"user.Phone.Company.Name = {companyName2}");
            }

            // Variant 3
            string companyName3 = user?.Phone?.Company?.Name;
            Console.WriteLine($"user?.Phone?.Company?.Name = {companyName3}");

            // Variant 4
            string companyName4 = user?.Phone?.Company?.Name ?? "не встановлено";
            Console.WriteLine($"user?.Phone?.Company?.Name ?? 'не встановлено' = {companyName4}");

            Console.WriteLine($"End of Programm");
            Console.ReadKey();
        }
    }
}
