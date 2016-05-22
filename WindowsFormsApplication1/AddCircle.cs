using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using AreaCalc;

namespace WindowsFormsApplication1
{
    public partial class AddCircle : Form
    {
        public AddCircle()
        {
            InitializeComponent();
        }

        public List<IFigure> FigureList { get; set; } 
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
            double doubleValue = Convert.ToDouble(textBoxRadius.Text.Replace(".", ","));
            Сircle circle = new Сircle(doubleValue);
            FigureList.Add(circle);
            Close(); 

        }

        private void textBoxRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBoxRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
