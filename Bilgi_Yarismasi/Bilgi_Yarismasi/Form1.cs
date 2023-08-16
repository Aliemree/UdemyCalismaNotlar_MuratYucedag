using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Form1
{
    public partial class KararYapıları : Form
    {
        public KararYapıları()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis;


        private void BtnB_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        int saniye = 0, dakika = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label8.Text = saniye.ToString();
            if (saniye == 60)
            {
                dakika++;
                label7.Text = dakika.ToString();
                saniye = 0;



            }
        }
         

        private void BtnA_Click(object sender, EventArgs e)
        {


            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label5.Text == label4.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }



        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label6.Visible = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            LblSoru.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kac Yilinda Kurulmustur?";

                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {

                richTextBox1.Text = "Hangi Sehir Ege bolgemizde Bulunmaz?";
                BtnA.Text = "izmir";
                BtnB.Text = "Balikesir";
                BtnC.Text = "Aydin";
                BtnD.Text = "Manisa";
                label4.Text = "Balikesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuslar Hangi Yazarimiza Aittir?";

                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla Ilhan";
                BtnD.Text = "Resat Nuri Guntekin";
                label4.Text = "Sait Faik";
                BtnSonraki.Text = "Sonuclar=";



            }
            if (soruno == 4)
            {
                richTextBox1.Text = "SOONNNN :)";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Dogru= " + dogru + "\n" + "Yanlis=" + yanlis);



            }



        }
    }
}
