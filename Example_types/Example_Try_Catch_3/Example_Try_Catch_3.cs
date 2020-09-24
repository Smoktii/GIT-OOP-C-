using System;

namespace Example_Try_Catch_3
{
    class Example_Try_Catch_3
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            // 1 приклад try без finally та catch без параметрів
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch 
            {
                Console.WriteLine("1: Виник виняток");
            }

            // 2 приклад try без finally та catch з параметром без змінної
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("2: Виник виняток DivideByZeroException");
            }

            // 3 приклад try без finally та catch з параметром без змінної
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"3: Виник виняток {ex.Message}");
            }

            // 4 повторний виклик винятка
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"4: Виник виняток {ex.Message} передаємо його далі в опрацювання");
                // throw;
            }

            // 5 сгенеруємо виняток DivideByZeroException
            try
            {
                int x = 5;
                int y = x / 1;
                throw new DivideByZeroException();
                //throw new Exception("Мій перший Exception");
                // throw new ArgumentException("My text!");
                // Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"5: Ми згенерували виняток {ex.Message} StackTrace = {ex.StackTrace}"); 
            }


            // 6 Catch фільтри винятків
            int x1 = 1;
            int y1 = 0;

            try
            {
                int result = x1 / y1;
            }
            catch (DivideByZeroException) when (y1 == 0)
            {
                Console.WriteLine("6: y не повинен дорівнювати 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"6: Ми згенерували виняток {ex.Message}");
            }

            // 7 Використання класу Exception
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"7: Виключення: {ex.Message}");
                Console.WriteLine($"7: Метод: {ex.TargetSite}");
                Console.WriteLine($"7: Стек викликів: {ex.StackTrace}");
            }

            Console.Read();

        }
    }
}
