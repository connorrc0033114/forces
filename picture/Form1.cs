using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture
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
            try
            {
                double f = double.Parse(textBox1.Text);
                double a = double.Parse(textBox2.Text);
                double ans = sin(a);
                label1.Text = "Answer = " + ans;
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
      
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
    }



    }
}
