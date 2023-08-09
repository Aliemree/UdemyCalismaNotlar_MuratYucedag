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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Futbolcu");
            listBox1.Items.Add("Serbest Meslek");
            listBox1.Items.Add("Hakim");
            listBox2.Items.Add(textBox2.Text);




                }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            listBox2.Items.Add(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text + "   " + textBox2.Text + "   "+ textBox3.Text +"   "+ textBox4.Text+"   ");
                
                }
    }
}
