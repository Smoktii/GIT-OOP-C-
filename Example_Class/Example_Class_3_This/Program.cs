using System;

namespace Example_Class
{
    class Person
    {
        public string name; // ім'я
        public int age;     // вік

        public Person() : this("Невідомо")
        {
        }
        public Person(string name) : this(name, 18)
        {
        }
        public Person(string name, int age)
        {
            /******************************* 
            І щоб розмежувати параметри і поля класу, до полів класу звернення йде через ключове слово this.
            Так, в вираженні this.name = name; перша частина this.name означає, що name - це поле поточного класу, 
            а не назву параметра name. Якби параметри і поля називалися по-різному, то використовувати слово this було б необов'язково.
            ********************************/ 
            this.name = name;
            this.age = age;
            this.ShowThis();
        }

        public void ShowThis()
        {
            Console.WriteLine($"In ShowThis() ім'я: {name}  вік: {age}");
        }
        
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

            Person tom = new Person();          // виклик 1-го конструктора без параметрів
            Person bob = new Person("Bob");     // виклик 2-го конструктора з одним параметрім
            Person sam = new Person("Sam", 25); // виклик 3-го конструктора з двумя параметрами


            bob.GetInfo();          // ім'я: Bob  вік: 18
            tom.GetInfo();          // ім'я: Невідомо  вік: 18
            sam.GetInfo();          // ім'я: Sam  вік: 25

            Console.ReadKey();
        }
    }
}
