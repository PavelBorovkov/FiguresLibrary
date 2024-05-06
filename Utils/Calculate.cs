using FiguresLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Utils
{
    public static class Calculate
    {
        public static double AriaCalculate(IFigure figure)
        {
            return figure.Area();
        }
    }
}
