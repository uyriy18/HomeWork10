using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Point2d<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2d(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2d()
        {
            X = default;
            Y = default;
        }
        public override string ToString()
        {
            return $"x = {X}, y = {Y}";
        }
    }
    public class Point3d : Point2d<int>
    {
        
        public int Z { get; set; }
        public Point3d(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public Point3d() : base()
        {
            Z = default;
        }
        public override string ToString()
        {
            return base.ToString() + $", z = {Z}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3d p1 = new Point3d(12, 3, 8);
            Console.WriteLine("Enter point's coordinates : ");
            Console.Write("X = ");
            p1.X = int.Parse(Console.ReadLine());
            Console.Write("Y = ");
            p1.Y = int.Parse(Console.ReadLine());
            Console.Write("Z = ");
            p1.Z = int.Parse(Console.ReadLine());
            Console.WriteLine(p1);



        }
    }
}
