using FiguresLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Utils
{
    public static class Check
    {
        public static bool CheckTriangle(Triangle triangle)
        {
            if(triangle.Side1*triangle.Side1+triangle.Side2*triangle.Side2==triangle.Side3*triangle.Side3||
               triangle.Side2 * triangle.Side2 + triangle.Side3 * triangle.Side3 == triangle.Side1 * triangle.Side1 ||
               triangle.Side3 * triangle.Side3 + triangle.Side1 * triangle.Side1 == triangle.Side2 * triangle.Side2)
            {
                return true;
            }
            else return false;
        }
    }
}
