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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;
            if (double.TryParse(textBox1.Text,out r))
            {
                double H0 = 75;
                double V = H0 * r;
                textBox2.Text = V.ToString();
            }
            else
            {
                MessageBox.Show("Введите расстояние r!");
            }
        }
    }
}
