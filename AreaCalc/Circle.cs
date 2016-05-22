using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Сircle : IFigure
    {
        private double _rad;
        private double _area;
        private double _perim;
        public Сircle(double rad)
        {
            if (rad <= 0) throw new FigureExeption("Радиус должен быть больше нуля!");
            _rad = rad;
            _area = 2*3.14*_rad*_rad;
            _perim = 2*3.14*_rad;
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
