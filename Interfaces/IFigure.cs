using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Interfaces
{
    //интерфейс который должны реализовывать фигуры (у фигур должен быть метод с рассчетом площади)
    public interface IFigure
    {
        public double Area();
    }
}
