using System;

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


        public void timer1_Tick(object sender, EventArgs e)
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
                BtnA.Text = "Izmir";
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
                
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Fenerbahçe SK armasında bulunan yaprak hangi bitkiye aittir?";

                BtnA.Text = "Yonca";
                BtnB.Text = "Meşe Yapragı";
                BtnC.Text = "Kayın Yapragı";
                BtnD.Text = "Akdeniz Defnesi";
                label4.Text = "Meşe Yapragı";



            }
            if (soruno==5)
            {
                richTextBox1.Text = "Amerika Birleşik Devletleri tarihi boyunca en büyük zaiyatı hangi savaşta vermiştir?";

                BtnA.Text = "1. Dünya Savaşı";
                BtnB.Text = "2. Dünya Savaşı";
                BtnC.Text = "Vietnam Savaşı";
                BtnD.Text = "Irak Savaşı";
                label4.Text = "Vietnam Savaşı";
                

            }
            if (soruno ==6) 
            
            
            {

                richTextBox1.Text = "Hangisi Türkiye Cumhuriyeti'nin komşu devletlerinden birisi değildir?";
                BtnA.Text = "Bulgaristan";
                BtnB.Text = "Yunanistan";
                BtnC.Text = "Gürcistan";
                BtnD.Text = "Türkmenistan";
                label4.Text = "Türkmenistan";
                
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir?";

                BtnA.Text = "Hititler ";
                BtnB.Text = " Elamlar";
                BtnC.Text = "Sümerler";
                BtnD.Text = "Urartular";
                label4.Text = "Sümerler";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "2003 Yılında Euro Vizyon Şarkı Yarışmasında Ülkemizi Temsil Eden ve Yarışmada Birinci Gelen Sanatçımız Kimdir?";

                BtnA.Text = "Grup Athena";
                BtnB.Text = "Sertap Erener";
                BtnC.Text = "Şebnem Paker";
                BtnD.Text = " Ajda Pekkan";
                label4.Text = "Sertap Erener";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk’ün Nüfusa Kayıtlı Olduğu İl Hangisidir?";

                BtnA.Text = "Bursa ";
                BtnB.Text = "Ankara ";
                BtnC.Text = "İstanbul";
                BtnD.Text = "Gaziantep";
                label4.Text = "Gaziantep";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "\"Labirentin Gölgesinde\" ve \"Sembollerin Gölgesinde\" adlı fantastik romanların yazarı kimdir?";

                BtnA.Text = "Haldun Taner  ";
                BtnB.Text = "Mehmet Rauf  ";
                BtnC.Text = "Yaşar Kemal";
                BtnD.Text = "Yahya Karakurt";
                label4.Text = "Yahya Karakurt";
                BtnSonraki.Text = "Sonuclar=";


            }


            if (soruno==11)
            {
                richTextBox1.Text = "SOONNNN :)";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Dogru= " + dogru + "\n" + "Yanlis=" + yanlis);

                Application.Exit();

            }



        }
    }
}
