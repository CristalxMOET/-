using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double M;
            if (double.TryParse(textBox1.Text, out M))
            {
                double G = 6.67E-11;
                double c = 3E8;
                double r = 2 * G * M / (c * c);
                textBox2.Text = r.ToString("E2");
            }
      
            else
            {
                MessageBox.Show("Введите числовые значения!");
            }
        }
    }
}
