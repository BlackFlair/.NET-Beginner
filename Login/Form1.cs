using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int X = Int32.Parse(x.Text);
            int Y = Int32.Parse(y.Text);

            label4.Text = (X + Y).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int X = Int32.Parse(x.Text);
            int Y = Int32.Parse(y.Text);

            label4.Text = (X - Y).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int X = Int32.Parse(x.Text);
            int Y = Int32.Parse(y.Text);

            label4.Text = (X * Y).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int X = Int32.Parse(x.Text);
            int Y = Int32.Parse(y.Text);

            label4.Text = (X / Y).ToString();
        }
    }
}
