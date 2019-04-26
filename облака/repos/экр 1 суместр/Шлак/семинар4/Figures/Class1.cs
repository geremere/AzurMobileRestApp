using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Point
    {
        public double X{ get; set; }
        public double Y { get; set; }
        virtual public void ConsoleDisplay()
        {
            Console.WriteLine("Point: X={0}, Y={1}", X, Y);
        }
        virtual public double Area
        {
            get { return 0; }
        }

    }

    public class Circle : Point
    {      
        double rad;     
        public Circle(int xi, int yi, double r)
        {
            X = xi; Y = yi; rad = r;
        }
        
        public double Rad
        {
            get { return rad; }
            set { rad = value; }
        }
        
        public double Len
        {
            get { return 2 * rad * Math.PI; }
        }
    
        override public double Area { get { return rad * rad * Math.PI; } }
        override public void ConsoleDisplay()
        { 
            Console.WriteLine("Centre Circle: X={0}, Y={1}; " +
                                           "Radius={2:f2}, Length={3,6:f2}",
                                                        X, Y, rad, Len);
        }
    }

    public class Square : Point    // класс "квадрат на плоскости"
    {
        // Закрытое поле:
        double side;    // сторона квадрата
        public Square(int xi, int yi, double s)
        {
            X = xi; Y = yi; side = s;
        }
        // свойство для стороны квадрата:
        public double Side { get { return side; } set { side = value; } }
        // свойство для получения значения периметра квадрата: 
        public double Len { get { return 4 * side; } }
        override public double Area { get { return side * side; } }
        override public void ConsoleDisplay()
        {  // Вывести характеристики
            Console.WriteLine("Centre Square: X={0}, Y={1}; " +
                                                      "Side={2:f2}, Perimeter={3,6:f2}",
                                                       X, Y, side, Len);
        }
    }


}
