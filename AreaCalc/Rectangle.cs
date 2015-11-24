using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Rectangle : IFigure
    {
        private double _side1, _side2;
        private double _area;
        private double _perim;
        public Rectangle(double side1, double side2)
        {
            if (side1 <= 0) throw new FigureExeption("Недопустимая длина 1. Длина должна быть больше нуля");
            if (side2 <= 0) throw new FigureExeption("Недопустимая длина 2. Длина должна быть больше нуля");
            _side1 = side1;
            _side2 = side2;
            _perim = 2*(side1 + side2);
            _area = side1*side2;
        }
        public double Area
        {
            get { return _area; }
        }
        public double Perim
        {
            get { return _perim; }
        }
    }
}
