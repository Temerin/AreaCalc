using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreaCalc;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure[] figure = new IFigure[3];
            try
            {
                figure[0] = new Сircle(2);
                figure[1] = new Rectangle(4, 2);
                figure[2] = new Triangle(2, 2, 3);
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(figure[i].Area);
                }
            }
            catch (FigureExeption e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            //System.Console.WriteLine("Hello, World!");
            System.Console.Read(); 
        }
    }
}
