using System;

namespace ConsoleCalismaları
{
    internal class Program : kisiler
    {
        static void Main(string[] args)
        {

            kisiler ks = new kisiler();


            string ads;
            string meslek;
            int yas;
            Console.WriteLine("Ad soyad Giriniz:");
            ads = Console.ReadLine();

            ks.kisilistesi(ads);

            Console.WriteLine("Meslek:");
            meslek = Console.ReadLine();
            ks.mesleklist(meslek);
            Console.WriteLine("Yas:");
            yas = Console.Read();
            ks.Yaslist(yas);


        }
    }

}
