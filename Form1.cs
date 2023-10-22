using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Sophie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbXn.Text, out double Xn) &&
                double.TryParse(tbXk.Text, out double Xk) &&
                double.TryParse(tbH.Text, out double H) &&
                double.TryParse(tbA.Text, out double A))
            {

                Tabulation tabulation = new Tabulation(A, Xn, Xk, H);
                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();


                List<(double, double)> xy = tabulation.Tab();

                for(int i = 0; i < xy.Count; i++)
                {
                    dataGridView1.Rows.Add(Math.Round(xy[i].Item1, 2).ToString(), Math.Round(xy[i].Item2).ToString());
                    chart1.Series[0].Points.AddXY(xy[i].Item1, xy[i].Item2);
                }

            }
            else
            {
                MessageBox.Show("Is not valide data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbXn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
