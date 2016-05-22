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
    public partial class AddRectangle : Form
    {
        public AddRectangle()
        {
            InitializeComponent();
        }

        public List<IFigure> FigureList { get; set; } 
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            double doubleValue1 = Convert.ToDouble(textBoxSide1.Text.Replace(".", ","));
            double doubleValue2 = Convert.ToDouble(textBoxSide2.Text.Replace(".", ","));
            AreaCalc.Rectangle rectangle = new AreaCalc.Rectangle(doubleValue1, doubleValue2);
            FigureList.Add(rectangle);
            Close(); 
        }

        private void textBoxSide1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSide2_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
