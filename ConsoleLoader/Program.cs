﻿using System;
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
            try
            {
                List<IFigure> figure = new List<IFigure>();
                figure.Add(new Сircle(2));
                figure.Add(new Rectangle(4, 2));
                figure.Add(new Triangle(2, 2, 3));
                foreach (IFigure fig in figure)
                {
                    Console.WriteLine(fig.Area);
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
