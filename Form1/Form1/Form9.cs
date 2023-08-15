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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
        String işlem;
            int sonuc1,sonuc2,sonuc3,sonuc4;
            s1 = Convert.ToInt32(textBox2.Text);
            s2 = Convert.ToInt32(textBox1.Text);
            işlem=Convert.ToString(textBox3.Text);

           
            sonuc1=(s1+s2);
            sonuc2=(s1-s2);
            sonuc3=(s1*s2);
            sonuc4=(s1/s2);
            
            switch(işlem) 
            {
                case "+" : label4.Text = "Toplama Sonuç" + " : "+ (sonuc1);
                    break;
                case "-": label4.Text= "Cikarma Islemi "  +" : "+(sonuc2);
                    break;
                case "*": label4.Text= "Carpma Islemi" + " : " + (sonuc3);
                    break;
                case "/": label4.Text = "Bölme Islemi " + " : " + (sonuc4);
                    break;
                default: label4.Text = "Hatalı Sembol";
                     break;



            }
        }
    }
}
