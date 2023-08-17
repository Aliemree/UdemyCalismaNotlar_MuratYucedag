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
    public partial class ConsoleCalısmaları : Form
    {
        public ConsoleCalısmaları()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            Araba rb= new Araba();
            rb.renk = "Mavi";
            rb.hız = 160;
            rb.durum = 's';
            rb.motor = 1254.55;
            rb.fiyat = 50000;
            rb.YIL = -2015;
            rb.MARKA = "Golf";
            rb.plaka = "27 AE 227";
            rb.muayene = 2015;
            rb.sahip = "Ali Bey";





            label1.Text = rb.renk;
            label2.Text=rb.durum.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.hız.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.sahip;
            label10.Text = rb.plaka;

            
        }
    }
}
