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
    public partial class Operatorler : Form
    {
        public Operatorler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, proje;
            double ort;
            string durum;

            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            proje = Convert.ToInt32(textBox3.Text);
            ort = (s1 + s2 + proje) / 3;
            if (ort >= 50)
            {
                durum = "Geçti";

            }
            else 
                    {
                durum = "Kaldı";
            }
            textBox4.Text = ort+" / " + durum;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kitapadeti;
            double tutar;
            kitapadeti = Convert.ToInt16(textBox5.Text);

            if (kitapadeti >= 0 && kitapadeti <= 20)
            {
                tutar = (kitapadeti * 8) - (kitapadeti * 8 * 0.20);
                label7.Text = tutar + " TL";
            }
            if (kitapadeti >= 21 &&  kitapadeti <= 40)
            {
                tutar = (kitapadeti * 8) - (kitapadeti * 8 * 0.4);
                label7.Text = tutar + " TL";

             }
            
            if (kitapadeti >=41)
            {
                tutar = (kitapadeti * 8) - (kitapadeti * 8 * 0.5);
                label7.Text = tutar + " Tl";
            }

        }
    }
}
// 0-20 %20
// 21-40 %40
//41++  %50
