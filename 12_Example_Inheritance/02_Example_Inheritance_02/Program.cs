using System;

namespace _12_Example_Inheritance_01
{
    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Name = {_name}");
        }
    }
    class Employee : Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Name = {Name}, Salary = {Salary}");
        }
    }
    class EmployeeToString : Employee
    {
        // Перевизначення (перегрузка-переопределение)
        public override string ToString()
        {
            return "Name = " + Name + ", Salary = " + Salary;
        }
        // перевантаження ToString
        public string ToString(double SalaryParam)
        {
            if (Salary == SalaryParam)
                return "Так, у " + Name + " Salary = " + Salary;
            else
                return "Ні, у " + Name + " немає зарплатні Salary = " + SalaryParam;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;


            Person p = new Person { Name = "Tom" };
            Person pClone = p;
            Person pNew = new Person { Name = "Tom" };
            int i = 5, j = 5, k = 7;
            EmployeeToString Demo1 = new EmployeeToString { Name = "Demo1", Salary = 10000.00};
            Employee         Demo2 = new Employee         { Name = "Demo2", Salary = 20000.00 };

            // ToString () 
            Console.WriteLine($"ToString\n");

            Console.WriteLine($"Demo1.DisplayEmployee()");
            Demo1.DisplayEmployee();
            Console.WriteLine($"Demo2.DisplayEmployee()");  
            Demo2.DisplayEmployee();
            Console.WriteLine($"Demo1.ToString() {Demo1.ToString()}");
            Console.WriteLine($"Demo2.ToString() {Demo2.ToString()}");
            Console.WriteLine($"Demo1.ToString(15000.0) {Demo1.ToString(15000.0)}");
            Console.WriteLine($"Demo1.ToString(10000.0) {Demo1.ToString(10000.0)}");
            // Неможлива наступна строка. Чому? 
            // Console.WriteLine($"Demo2.ToString(15000.0) {Demo2.ToString(15000.0)}");

            // Equals (Object), Equals (Object, Object) 
            Console.WriteLine($"\nEquals\n");

            Console.WriteLine($"p.Equals(p) : {p.Equals(p)}");  // true
            Console.WriteLine($"p.Equals(pClone) : {p.Equals(pClone)}");  // true
            Console.WriteLine($"p = '{p.Name}', pNew = '{pNew.Name}'");  // Name = "Tom"
            Console.WriteLine($"p.Equals(pNew) : {p.Equals(pNew)}");  // false !!!

            Console.WriteLine($"i = {i}, j = {j}, k = {k}");  // Name = "Tom"
            Console.WriteLine($"p.Equals(i) : {p.Equals(i)}");  // No ERROR, false 
            Console.WriteLine($"i.Equals(i) : {i.Equals(i)}");  // true
            Console.WriteLine($"i.Equals(j) : {i.Equals(j)}");  // true
            Console.WriteLine($"i.Equals(k) : {i.Equals(k)}");  // false
            Console.WriteLine($"Використання з двома праметрами object.Equals(i, k) : {object.Equals(i, k)}");  // false


            // ReferenceEquals (object objA, object objB) 
            Console.WriteLine($"\nReferenceEquals\n");  

            Console.WriteLine($"object.ReferenceEquals(i,i) : {object.ReferenceEquals(i, i)}");  // false!!!
            Console.WriteLine($"object.ReferenceEquals(i,j) : {object.ReferenceEquals(i, j)}");  // false!!!
            Console.WriteLine($"object.ReferenceEquals(p,p) : {object.ReferenceEquals(p, p)}");  // true
            Console.WriteLine($"object.ReferenceEquals(p,pClone) : {object.ReferenceEquals(p, pClone)}");  // true
            Console.WriteLine($"object.ReferenceEquals(p,pNew) : {object.ReferenceEquals(p, pNew)}");   // false

            String s1 = "String1";
            String s2 = "String1";
            // s1 та s2 - інтерновані
            Console.WriteLine($"\ns1 = '{s1}', s2 = '{s2}' - інтерновані");
            Console.WriteLine($"Object.ReferenceEquals(s1, s2) = {Object.ReferenceEquals(s1, s2)}");

            // s1 та s2 - не інтерновані
            String suffix = "1";
            String s3 = "String" + suffix;
            String s4 = "String" + suffix;
            Console.WriteLine($"s3 = '{s3}', s4 = '{s4}' - не інтерновані");
            Console.WriteLine($"Object.ReferenceEquals(s3, s4) = {Object.ReferenceEquals(s3, s4)}");

            // GetHashCode 
            Console.WriteLine($"\nGetHashCode\n");

            Console.WriteLine($"\nТипи значень"); 
            Console.WriteLine($"i = {i}, j = {j}, k = {k}");  
            Console.WriteLine($"i.GetHashCode() = {i.GetHashCode()}");
            Console.WriteLine($"j.GetHashCode() = {j.GetHashCode()}");
            Console.WriteLine($"k.GetHashCode() = {k.GetHashCode()}");

            Employee e = new Employee { Name = "Tom_Employee", Salary = 10000.00 };
            Employee eReference = e;
            Employee eCopyData = new Employee { Name = "Tom_Employee", Salary = 10000.00 };
            Employee eSecond = new Employee { Name = "Tom_Second", Salary = 20000.00 };

            Console.WriteLine($"\nПосилальні типи"); 
            Console.WriteLine($"e.GetHashCode() = {e.GetHashCode()}");
            Console.WriteLine($"eReference.GetHashCode() = {eReference.GetHashCode()}");
            Console.WriteLine($"eCopyData.GetHashCode() = {eCopyData.GetHashCode()}");
            Console.WriteLine($"eSecond.GetHashCode() = {eSecond.GetHashCode()}");

            // GetType 

            Console.WriteLine($"\nGetType\n");

            Person p1 = new Person { Name = "Tom" };
            Console.WriteLine($"p1.GetType() = {p1.GetType()}");
            Console.WriteLine($"p1.GetType().Equals(typeof(Person)) = {p1.GetType().Equals(typeof(Person))}");

            p1 = new Employee { Name = "Sam", Salary = 15000.00 };
            Console.WriteLine($"p1.GetType() (p1 = new Employee) = {p1.GetType()}");
            Console.WriteLine($"p1.GetType().Equals(typeof(Person)) = {p1.GetType().Equals(typeof(Person))}");
            Console.WriteLine($"p1 is Employee = {p1 is Employee}");  // true
            Console.WriteLine($"p1 is Person = {p1 is Person}");      // true
            Console.WriteLine($"e is Person = {e is Person}");        // true
            Console.WriteLine($"e is EmployeeToString = {e is EmployeeToString}"); // true

            Console.ReadKey();
        }
    }
}
