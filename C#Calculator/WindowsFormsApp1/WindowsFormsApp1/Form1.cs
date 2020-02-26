using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(edtNum1.Text);
            int Num2 = int.Parse(edtNum2.Text);
            int sum = Num1 + Num2;
            lblAns.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(edtNum1.Text);
            int Num2 = int.Parse(edtNum2.Text);
            int sum = Num1 - Num2;
            lblAns.Text = sum.ToString();
        }
    }
}
