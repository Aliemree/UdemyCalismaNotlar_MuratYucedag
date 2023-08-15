using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar, sonuc;
            kısakenar=Convert.ToInt32(textBox1.Text);
            uzunkenar=Convert.ToInt32(textBox2.Text);
           sonuc=(2*kısakenar+uzunkenar*2);
            label4.Text=sonuc.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yarıcap,alan,cevre;
            double pi;
            pi = 3.14;
            yarıcap = Convert.ToInt32(textBox3.Text);
            alan = (int)((yarıcap * yarıcap)*pi);
            cevre = (int)(2 * pi * yarıcap);

            label8.Text = alan.ToString();
            label9.Text = cevre.ToString();


        }

    }
}
