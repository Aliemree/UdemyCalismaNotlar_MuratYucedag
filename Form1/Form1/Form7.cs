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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunismi;
            int fiyat;
            double ort8, ort18;
            urunismi = textBox1.Text;
            fiyat = Convert.ToInt32(textBox2.Text);
            ort8 = Convert.ToInt16(textBox2.Text);
            ort18 = Convert.ToInt32(textBox2.Text);
            ort8 = (fiyat * 8) / 100;
            ort18 = (fiyat * 18) / 100;




            listBox1.Items.Add("Urun Ismi:" + urunismi+  " \n "+ "%8 Kdv Degeri:"+ ort8+ " \n "+" %18KDV degeri:"+ort18);
            
        }
    }
}
