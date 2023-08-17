using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    internal class Araba: ArabaDetay
    {
        public string renk;
        public int hız;
        public int fiyat;
         public char durum; 
        public double motor;
        private int yıl;
        private string marka;

        public int YIL
        {
            get { return yıl; }
            set { yıl = Math.Abs(value); }
        }
        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }

    }
}
