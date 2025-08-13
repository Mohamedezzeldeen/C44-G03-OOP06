namespace C44_G03_OOP06
{
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
        }
    }
}
