using System;

namespace Example_class_3_access_modifiers
{
    public class MyExample
    {
        // все одно, що private int defaultVar;
        int defaultVar;
        // поле доступно лише з поточного класу
        private int privateVar;
        // доступно з поточного класу і похідних класів, які визначені в цьому ж проекті
        protected private int protectedPrivateVar;
        // доступно з поточного класу і похідних класів
        protected int protectedVar;
        // доступно в будь-якому місці поточного проекту
        internal int internalVar;
        // доступно в будь-якому місці поточного проекту і з класів-спадкоємців в інших проектах
        protected internal int protectedInternalVar;
        // доступно в будь-якому місці програми, а також для інших програм і збірок
        public int publicVar;

        // за замовчуванням має модифікатор private
        void defaultMethod() { Console.WriteLine($"defaultVar = {defaultVar}"); }

        // метод доступний тільки з поточного класу
        private void privateMethod() { Console.WriteLine($"privateVar = {privateVar}"); }

        // доступність з поточного класу и похідніх класів, Які візначені в цьом ж проекті
        protected private void protectedPrivateMethod() { Console.WriteLine($"protectedPrivateVar = {protectedPrivateVar}"); }

        // доступність з поточного класу и похідніх класів
        protected void protectedMethod() { Console.WriteLine($"protectedVar = {protectedVar}"); }

        // доступний в будь-якому місці поточного проекту
        internal void internalMethod() { Console.WriteLine($"internalVar = {internalVar}"); }

        // доступний в будь-якому місці поточного проекту і з класів-спадкоємців в інших проектах
        protected internal void protectedInternalMethod() { Console.WriteLine($"protectedInternalVar = {protectedInternalVar}"); }

        // доступний в будь-якому місці програми, а також для інших програм і збірок
        public void publicMethod() { Console.WriteLine($"publicVar = {publicVar}"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyExample state1 = new MyExample();

            state1.defaultMethod(); //Помилка, отримати доступ не можна

            state1.privateMethod(); // ОПомилка, отримати доступ не можна

            state1.protectedPrivateMethod(); // Помилка, отримати доступ не можна

            state1.protectedMethod(); // Помилка, отримати доступ не можна

            state1.internalMethod();    // Ok

            state1.protectedInternalMethod();  // Ok

            state1.publicMethod();      // Ok
        }
    }

}
