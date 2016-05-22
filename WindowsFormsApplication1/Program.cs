using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaCalc;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFigure());
    /*      try
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
            }*/
        }
    }
}
