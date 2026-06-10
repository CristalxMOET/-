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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, r;
            if (double.TryParse(textBox1.Text, out m) &&
                double.TryParse(textBox2.Text, out r))
            {
                double G = 6.67E-11;
                double g = G * m / (r * r);
                textBox3.Text = g.ToString("E2");
            }
            else
            {
                MessageBox.Show("Введите числовые значения!");

            }
        }
    }
}
