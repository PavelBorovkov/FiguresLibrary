using FiguresLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Triangle:IFigure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            try
            {
                if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2)
                {
                    Side1 = side1;
                    Side2 = side2;
                    Side3 = side3;
                }
                else throw new InvalidOperationException("Стороны не могут образовать треугольник.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public double Area()
        {
            double P = (Side1 + Side2 + Side3) / 2;
            double Area = Math.Sqrt(P * (P - Side1) * (P - Side2) * (P - Side3));
            return Area;
        }
    }
}
