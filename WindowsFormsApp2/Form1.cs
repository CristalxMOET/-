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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newForm = null;
            if (radioButton1.Checked)
                newForm = new Form2();
            else if (radioButton2.Checked)
                newForm = new Form3();
            else if (radioButton3.Checked)
                newForm = new Form4();
            else if (radioButton4.Checked)
                newForm = new Form5();
            else if (radioButton5.Checked)
                newForm = new Form6();
            else if (radioButton6.Checked)
                newForm = new Form7();
            if (newForm != null)
            {
                newForm.Show();
            }
        }
    }
}