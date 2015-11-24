using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : IFigure
    {
        private double _side1, _side2, _side3;
        private double _area;
        private double _perim;
        private double _p;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new FigureExeption("Недопустимая длина 1. Длина должна быть больше нуля");
            if (side2 <= 0) throw new FigureExeption("Недопустимая длина 2. Длина должна быть больше нуля");
            if (side3 <= 0) throw new FigureExeption("Недопустимая длина 3. Длина должна быть больше нуля");
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            _perim = side1 + side2 + side3;
            _p = _perim/2;
            _area = Math.Sqrt(_p*(_p - _side1)*(_p - side2)*(_p - side3));
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
