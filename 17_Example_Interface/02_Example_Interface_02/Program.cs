using System;

namespace _02_Example_Interface_02
{
    interface IMovable
    {
        void Move();
        void MoveDef()
        {
            Console.WriteLine("Walking");
        }
    }
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("людина йде");
        }
    }
    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина їде");
        }
        public void MoveDef()
        {
            Console.WriteLine("Driving");
        }
    }
    class Program
    {   /* 
         * На момент написання коду ми можемо не знати, 
         * що це буде за об'єкт - якийсь клас або структура. 
         * Єдине, в чому ми можемо бути впевнені, що цей об'єкт 
         * обов'язково реалізує метод Move і ми можемо викликати 
         * цей метод.
         */ 
        static void Action(IMovable movable)
        {
            movable.Move();
        }

        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;
 
            Person person = new Person();
            Car car = new Car();
            Action(person);
            Action(car);

            Console.WriteLine("MoveDef()");
            car.MoveDef();
            // Помилка!
            // person.MoveDef();
            
            // Все Ок
            ((IMovable)person).MoveDef();

            Console.ReadKey();
        }
    }
}
