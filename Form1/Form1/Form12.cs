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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
       
        private void Form12_Load(object sender, EventArgs e)
        {

        }
        //diziler index sıra belirtir ram de saklanır ilk index 0dır ve köşeli parentez kullanılır.ve degişkene göre de degişir tanımlanan int string vs de her def
        private void button1_Click(object sender, EventArgs e)
        {
            double[] ondalık = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6 };
            label1.Text = ondalık[4].ToString();
            char[] harfler = { 'a', 'b', 'c', };
            label2.Text = harfler[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 10, 25, 34, 48, 59, 67, 76,85,92,111 };
            for (int i = 0; i<sayılar.Length; i++)
            {
                if (sayılar[i] % 2 == 0 )
                {
                    listBox1.Items.Add(sayılar[i]);

            }

            }


        }
        //foreach(1234) 1 degişken türü 2 degişken adı 3 in 4 de dizi adı olucak şekilde yapılır.
        private void button3_Click(object sender, EventArgs e)
        {

            //int[] sayılar = { 10, 25, 50, 30, 40 };
            //foreach(int x in sayılar )
            //{
            //    listBox1.Items.Add(x.ToString());
            //}

            int toplam = 0;
            int elemanSayısı;
            int[] tamsayı = { 10, 25,36, 30, 40, 15, 26, 28, 32, 16, 72 };
            foreach (int x in tamsayı)
            {
                if (x % 4 == 0)
                {
                    toplam = x;
                    listBox1.Items.Add(toplam.ToString());

                }
            }
            //    for (int y = 0; y <= tamsayı.Length; y++)
            //    {
            //        y = tamsayı.Length - y;
            //        listBox2.Items.Add(y);
            //    }
            // ya da 
            elemanSayısı = tamsayı.Count();
            listBox2.Items.Add(elemanSayısı);


            }
        }

    }

