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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, meslek, cinsiyet,yas;
            
            adsoyad=textBox1.Text;
            meslek= textBox2.Text;
            cinsiyet= textBox3.Text;
           yas=maskedTextBox1.Text;
            listBox1.Items.Add(textBox1.Text+"  " + textBox2.Text+ "  " + textBox3.Text+"   "+ maskedTextBox1.Text);

        }
    }
}
