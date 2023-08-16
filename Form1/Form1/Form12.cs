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
        //diziler index sıra belirtir ram de saklanır ilk index 0dır ve köşeli parentez kullanılır.
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] ondalık = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6 };
            label1.Text = ondalık[4].ToString();
            char[] harfler = { 'a', 'b', 'c', };
            label2.Text = harfler[0].ToString();
        }
    }
}
