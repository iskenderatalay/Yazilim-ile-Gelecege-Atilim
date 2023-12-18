using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Hesap makinesi uygulamasi(toplama,cikarma,carpma,bolme)

            Console.WriteLine("Sayi 1 Gir");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi 2 Gir");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama icin 1 Gir");
            Console.WriteLine("Cikarma icin 2 Gir");
            Console.WriteLine("Carpma icin 3 Gir");
            Console.WriteLine("Bolme icin 4 Gir");

            int sec = Convert.ToInt32(Console.ReadLine());
            switch (sec)
            {
                case 1:
                    Console.WriteLine("Toplama Sonucu = " + (s1 + s2));
                    break;
                case 2:
                    Console.WriteLine("Cikarma Sonucu = " + (s1 - s2));
                    break;
                case 3:
                    Console.WriteLine("Carpma Sonucu = " + (s1 * s2));
                    break;
                case 4:
                    Console.WriteLine("Bolme Sonucu = " + (s1 / s2));
                    break;
                default:
                    Console.WriteLine("Islem Yapilamadi");
                    break;
            }
            */

            /*
            //Kullanicidan fiyati alinan bir urunun turune gore vergisini hesapla
            //Kitap icin 0,04
            //Temel Gida icin 0.056
            //Luks icin 0,1

            Console.WriteLine("Ucreti gir");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            double vergi;

            Console.WriteLine("Kitap icin 1 Sec");
            Console.WriteLine("Temel Gida icin 2 Sec");
            Console.WriteLine("Luks icin 3 Sec");
            int sec = Convert.ToInt32(Console.ReadLine());

            switch (sec)
            {
                case 1:
                    vergi = fiyat * 0.04;
                    Console.WriteLine("Vergisi = " + vergi);
                    break;
                case 2:
                    vergi = fiyat * 0.056;
                    Console.WriteLine("Vergisi = " + vergi);
                    break;
                case 3:
                    vergi = fiyat * 0.1;
                    Console.WriteLine("Vergisi = " + vergi);
                    break;
                default:
                    Console.WriteLine("Islem Hatasi");
                    break;
             }
            */

            /*
            //Klavyeden girilen sayilerin toplami 50yi gecince duran ve toplam ile
            //kac sayi girildigini soyle

            int sayi;
            int toplam = 0;
            int say=0;
            while (toplam < 50)
            {
                Console.WriteLine("Sayi gir");
                sayi =Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                say++;
            }
            Console.WriteLine("Toplam = " + toplam + "Adet sayi =" + say);
            */

            /*
            //Sayi tahmin oyunu yap

            Random rastgele = new Random();
            int sayi = rastgele.Next(50);
            while (true)
            {
                Console.WriteLine("Tahmininiz = ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if(tahmin < sayi)
                    Console.WriteLine("Sayiyi buyult");
                else if(tahmin > sayi)
                    Console.WriteLine("Sayiyi kucult");
                else
                {
                    Console.WriteLine("Tebrikler Sayiyi Buldun " + "Sayi = " + sayi);
                    break;
                }
            }
            */

            /*
            //Sayi bulma oyunu 5 hakkin var

            Random rastgele = new Random();
            int sayi = rastgele.Next(50);
            int hak = 5;
            while (true)
            {
                Console.WriteLine("Hakiniz = "+ hak);
                hak--;
                if (hak < 0) {
                    Console.WriteLine("Hak Bitti");
                    break;
                }
                Console.WriteLine("Tahmininiz = ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin < sayi)
                    Console.WriteLine("Sayiyi buyult");
                else if (tahmin > sayi)
                    Console.WriteLine("Sayiyi kucult");
                else
                {
                    Console.WriteLine("Tebrikler Sayiyi Buldun " + "Sayi = " + sayi);
                    break;
                }
            }
            */

            /*
            string[] sehirler = new string[3];
            sehirler[0] = "Duzce";
            sehirler[1] = "Ankara";
            sehirler[2] = "Istanbul";

            for(int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            */

            /*
            Console.WriteLine("Dizi boyutunu gir");
            int n =Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dizinin " + (i+1) + "nci Elamani = ");
                sayilar[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Dizi = ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            */

            /*
            //Dizi olustur bunun elamanlarinin toplamini ve ortalamasini yazdir

            Console.WriteLine("Dizi boyutunu gir");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];

            double toplam = 0.0;
            double ortalama;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dizinin " + (i + 1) + "nci Elamani = ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];
            }
            ortalama = toplam / n;
            Console.WriteLine("Dizi Elemanlarinin Toplami = " + toplam); 
            Console.WriteLine("Dizi Elemanlarinin Ortalamasi = " + ortalama);
            */

            //ODEV BASLA
            //disardan boyutunu belirle dizi olustur bunun icindeki en kucuk ve en buyuk elemani yazdir

            Console.WriteLine("Dizi boyutunu gir");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            int enKucuk;
            int enBuyuk;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dizinin " + (i + 1) + "nci Elemani = ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Olusturulan Dizi = ");

            enKucuk = sayilar[0];
            enBuyuk = sayilar[0];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + ".ci Eleman = ");
                Console.WriteLine(sayilar[i]);

                if (sayilar[i] < enKucuk)
                    enKucuk = sayilar[i];
                if (sayilar[i] > enBuyuk)
                    enBuyuk = sayilar[i];
            }

            Console.WriteLine("Dizi Elamanlarinin En Kucugu = " + enKucuk);
            Console.WriteLine("Dizi Elamanlarinin En Buyugu = " + enBuyuk);

            /*
            Console.WriteLine("Dizi Elamanlarinin En Kucugu = " + sayilar.Min());
            Console.WriteLine("Dizi Elamanlarinin En Buyugu = " + sayilar.Max());
            */
        }
    }
}
