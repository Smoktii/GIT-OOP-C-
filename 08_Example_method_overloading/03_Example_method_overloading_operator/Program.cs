using System;

namespace _03_Example_method_overloading_operator
{
    class ExampleCounter
    {
        private int myValue;
        public int MyValue
        {
            get
            { 
                return myValue; 
            }
            set
            {
                myValue = value;
            }
        }
        public ExampleCounter(int a)
        {
            MyValue = a;
            // myValue = a;
        }
        public static ExampleCounter operator +(ExampleCounter c1, ExampleCounter c2)
        {
            return new ExampleCounter (c1.MyValue + c2.MyValue);
        }
        public static bool operator > (ExampleCounter c1, ExampleCounter c2)
        {
            return (c1.MyValue > c2.MyValue);
        }
        // Спробувати закоментувати парний оператор
        public static bool operator < (ExampleCounter c1, ExampleCounter c2)
        {
            return (c1.MyValue < c2.MyValue);
        }
        public static int operator +(ExampleCounter c1, int val) // operator+(ExampleCounter , int )
        {
            return c1.MyValue + val;
        }
        public static int operator +(int val, ExampleCounter c1) // operator+(int, ExampleCounter)
        {
            return c1.MyValue + val;
        }
        // Доцільно при перевантаженні не змінювати ті об'єкти, 
        // які передаються в оператор через параметри.
        // НЕДОЦІЛЬНО
        public static ExampleCounter operator ++(ExampleCounter c1)
        {
            c1.MyValue += 100;
            return c1;
        }
        // ДОЦІЛЬНО
        public static ExampleCounter operator --(ExampleCounter c1)
        {
            return new ExampleCounter(c1.MyValue - 10); 
        }
        public static bool operator true(ExampleCounter c1)
        {
            return c1.MyValue != 0;
        }
        public static bool operator false(ExampleCounter c1)
        {
            return c1.MyValue == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            ExampleCounter c1 = new ExampleCounter(21);
            ExampleCounter c2 = new ExampleCounter(37);
            Console.WriteLine($"c1 = {c1.MyValue}"); // 21
            Console.WriteLine($"c2 = {c2.MyValue}"); // 37

            bool result = c1 > c2;
            Console.WriteLine($"Result c1 > c2 is {result}"); // false

            // Чи можлива така строчка? 
            // bool result2 = (c1 >= c2);

            ExampleCounter c3 = c1 + c2;
            Console.WriteLine($"c3 = c1 + c2 = {c3.MyValue}"); // 21 + 37 = 58

            int myInt = c1 + 27; // 48
            int myInt2 = 27 + c1; // 48
            Console.WriteLine($"myInt = c1 + 27 = {myInt}, myInt2 = 27 + c1 = {myInt2}"); // 48

            c2++;   // c2 = 37 + 100 = 137
            Console.WriteLine($"c2++ = {c2.MyValue}"); // 137

            c2--;   // c2 = 137 - 10 = 127
            //c2 = c2--;
            Console.WriteLine($"c2-- = {c2.MyValue}"); // 127

            // При цьому нам не треба визначати окремо оператори для 
            // префіксного і для постфіксного інкремента (а також декремента)
            Console.WriteLine($"(++c2).MyValue = {(++c2).MyValue}"); // 127 + 100 = 227
            // ПОЯСНИТИ ЧОМУ РІЗНИЦЯ!!! 
            Console.WriteLine($"(c2++).MyValue = {(c2++).MyValue}, c2.MyValue = {c2.MyValue}"); // 227 + 100 = 327
            Console.WriteLine($"(c2--).MyValue = {(c2--).MyValue}, c2.MyValue = {c2.MyValue}"); // 327 - 10 = 317
            Console.WriteLine($"(--c2).MyValue = {(--c2).MyValue}"); // 317 - 10 = 307

            ExampleCounter counter = new ExampleCounter(0);
            if (counter)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

            Console.ReadKey();
        }
    }
}
