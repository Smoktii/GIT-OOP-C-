using System;

namespace Example_types
{
    class Example_types
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Types!");

            // bool: зберігає значення true або false(логічні літерали).Представлений системним типом System.Boolean
            bool alive = true;
            System.Boolean isDead = false;

            // byte: зберігає ціле число від 0 до 255 і займає 1 байт.Представлений системним типом System.Byte
            byte bit1 = 1;
            byte bit2 = 102;
            // System.Byte bit3 = (byte) 501;

            // sbyte: хранит целое число от -128 до 127 и занимает 1 байт.Представлен системным типом System.Sbyte
            sbyte bit3 = -101;
            sbyte bit4 = 102;

            // short: зберігає ціле число від -32768 до 32767 і займає 2 байта.Представлен системним типом System.Int16
            short n1 = 1;
            short n2 = 102;

            // ushort: зберігає ціле число від 0 до 65535 і займає 2 байта.Представлен системним типом System.UInt16
            ushort n3 = 1;
            ushort n4 = 102;

            // int: зберігає ціле число від -2147483648 до 2147483647 і займає 4 байта.Представлен системним типом System.Int32.
            // Все цілочисельні літерали за замовчуванням представляють значення типу int.
            // Може бути заданий як в двоїчній, так і в шістнадцятирічній системі

            int a = 10;
            int b = 0b101;  // бінарна форма b = 5
            int c = 0xFF;   // шістнадцятирічна форма c = 255
            Console.WriteLine($"b = {b}");

            // uint: зберігає ціле число від 0 до 4294967295 і займає 4 байта.Представлений системним типом System.UInt32
            uint a2 = 10;
            uint b2 = 0b101;
            uint c2 = 0xFF;

            // long: зберігає ціле число від -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 і займає 8 байт.
            // Представлений системним типом System.Int64
            long a3 = -10;
            long b3 = 0b101;
            long c3 = 0xFF;

            // ulong: зберігає ціле число від 0 до 18 446 744 073 709 551 615 і займає 8 байт.Представлений системним типом System.UInt64
            ulong a4 = 500000000000UL; // ulong a4 = 10UL;
            ulong b4 = 0b101;
            ulong c4 = 0xFF;

            // float: зберігає число з плаваючою крапкою від -3.4 * 1038 до 3.4 * 1038 і займає 4 байта.
            // Представлений системним типом System.Single
            float a5 = (float) -3.4;
            float b5 = -3.4E-10F;

            // double: зберігає число з плаваючою крапкою від ± 5.0 * 10 - 324 до ± 1.7 * 10308 і займає 8 байта.
            // Представлений системним типом System.Double
            double a6 = -3.4;
            double b6 = -3.41212124252124252458E10;
            Console.WriteLine($"double b6 = {b6}");

            // decimal: зберігає десяткове дробове число. Якщо вживається без коми, має значення від ± 1.0 * 10 - 28 до ± 7.9228 * 1028, 
            // може зберігати 28 знаків після коми і займає 16 байт.Представлений системним типом System.Decimal
            decimal a7 = (decimal) -34121.2124252124252458;
            decimal b7 = -3.41212124252124252458E10M;
            Console.WriteLine($"decimal b7 = {b7}");

            // char: зберігає одиночний символ в кодуванні Unicode і займає 2 байта.Представлений системним типом System.Char.
            // Цьому типу відповідають символьні літерали:
            char a8 = 'A';
            char b8 = '\x5A';
            char c8 = '\u0420';

            // string: зберігає набір символів Unicode. Представлений системним типом System.String.
            // Цьому типу відповідають символьні літерали.
            string hello = "Hello";
            string word = "world";

            Console.WriteLine($"1: {hello} {word} {a7*3}!"); // інтерполяція строк https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation 
            Console.WriteLine( "2: {0} {1}!", hello, word);

            // object: може зберігати значення будь-якого типу даних і займає 4 байта на 32 - розрядної платформі і 8 байт на 64 - розрядної платформі.Представлений системним типом System.Object, який є базовим для всіх інших типів і класів.NET.
            object a9 = 22;
            object b9 = 3.14;
            object c9 = "hello code";

            // неявна типізація
            var helloNew = "Hell to World";
            var cNew = 20;

            Console.WriteLine(cNew.GetType().ToString());  // System.Int32
            Console.WriteLine(helloNew.GetType().ToString());  // System.String
            Console.WriteLine(b9.GetType().ToString());  // 
            Console.WriteLine(c9.GetType().ToString());  // 



            // Працює
            int a10;
            a10 = 20;

            // Не працює
            //var c10;
            //c10 = 20;

            // Не працює
            // var c = null;

            //Область видимості (контекст) змінних
           
        /* class Program // початок контексту класу
        {
            static int a = 9; // змінна рівня класу

            static void Main(string[] args) // початок контексту методу Main
            {
                int b = a - 1; // змінна рівня методу

                { // початок контексту блоку коду

                    int c = b - 1; // змінна рівня блоку коду

                }  // кінець контексту блоку коду, змінна з знищується

                //так не можна, змінна c визначена в блоці коду
                //Console.WriteLine(c);

                //так не можна, змінна d визначена в іншому методі
                //Console.WriteLine(d);

                Console.Read();

            } // кінець контексту методу Main, змінна b знищується

            void Display() // початок контексту методу Display
            {
                // змінна a визначена в контексті класу, тому доступна
                int d = a + 1;

            } // кінець Конекст методу Display, змінна d знищується

        } // кінець контексту класу, змінна a знищується
             */


        }
    }
}
