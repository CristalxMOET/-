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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R, T;
            if (double.TryParse(textBox1.Text, out R) &&
                double.TryParse(textBox2.Text, out T))
            {
                double sigma = 5.67E-8;
                double L = 4 * Math.PI * R * R * sigma * Math.Pow(T, 4);
                textBox3.Text = L.ToString("E2");
            }
            else
            {
                MessageBox.Show("Введите числовые значения R и T!");
            }
        }
    }
}
