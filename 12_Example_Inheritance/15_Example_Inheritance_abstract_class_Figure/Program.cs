using System;

namespace _15_Example_Inheritance_abstract_class_Figure
{
    // абстрактний клас фігури
    abstract class Figure
    {
        // назва фігури
        public string NameFigure { get; set; }
        // абстрактний метод для отримання периметра
        public abstract float Perimeter();
        // абстрактний метод для отримання площі
        public abstract float Area();
    }
    // похідний клас прямокутника
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
            NameFigure = "Прямокутник";
        }
        // перевизначення розрахунку периметра
        public override float Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        // перевизначення розрахунку площі
        public override float Area()
        {
            return Width * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Rectangle o1, o2;
            o1 = new Rectangle(5, 10);
            o2 = new Rectangle(50, 100);
            
            Console.WriteLine($"o1.GetType() = {o1.GetType()}, o1.Width = {o1.Width}, o1.Height = {o1.Height}");
            Console.WriteLine($"o1.NameFigure = {o1.NameFigure}, o1.Perimeter = {o1.Perimeter()}, o1.Area {o1.Area()}");

            Console.WriteLine($"o2.GetType() = {o2.GetType()}, o2.Width = {o2.Width}, o2.Height = {o2.Height}");
            Console.WriteLine($"o2.NameFigure = {o2.NameFigure}, o2.Perimeter = {o2.Perimeter()}, o2.Area {o2.Area()}");

            Console.ReadKey();
        }
    }
}
