using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Silindirin Hacmi

            Console.WriteLine("Yukseklik=");
            int h=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("R=");
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            double hacim = pi * r * r * h;
            Console.WriteLine("Silindirin Hacmi =" + hacim);
            */

            /*
            //Koninin Hacmi

            Console.WriteLine("Yukseklik=");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("R=");
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            double hacim = (pi * r * r * h)/3.0;
            Console.WriteLine("Koninin Hacmi =" + hacim);
            */

            /*
            //Klavyeden girilen iki basamakli sayinin basamak degerlerinin karelerinin toplami

            Console.WriteLine("Iki basamakli sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = sayi / 10;
            double toplam = (birler * birler) + (onlar * onlar);
            Console.WriteLine("Toplam=" + toplam);
            */

            /*
            //Klavyeden girilen uc basamakli sayinin basamak degerlerinin karelerinin toplamıi

            Console.WriteLine("Uc basamakli sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = (sayi%100) / 10;
            int yuzler = sayi / 100;
            double toplam = (birler * birler) + (onlar * onlar) + (yuzler*yuzler);
            Console.WriteLine("Toplam=" + toplam);
            */

            /*
            // 100 soruluk sinavda 4 yanlıs bir dogruyu goturuyor.kullanicidan yanlis ve bos degeri alinacak 
            // 85 ve uzeri cok basarili
            // 70-85 arası orta seviye
            // 55-70 arasi idare eder
            // 55 alti kaldi netini yazdir

            int soruSayisi = 100;
            Console.WriteLine("Bos Sayisini Gir");
            int bosSayisi =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yanlis Sayisini Gir");
            int yanlisSayisi =Convert.ToInt32(Console.ReadLine());
            double net = (soruSayisi - yanlisSayisi - bosSayisi)-(yanlisSayisi/4);
            if (net >= 85)
                Console.WriteLine("Cok Basarili " + "Netiniz = " + net);
            else if (net < 85 && net >= 70)
                Console.WriteLine("Orta Seviye " + "Netiniz = " + net);
            else if (net < 70 && net >= 55)
                Console.WriteLine("Idare Eder " + "Netiniz = " + net);
            else
                Console.WriteLine("Kaldin " + "Netiniz = " + ne);
            */

            /*
            //Klavyeden 3 tane kenar degeri gir Ucgen eskenar mi ikiz kenar mi ya da diger

            Console.WriteLine("Kenar 1i gir");
            int kenar1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kenar 2i gir");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kenar 3i gir");
            int kenar3 = Convert.ToInt32(Console.ReadLine());
            if ((kenar1 == kenar2) && (kenar2 == kenar3) && (kenar1 == kenar3))
                Console.WriteLine("Bu eskanardir");
            else if ((kenar1 == kenar2) || (kenar2 == kenar3) || (kenar1 == kenar3))
                Console.WriteLine("Ikizkenardir");
            else Console.WriteLine("Cesitkenardir"); 
            */

            /*
            //klavyeden 3 tane sayi al, bu sayilardan en kucuk bul

            Console.WriteLine("3 tane sayi gir");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3 = Convert.ToInt32(Console.ReadLine());
            int enKucuk = s1;
            if (s2 < enKucuk)
                enKucuk = s2;
            if(s3 < enKucuk)
                enKucuk = s3;
            Console.WriteLine("En kucuk sayi = " + enKucuk);
            */

            /*
            //klavyeden 3 tane sayi al, bu sayilardan en buyuk bul

            Console.WriteLine("3 tane sayi gir");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3 = Convert.ToInt32(Console.ReadLine());
            int enBuyuk = s1;
            if (s2 > enBuyuk)
                enBuyuk = s2;
            if (s3 > enBuyuk)
                enBuyuk = s3;
            Console.WriteLine("En kucuk sayi = " + enBuyuk);
            */

            /*
            //klavyeden 3 tane sayi al, bu sayilardan ortancayi bul

            Console.WriteLine("3 tane sayi gir");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3 = Convert.ToInt32(Console.ReadLine());
            int ortanca = (s1+s3)/2;
            if(s1==ortanca)
                ortanca = s1;
            else if(s2==ortanca)
                ortanca = s2;
            else
                ortanca = s3;
            Console.WriteLine("Ortanca sayi = " + ortanca);
            */

            /*
            //klavyeden girilen 5 sayinin toplami

            Console.WriteLine("5 sayi girin");
            int toplam = 0;
            for(int i=0; i<5; i++)
            {
                int say = Convert.ToInt32(Console.ReadLine());
                toplam += say;
            }
            Console.WriteLine("Toplam = " + toplam);
            */

            /*
            //klavyeden girilen n sayinin toplami

            Console.WriteLine("Kac adet sayi");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for(int i=0; i<n; i++)
            {
                int say = Convert.ToInt32(Console.ReadLine());
                toplam += say;
            }
            Console.WriteLine("Toplam = " + toplam);
            */

            /*
            //1den100 sayilardan 3e 4e 5e tam bolunenleri yazdir

            Console.WriteLine("3,4,5e tam bolunenler");
            for(int i = 1; i < 100; i++)
            {
                if ((i % 3 == 0) && (i % 4 == 0) && (i % 5 == 0))
                    Console.WriteLine("Tam bolunen = " + i);
            }
            */

            /*
            //1den100 sayilardan 3e 4e 5e tam bolunenleri yazdir

            Console.WriteLine("3,4,5e tam bolunenler");
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("3 e Tam bolunenler = " + i);
            }
            Console.WriteLine(" ");
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                    Console.WriteLine("4 e Tam bolunenler = " + i);
            }
            Console.WriteLine(" ");
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine("5 e Tam bolunenler = " + i);
            }
            */

            /*
            // * lardan nxn boyutunda kare yap n klavyeden girilcek

            Console.WriteLine("Kaca kac kare olsun = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            /*
            // *larla nxn boyutunda dik ucgen olusur. n klavyeden alincak
            Console.WriteLine("Kaca kac kare olsun = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            */

            //ODEVVV
            // *larla nxn boyutunda ters dik ucgen olusur. n klavyeden alincak
            
            Console.WriteLine("Kaca kac kare olsun = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int tersadet = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < tersadet; j++)
                {
                    Console.Write("* ");
                }
                tersadet--;
                Console.WriteLine();
            }
        }
    }
}
