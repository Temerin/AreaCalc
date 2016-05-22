using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AreaCalc;

namespace WindowsFormsApplication1
{
    public partial class FormCircle : Form
    {
        public FormCircle()
        {
            InitializeComponent();
        }

        private void textBoxRadius_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double doubleValue;
                if (double.TryParse(textBoxRadius.Text, out doubleValue)) throw new FigureExeption("Радиус должен быть задан числом!");
                if (doubleValue <= 0) throw new FigureExeption("Радиус должен быть больше нуля.");
                if (doubleValue > 1000) throw new FigureExeption("Радиус не должен быть больше 1000.");
            }
            catch (FigureExeption exFCircle)
            {
                Console.WriteLine("{0} Exception caught.", exFCircle);
            }
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            double doubleValue = Convert.ToDouble(textBoxRadius.Text);
           // figure.Add(new Сircle(doubleValue));
        }
    }
}
