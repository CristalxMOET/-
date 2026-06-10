using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n, T;
            if (double.TryParse(textBox1.Text, out n) &&
                double.TryParse(textBox2.Text, out T))
            {
                double k = 1.38E-23;
                double P = n * k * T;
                textBox2.Text = P.ToString("E2");
            }

            else
            {
                MessageBox.Show("Введите числовые значения!");
            }
        }
    }
}
