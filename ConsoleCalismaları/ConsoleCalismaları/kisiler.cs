using System;

namespace ConsoleCalismaları
{

    class islem
    {
        public int topla(int s1, int s2)
        {
            int s3 = s1 + s2;

            Console.WriteLine("Sonuc" + s3);
            return s3;

        }
        public int cıkarma(int s1, int s2)
        {
            int s3 = s1 - s2;
            Console.WriteLine("Sonuç:" + s3);
            return s3;

        }
        public double bölme (int s1, int s2)
        {
            double s3 = s1 / s2;
            Console.WriteLine("Sonuç:" + s3);
            return s3;
        }
        public int carpma (int s1, int s2)
        {

            int s3 = s1 * s2;
            Console.WriteLine("Sonuç:" + s3);
            return s3;
        }






    }
    //internal class kisiler
    //{
    //    public void kisilistesi(string adsoyad)

    //    {


    //        for (int k = 1; k <= 1; k++)
    //        {
    //            Console.WriteLine("Ad Soyadınız:" + adsoyad);

    //        }
    //    }
    //    public void mesleklist(string meslek)

    //    {


    //        for (int m = 1; m <= 1; m++)
    //        {
    //            Console.WriteLine("Mesleginiz" + meslek);

    //        }
    //    }

    //    public void Yaslist(int yas)

    //    {


    //        for (int i = 1; i <= 1; i++)
    //        {


    //           Console.Write("yasınız:"+yas);
    //        }
    //    }
}

