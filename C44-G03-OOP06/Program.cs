namespace C44_G03_OOP06
{
    #region First Project
    //public class Point3D : IComparable<Point3D>, ICloneable
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z { get; set; }

    //    #region 1. Define 3D Point Class and the basic Constructors (use chaining in constructors)
    //    public Point3D()
    //    {
    //        X = 0;
    //        Y = 0;
    //        Z = 0;
    //    }

    //    public Point3D(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = 0;
    //    }

    //    public Point3D(int x, int y, int z)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;
    //    }
    //    #endregion

    //    #region 2. Override the ToString Function
    //    public override string ToString()
    //    {
    //        return $"Point Coordinates: ({X}, {Y}, {Z})";
    //    }
    //    #endregion

    //    #region 3. Read from the User the Coordinates for 2 points P1, P2

    //    public void ReadPoint()
    //    {
    //        int value;
    //        bool valid;

    //        do
    //        {
    //            Console.Write("X: ");
    //            valid = int.TryParse(Console.ReadLine(), out value);
    //            if (valid) X = value;
    //            else Console.WriteLine("Invalid input, please enter a number.");
    //        } while (!valid);

    //        do
    //        {
    //            Console.Write("Y: ");
    //            valid = int.TryParse(Console.ReadLine(), out value);
    //            if (valid) Y = value;
    //            else Console.WriteLine("Invalid input, please enter a number.");
    //        } while (!valid);

    //        do
    //        {
    //            Console.Write("Z: ");
    //            valid = int.TryParse(Console.ReadLine(), out value);
    //            if (valid) Z = value;
    //            else Console.WriteLine("Invalid input, please enter a number.");
    //        } while (!valid);
    //    }

    //    #endregion

    //    #region 4. Try to use ==
    //    public override bool Equals(object obj)
    //    {
    //        Point3D other = (Point3D)obj;
    //        if (other == null)
    //            return false;
    //        return X == other.X && Y == other.Y && Z == other.Z;
    //    }
    //    public override int GetHashCode()
    //    {
    //        return (X, Y, Z).GetHashCode();
    //    }
    //    #endregion

    //    #region 5. Define an array of points and sort this array based on X & Y coordinates
    //    public int CompareTo(Point3D other)
    //    {
    //        if (X != other.X) return X.CompareTo(other.X);
    //        if (Y != other.Y) return Y.CompareTo(other.Y);
    //        return Z.CompareTo(other.Z);
    //    }
    //    #endregion

    //    #region 6. Implement ICloneable interface to be able to clone the object
    //    public object Clone()
    //    {
    //        return new Point3D(X, Y, Z);
    //    }
    //    #endregion
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            #region 3. Read from the User the Coordinates for 2 points P1, P2
            //Console.WriteLine("Enter coordinates for Point P1:");
            //Point3D p1 = new Point3D();
            //p1.ReadPoint();

            //Console.WriteLine("Enter coordinates for Point P2:");
            //Point3D p2 = new Point3D();
            //p2.ReadPoint();
            #endregion

            #region 2. Override the ToString Function
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            #endregion

            #region 4. Try to use ==
            //if (p1.Equals(p2))
            //    Console.WriteLine("Points are equal");
            //else
            //    Console.WriteLine("Points are NOT equal");
            #endregion

            #region 5. Define an array of points and sort this array based on X & Y coordinates
            //    List<Point3D> points = new List<Point3D>
            //{
            //    p1,
            //    p2,
            //    new Point3D(4, 2, 9),
            //    new Point3D(1, 2, 7),
            //    new Point3D(0, 0, 0)
            //};

            //    Console.WriteLine("\nBefore sorting:");
            //    foreach (var point in points)
            //        Console.WriteLine(point.ToString());

            //    points.Sort();

            //    Console.WriteLine("\nAfter sorting:");
            //    foreach (var point in points)
            //        Console.WriteLine(point.ToString());
            #endregion

            #region 6. Implement ICloneable interface to be able to clone the object
            //Point3D clonedP1 = (Point3D)p1.Clone();
            //clonedP1.X = 99;

            //Console.Write("\nOriginal P1: ");
            //Console.WriteLine(p1.ToString());

            //Console.Write("Cloned P1 (modified X): ");
            //Console.WriteLine(clonedP1.ToString());
            #endregion

            #endregion
        }
    }
}
