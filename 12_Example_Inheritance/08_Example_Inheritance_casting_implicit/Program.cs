using System;

namespace _08_Example_Inheritance_casting_implicit
{
    class Counter
    {
        public int Seconds { get; set; }
        // Явне перетворення int до Counter
        public static implicit operator Counter(int x)
        {
            return new Counter { Seconds = x };
        }
        // Явне перетворення Counter до int
        public static explicit operator int(Counter counter)
        {
            return counter.Seconds;
        }
        // Явне перетворення timer до Counter
        public static explicit operator Counter(Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new Counter { Seconds = h + m + timer.Seconds };
        }
        // Явне перетворення Counter до timer
        public static implicit operator Timer(Counter counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds % 3600) / 60;
            int s = counter.Seconds % 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }
    }
    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
            
            Counter counter1 = new Counter { Seconds = 23 };

            int x = (int)counter1; // Явне перетворення з Counter до int
            Console.WriteLine($"int x = {x}"); // 23

            Counter counter2 = x;  // Неявне перетворення з int до Counter 
            Console.WriteLine($"counter2.Seconds = {counter2.Seconds}");  // 23

            Counter counterTimer1 = new Counter { Seconds = 115 };

            Timer timer = counterTimer1;
            Console.WriteLine($"timer - {timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55

            Counter counterTimer2 = (Counter)timer;
            Console.WriteLine($"counterTimer2 = {counterTimer2.Seconds}" );  //115

            Console.ReadKey();
        }
    }
}
