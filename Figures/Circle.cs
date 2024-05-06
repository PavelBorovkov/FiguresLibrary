using FiguresLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    //Фигура с её величинами и методом расчета её площади
    public class Circle:IFigure
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius) 
        { 
            Radius = radius;
        }
        public double Area()
        {
            return Radius*Radius*3.14;
        }
    }
}
