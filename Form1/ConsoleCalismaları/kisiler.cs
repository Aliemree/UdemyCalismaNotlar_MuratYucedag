using System;

namespace ConsoleCalismaları
{
    internal class kisiler
    {
        public void kisilistesi(string adsoyad)

        {


            for (int k = 0; k <= 10; k++)
            {

                Console.WriteLine("AD Soyad:"+adsoyad);
            }
        }
        public void mesleklist(string meslek)

        {


            for (int m = 0; m <= 10; m++)
            {

                Console.WriteLine("Meslek:"+meslek);
            }
        }

        public void kisilistesi(int yas)

        {


            for (int i = 0; i <= 10; i++)
            {
                yas=Convert.ToInt32(yas);
                Console.WriteLine("Yasınız:"+yas);

            }
        }
    }
}
