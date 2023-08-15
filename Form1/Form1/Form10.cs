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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        // for dongusu baslangıç bitiş artış veya azalış olarak yazılır geri kalan da istenilen duruma göre hareket edilir.
        private void button1_Click(object sender, EventArgs e)
        {
            //bir sayıı ekranda o kadar yazdırılması
            /* int toplam;
             toplam = 0;
             for (int i = 1; i <=10 ; i++)
             {
                 toplam = toplam + i;
             }
             label1.Text = toplam.ToString();*/
            //ekranda çift sayı yazımı
            //int toplam;
            //toplam = 0; 
            // for (int i = 0; i < 10; i+=2) {
            //    toplam = toplam + i;


            //}
            // label2.Text = toplam.ToString();   
            //ekranda 0dan 10 akaddar sayı yazılması

            int i = 0;
                for (i = 0; i <=10 ; i++)
            {
                listBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        { //girilen sayıya kadar ekranda yazılması.
            //int sayı=Convert.ToInt32(textBox1.Text);
            //for (int i = 1;i <=sayı ; i++)
            //{
            //    if (sayı % i == 0)
            //    {
            //        listBox1 .Items.Add(i);
            //    }

            //girilen sayı degerinin faktöriyelini alinması,
            int fak=Convert.ToInt32(textBox1.Text);
            int sonuc = 1;
            for (int i = 1 ; i<=fak; i++)
            {
                sonuc = sonuc * i;
            }
            listBox1.Items.Add(sonuc);

            }

        private void button3_Click(object sender, EventArgs e)
        { // while (sart) süslü parantez içerisinde istenilen işlem 
            int i;
            int toplam = 0;
            while (toplam<=5)
            {
                listBox1.Items.Add("Merhaba Dünya");
                listBox2.Items.Add(toplam);
                toplam++;
            }

            //burda işlem iki degişken atadık onların degerlerini verdik istenilen sayıya ulaşınca işlem yaptı ekrana yazdırdık.
            int j=1;
            int topla = 0;
            while (j<=5)
            {
                topla=topla+j;
                j++;
            }
            MessageBox.Show(topla.ToString());
        }//do while ve while arasındaki fark var while da sart saglanmazsa işlem yapmaz ama do while da o işlem bir kere yapılır daha sonrasında while daki şart saglanırsa işlem devam eder.


        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Visible = true;
            sayac++;
            label3.Text = sayac.ToString();


            if (sayac == 10)
            {
                this.BackColor = Color.Red;
            }
            if (sayac == 20) {
            this.BackColor = Color.Yellow;


            }
            if (sayac == 30)
            {
                this.BackColor = Color.Green;

                

            }
            if (sayac == 31)
            {
                label3.Visible = false;
                this.BackColor = Color.White;
                sayac = 0;
            }
        }



        }

    }
    

