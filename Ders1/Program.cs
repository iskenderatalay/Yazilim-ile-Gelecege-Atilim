using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 32;
            string str = Convert.ToString(num);
            Console.WriteLine(num);
            */

            /*
            string yazi = "2023-05-22";
            DateTime tarih = Convert.ToDateTime(yazi);
            Console.WriteLine(tarih);
            */

            /*
            string ad = "xz";
            int sayi = Convert.ToInt32(ad);
            */

            /*
            string yazi = "3,14";
            double kes = Double.Parse(yazi);
            float kesFloat = Single.Parse(yazi);

            Console.WriteLine(kes);
            Console.WriteLine(kesFloat);
            */

            /*
            double sayi=3.14;
            int yeniSayi = sayi;
            Console.WriteLine(yeniSayi);
            */

            /*
            string yazi = "42";
            bool donustuMu = Int32.TryParse(yazi, out int sonuc);
            if (donustuMu)
            {
                Console.WriteLine("oldu " + sonuc);
            }
            else Console.WriteLine("hata");
            */

            /*
            try
            {
            //ilk ornek basla
                string ad = " xz";
                int say = Convert.ToInt32(ad);
                Console.WriteLine("kod dogru");
            //ilk ornek son

            int say = 0;
            int bolum = 5 / say;
            Console.WriteLine("kod dogru");

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            /*
            Console.WriteLine("2 sasyi gir");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("toplam =" + c);
            */

            /*
            Console.WriteLine("yasinizi girin");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas > 18)
                Console.WriteLine("yas 18den buyuk");
            else if(yas==18){
                Console.WriteLine("Ad gir");
                string ad = Console.ReadLine();
                Console.WriteLine("Ad = " + ad);
            }
            else
                Console.WriteLine("yas 18den kucuk");

            Console.WriteLine("program Son");
            */

            /*
            Console.WriteLine("Yas Gir");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cinsiyet Gir");
            string cin = Console.ReadLine();

            if (yas > 18 && cin == "k")
                Console.WriteLine("18 den buyuk kadindir");
            else
                Console.WriteLine("18 den buyuk erkeksin");
            */

            /*
            char ehliyet = 'B';
            switch (ehliyet)
            {
                case 'A':
                    Console.WriteLine("Motor");
                    break;
                case 'B':
                    Console.WriteLine("Araba");
                    break;
                case 'C':
                    Console.WriteLine("Kamyon");
                    break;
                default:
                    Console.WriteLine("yok");
                    break;
            }
            */

            /*
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("cift sayilar" + i);
                }
               // Console.WriteLine(i);
            }
            */

            /*
            //50den kucuk tek sayilarin carpimi

            double carp = 1;
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 1)
                {
                    carp *= i;
                    Console.WriteLine(carp);
                }
            }
            */

            /*
            int sayi = 1;
            while (sayi > 0)
            {
                Console.WriteLine(sayi);
            }
            */

            /*
            int sayi = 1;
            while (sayi <5)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            */

            /*
            int sayi = 1;
            while (sayi <5)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            */

            /*
            int tahminEt = 78;
            int deger = 1;
            do
            {
                Console.WriteLine("Sayi tahmin et");
                deger = Convert.ToInt32(Console.ReadLine());
            }
            while (tahminEt != deger);
                Console.WriteLine("Tahmin dogru");
            */

            //ODEV 
            Console.WriteLine("Ehliyet turunu gir A/B/C");
            string ehliyet = Console.ReadLine();

            switch (ehliyet.ToUpper())
            {
                case "A":
                    Console.WriteLine("Motor");
                    break;
                case "B":
                    Console.WriteLine("Araba");
                    break;
                case "C":
                    Console.WriteLine("Kamyon");
                    break;
                default:
                    Console.WriteLine("yok");
                    break; 
            }
        }
    }
}
