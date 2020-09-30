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
        public void publicMethod()  { Console.WriteLine($"publicVar = {publicVar}");  }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyExample state1 = new MyExample();

            // привласнити значення змінної defaultVar у нас не вийде,
            // так як вона має модифікатор private і клас Program її не бачить
            state1.defaultVar = 5; // Помилка, отримати доступ не можна

            // те ж саме відноситься і до змінної privateVar
            state1.privateVar = 5; // Помилка, отримати доступ не можна

            // призначити значення змінної protectedPrivateVar не вийде,
            // так як клас Program не є класом-спадкоємцем класу MyExample
            state1.protectedPrivateVar = 5; // Помилка, отримати доступ не можна

            // привласнити значення змінної protectedVar теж не вийде,
            // так як клас Program не є класом-спадкоємцем класу MyExample
            state1.protectedVar = 5; // Помилка, отримати доступ не можна

            // змінна internalVar з модифікатором internal доступна з будь-якого місця поточного проекту
            // тому спокійно присвоюємо їй значення
            state1.internalVar = 5;

            // змінна protectedInternalVar так само доступна з будь-якого місця поточного проекту
            state1.protectedInternalVar = 5;

            // змінна publicVar загальнодоступна
            state1.publicVar = 5;
        }
    }

}
