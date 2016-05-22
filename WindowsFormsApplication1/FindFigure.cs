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
    public partial class FindFigure : Form
    {
        public FindFigure()
        {
            InitializeComponent();
        }

        public List<IFigure> FigureList { get; set; } 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //FormFigure main = Owner as FormFigure;
            double findArea = 0;
            if (textBoxArea.Text != "")
            {
                findArea = Convert.ToDouble(textBoxArea.Text.Replace(".", ","));
            }
            if (FigureList != null) //если есть где искать 
            {
                if (checkBoxCircle.Checked || checkBoxRectangle.Checked || checkBoxTriangle.Checked)
                    //если выбран поиск по типу 
                {
                    foreach (var item in FigureList) //перебираем все объекты 
                    {
                        if ((item is Сircle) && (checkBoxCircle.Checked))
                        {
                            if ((item.Area == findArea) || (textBoxArea.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView);
                                row.Cells[0].Value = "Круг";
                                row.Cells[1].Value = item.Area;
                                dataGridView.Rows.Add(row);
                            }
                        }
                        if ((item is AreaCalc.Rectangle) && (checkBoxRectangle.Checked))
                        {
                            if ((item.Area == findArea) || (textBoxArea.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView);
                                row.Cells[0].Value = "Прямоугольник";
                                row.Cells[1].Value = item.Area;
                                dataGridView.Rows.Add(row);
                            }
                        }
                        if ((item is Triangle) && (checkBoxTriangle.Checked))
                        {
                            if ((item.Area == findArea) || (textBoxArea.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView);
                                row.Cells[0].Value = "Треугольник";
                                row.Cells[1].Value = item.Area;
                                dataGridView.Rows.Add(row);
                            }
                        }
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxArea_KeyPress(object sender, KeyPressEventArgs e)
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
