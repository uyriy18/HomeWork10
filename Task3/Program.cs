using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Line<T>
    {
        public T X1 { get; set; }
        public T Y1 { get; set; }
        public T X2 { get; set; }
        public T Y2 { get; set; }

        public override string ToString()
        {
            return $"Line (({X1}, {Y1}), ({X2} ,{Y2}))";
        }
        public Line(T x, T y)
        {
            X1 = x;
            Y1 = y;
        }
        public Line(T x1, T y1, T x2, T y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public Line()
        {
            X1 = default;
            Y1 = default;
            X2 = default;
            Y2 = default;

        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Line<int> l1 = new Line<int>();
            Line<int> l2 = new Line<int>(12,16);
            Line<double> l3 = new Line<double>(8.2, 6.4, 3.8, 12.1);
            Console.WriteLine($"l1 = {l1}, l2 = {l2}, l3 ={l3}");


        }
    }
}
