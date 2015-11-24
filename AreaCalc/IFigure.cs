using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public interface IFigure
    {
        double Area { get; }
        double Perim { get; }
    }
}
