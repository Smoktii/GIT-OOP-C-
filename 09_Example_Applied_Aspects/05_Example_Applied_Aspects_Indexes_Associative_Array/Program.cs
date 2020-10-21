using System;

namespace _05_Example_Applied_Aspects_Indexes_Associative_Array
{
    class User
    {
        // Визначення private полей
        string name;
        string email;
        string phone;

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name":  return "Mr/Ms. " + name;
                    case "email": return email;
                    case "phone": return phone;
                    default:      return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            User tom = new User();
            tom["name"] = "Tom";
            tom["email"] = "GreatTom@gmail.com";

            Console.WriteLine($"tom['name'] = {tom["name"]}");
            Console.WriteLine($"tom['email'] = {tom["email"]}");
            Console.WriteLine($"tom['phone'] = {tom["phone"]}");  // Що буде?

            Console.ReadKey();
        }
    }
}
