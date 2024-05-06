using FiguresLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Utils
{
    //абстрактный класс "калькулятор", в нем содержатся методы ,высчитывающие определенные значения
    //например метод высчитывания площади, который вызывает у фигуры её метод расчета площади.
    //так же можно добавить методы расчета периметра, обьема и тд.
    public static class Calculate
    {
        public static double AriaCalculate(IFigure figure)
        {
            return figure.Area();
        }
    }
}
