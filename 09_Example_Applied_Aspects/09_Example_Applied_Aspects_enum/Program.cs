using System;

namespace _09_Example_Applied_Aspects_enum
{
    enum MyDays
    {
        Monday,     // цей елемент дорівнює 0
        Tuesday,    // цей елемент дорівнює 1
        Wednesday,  // цей елемент дорівнює 2
        Thursday,   // цей елемент дорівнює 3
        Friday,     // цей елемент дорівнює 4
        Saturday,   // цей елемент дорівнює 5
        Sunday      // цей елемент дорівнює 6
    }

    enum MyTime : byte
    {
        Morning,    // цей елемент дорівнює 0
        Afternoon,  // цей елемент дорівнює 1
        Evening,    // цей елемент дорівнює 2
        Night       // цей елемент дорівнює 3
    }

    enum MyOperation
    {
        Add = 1,   // кожен наступний елемент за замовчуванням збільшується на одиницю
        Subtract, // цей елемент дорівнює 2
        Multiply, // цей елемент дорівнює 3
        Divide    // цей елемент дорівнює 4
    }

    enum MyOperationVer2
    {
        Add = 2,
        Subtract = 4,
        Multiply = 8,
        Divide = 16
    }


    class Program
    {
        enum MyColor
        {
            White = 1,
            Black = 2,
            Green = 2,
            Blue = White // Blue = 1
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            MyDays myDay;
            myDay = MyDays.Friday;
            Console.WriteLine($"myDay = {myDay}"); // MyDays.Friday 
            Console.WriteLine($"MyDays.Friday = {MyDays.Friday}"); // MyDays.Friday 
            Console.WriteLine($"(int) myDay = {(int) myDay}"); // 4

            MyOperation ver1;
            ver1 = MyOperation.Subtract;
 
            MyOperationVer2 ver2;
            // ERROR - не можна привласнювати неузгоджені значення іншого типу enum
            // ver2 = MyOperation.Subtract;
            // ERROR - не можна привласнювати явне числове значення int 
            // ver2 = 2;
            ver2 = MyOperationVer2.Subtract;

            Console.WriteLine($"ver1 = {ver1}, ver2 = {ver2}"); // MyOperation.Subtract
            Console.WriteLine($"(int) ver1 = {(int) ver1}, (int) ver2 = {(int) ver2}"); // MyOperation.Subtract

            MyOperationVer2 ver3; 
            ver3 = (MyOperationVer2) 3; // Помилка такого значення не існує
            Console.WriteLine($"ver3 = (MyOperationVer2)3 = {ver3}"); 

            Console.ReadKey();
        }
    }
}
