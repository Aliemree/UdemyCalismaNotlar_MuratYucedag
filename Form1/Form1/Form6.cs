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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* int kısa, uzun, alan, cevre;
             kısa = 10;
             uzun = 20;
             alan = kısa*uzun;
             cevre = kısa * 2 + uzun * 2;
             label1.Text= "Alan: "+ alan + " Cevre:"+ cevre;*/

            int sınav1, sınav2, sınav3, ort;
            sınav1 = 20;
            sınav2 = 40;
            sınav3 = 60;
            ort = (sınav1 + sınav2 + sınav3) / 3;
            label1.Text= ort.ToString();
            // bazı veriler sting formatta geliyor bunları tostring ve ya toint16-32-64 çevirebiliriz bunu da ya atadıgın degişken isminin yanına ya da convert ile baglayarak yapabilirsin.
                
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, toplama, cıkarma, bölme, carpma;
            sayı1 = Convert.ToInt32(textBox1.Text);

            sayı2= Convert.ToInt32(textBox2.Text);
            toplama = sayı1 + sayı2;
            cıkarma = sayı1 - sayı2;
            bölme = sayı1 / sayı2;
            carpma = sayı2 * sayı2;
            MessageBox.Show("Toplama:" + toplama+  "\n"  + "cıkarma:"+cıkarma+ "\n" +"Bölme:"+bölme+ "\n" + " carpma:"+carpma);


        }
    }
}
