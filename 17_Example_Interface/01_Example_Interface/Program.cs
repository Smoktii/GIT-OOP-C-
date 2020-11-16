using System;

namespace _01_Example_Interface
{
    interface IMovable
    {
        // константа мінімальна швидкість
        public const int minSpeed = 0;
        // статична змінна максимальна швидкість                             
        private static int maxSpeed = 60;
        // Визначимо відповідну властивість по замовчуванню
        static int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }
        static double GetTime(double distance, double speed)
        {
            return (distance / speed);
        }
        // метод рух
        public void Move()
        {
            Console.WriteLine("Walking");
        }
        // властивість назва 
        protected internal string Name { get; set; }
        // визначення делегата для події
        public delegate void MoveHandler(string message);
        // подія руху
        public event MoveHandler MoveEvent; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            // ! Помилка, так робити не можна !!!
            // IMovable m = new IMovable(); 

            Console.WriteLine($"IMovable.MaxSpeed = {IMovable.MaxSpeed}");

            IMovable.MaxSpeed = 65;
            Console.WriteLine($"IMovable.MaxSpeed = {IMovable.MaxSpeed}");
            double time = IMovable.GetTime(100, 10);
            Console.WriteLine($"time = IMovable.GetTime(100, 10) = {time}");

            Console.ReadKey();
        }
    }
}
