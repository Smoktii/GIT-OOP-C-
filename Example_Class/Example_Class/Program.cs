using System;

namespace Example_Class
{
    class Person
    {
        public string name; // ім'я
        private int age;     // вік

        public void GetInfo()
        {
            Console.WriteLine($"ім'я: {name}  вік: {age}");
        }

        public int SetAge(int a)
        {
            if (a >= 0)
                age = a;
            return 1;
        }
        public int GetAge()
        {
            return age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Person tom = new Person();
            tom.GetInfo();      // ім'я: вік: 0

            tom.name = "Tom";
            // tom.age = 34;
            tom.SetAge(34);

            tom.GetInfo();  // ім'я: Tom вік: 34
            Console.ReadKey();
        }
    }
}
