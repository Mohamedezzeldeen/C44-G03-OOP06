namespace C44_G03_OOP06
{
    #region V05
    internal class Employee : ICloneable, IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public Employee()
        {

        }

        public object Clone()
        {
            return new Employee(this);
            //return new Employee 
            //{
            //    Id = this.Id, 
            //    Name = this.Name, 
            //    Salary = this.Salary 
            //};
        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary:c}";
        }

        #region V06
        public int CompareTo(Employee? other)
        {
            // Emp01.CompareTo(other)
            // 1  => This.Salary > other.Salary
            // -1 => This.Salary < other.Salary
            // 0

            //if (this.Salary > other?.Salary)
            //    return 1;
            //else if (this.Salary < other?.Salary)
            //    return -1;
            //else
            //    return 0;

            return this.Salary.CompareTo(other?.Salary);
        }

        //public int CompareTo(object? obj)
        //{
        //    throw new NotImplementedException();
        //} 
        #endregion

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V01

            #region Shallow Copy and Deep Copy

            #region Array of Value type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"HashCode of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of Arr02 = {Arr02.GetHashCode()}"); //18643596

            #region Shallow Copy
            //Arr02 = Arr01;  // Shallow Copy
            //                // Copy Value of Arr01 To Arr02
            //                // Copy Addresses - Happened in Stack
            //                // [Arr01 - Arr02] => Have Same Value
            //                // [Arr01 - Arr02] => Refer Same Object

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HashCode of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of Arr01 = {Arr02.GetHashCode()}"); //54267293

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1

            //Arr01[0] = 100;
            //Console.WriteLine("After Changing");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //100 
            #endregion

            #region Deep Copy
            //object obj = Arr02;
            //obj = 10;
            //obj = 10.2;
            //obj = true;

            //Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //                              // Happened in Heap
            //                              // Create New object with Different and new identity then return it
            //                              // the New Object will have the same object state [Data] of Caller [Arr01]

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode of Arr01 = {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of Arr02 = {Arr02.GetHashCode()}"); //33574638

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1

            //Arr01[0] = 100;
            //Console.WriteLine("After Changing");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}"); //1 
            #endregion


            #endregion

            #endregion

            #endregion

            #region V02

            #region Shallow Copy and Deep Copy

            #region Array Of Reference Type [string]

            //string[] names01 = { "Omar", "Amr" };
            //string[] names02 = new string[2];

            //Console.WriteLine($"HashCode Of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of names02 = {names02.GetHashCode()}");

            #region Shallow Copy
            //names02 = names01;   // Shallow Copy
            //                     // Copy Value names01 => names02
            //                     // [names01 - names02] => Have Same Value
            //                     // [names01 - names02] => Refer to Same Object

            //Console.WriteLine("After Shallow Copy ");
            //Console.WriteLine($"HashCode Of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            //names01[0] = "Salma";
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}"); 
            #endregion

            #region Deep Copy

            //names02 = (string[])names01.Clone(); // Deep Copy

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of names02 = {names02.GetHashCode()}");
            //Console.WriteLine($"names01[0] = {names01[0]}"); // omar
            //Console.WriteLine($"names02[0] = {names02[0]}"); // omar

            //names01[0] = "Salma";
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}"); //Salma
            //Console.WriteLine($"names02[0] = {names02[0]}"); //omar


            #endregion

            #endregion

            #endregion

            #endregion

            #region V03

            #region Shallow Copy and Deep Copy

            #region Array Of Reference Type [Stringbuilder]

            //StringBuilder[] names01 = new StringBuilder[1];
            //names01[0] = new StringBuilder();
            // null => Omar
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Omar");

            //names01[0] = "Omar";

            //names01[0].Append("omar"); // NullReferenceException

            //string[] names02 = new string[1];

            //names02[0] = "Omar"; // Syntax Suger

            //names02[0] = new string("Omar"); // كان الصح

            //StringBuilder[] names01 = [new StringBuilder("Omar")];
            //StringBuilder[] names02 = new StringBuilder[1];
            //Console.WriteLine($"HashCode Of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of names02 = {names02.GetHashCode()}");

            #region Shallow Copy
            //names02 = names01;
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"HashCode Of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}"); // omar
            //Console.WriteLine($"names02[0] = {names02[0]}"); // omar

            //names01[0].Append("Salma");
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}"); //omar Salma
            //Console.WriteLine($"names02[0] = {names02[0]}"); //omar Salma

            #endregion

            #region Deep Copy

            //names02 = (StringBuilder[])names01.Clone();
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"HashCode Of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"HashCode Of names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}"); // omar
            //Console.WriteLine($"names02[0] = {names02[0]}"); // omar

            //names01[0].Append(" Salma");
            //Console.WriteLine("After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");


            #endregion

            #endregion

            #endregion

            #endregion

            #region V05

            #region Built-in Interfaces

            #region Icloneable

            //Employee employee01 = new Employee() { Id = 10, Name = "Omar", Salary = 5000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "Mona", Salary = 8000 };
            //Console.WriteLine(employee01);
            //Console.WriteLine($"employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"employee02 => {employee02.GetHashCode()}");
            //// Array => Built in Class implement interface [ICloneable] => Clone

            ////employee02 = (Employee)employee01.Clone();

            ////employee02 = new Employee() 
            ////{
            ////    Id = employee01.Id,
            ////    Name = employee01.Name,
            ////    Salary = employee01.Salary
            ////};

            //employee02 = new Employee(employee01);

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"employee01 => {employee01.GetHashCode()}");
            //Console.WriteLine(employee02);
            //Console.WriteLine($"employee02 => {employee02.GetHashCode()}");

            #endregion

            #endregion

            #endregion

            #region V06

            #region Built-in Interfaces

            //int[] numbers = { 4, 5, 6, 9, 1, 2, 8, 5, 7 };

            //Array.Sort(numbers);
            //// Array => Built in Class implement interface [ICloneable] => Clone
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Employee[] employees =
            //{
            //    new Employee(){Id = 10, Name = "Omar", Salary = 6000},
            //    new Employee(){Id = 20, Name = "Ahmed", Salary = 10000},
            //    new Employee(){Id = 30, Name = "Sama", Salary = 4000},
            //    new Employee(){Id = 40, Name = "May", Salary = 5000},
            //};

            //Array.Sort(employees);
            //Array.Reverse(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            // InvalidOperationException

            #endregion

            #endregion
        }
    }
}
