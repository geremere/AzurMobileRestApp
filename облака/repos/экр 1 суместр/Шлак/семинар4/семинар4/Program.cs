using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace семинар4
{
    class Program
    {
        static void Main()
        {
            Point p = new Point();
            p.ConsoleDisplay();
            Console.WriteLine("p.Area для Point = " + p.Area);
            p = new Circle(1, 2, 6);
            p.ConsoleDisplay();
            Console.WriteLine("p.Area для Circle = " + p.Area);
            p = new Square(3, 5, 8);
            p.ConsoleDisplay();
            Console.WriteLine("p.Area для Square = " + p.Area);
            // double lenSq = p.Len;  
            // Ошибка - из базового недоступны члены производного //класса!
            Console.Read();
        }
    }
}
