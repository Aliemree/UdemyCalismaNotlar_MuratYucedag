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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           label5.Text  = "Ali";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = "Ali";
            label10.Text = "Emre";
            label11.Text = "Muhendis";

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yazilim Mühendisligi";
            label1.Text = textBox1.Text;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label16.Text = textBox2.Text;
            label17.Text = textBox3.Text;
            label18.Text = textBox4.Text;
        }
    }
}
