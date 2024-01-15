using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            
            /*
            ogrenci.ad = "Betul";
            ogrenci.soyad = "Kara";
            ogrenci.numara = 125;

            Console.WriteLine(ogrenci.ad + " " + ogrenci.soyad + " " + ogrenci.numara);
            */

            /*
            ogrenci.Ekle("betul", "kara", 125);
            Console.WriteLine(ogrenci.ad + " " + ogrenci.soyad + " " + ogrenci.numara);
            */

            /*
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ekle("ayse", "fatma", 160);
            Console.WriteLine(ogrenci1.ad + " " + ogrenci1.soyad + " " + ogrenci1.numara);
            */

            /*
            Ogrenci ogrenci2 = new Ogrenci();
            Console.WriteLine(ogrenci2.ad + " " + ogrenci2.soyad + " " + ogrenci2.numara);
            */

            /*
            Kopek kopek = new Kopek();
            kopek.KopekEkle("Pamuk", "Kahverengi", "Kangal", false);
            kopek.Havla();
            kopek.KopekGetir();
            kopek.KuyrukSalla();
            kopek.Havla();
            */

            /*
            //kurucu metotla ornek

            Sinema s = new Sinema();
            Sinema s1 = new Sinema();
            Sinema s3 = new Sinema();
            */

            /*
            Sinema s = new Sinema("Salon1", 40);
            */

            /*
            Sinema s = new Sinema("Salon1", 4);
            s.BiletSat(false);
            s.BiletSat(true);
            s.BiletSat(true);
            s.BiletSat(true);
            s.BiletSat(true);

            Console.WriteLine("Bakiye = " + s.BakiyeOgren());
            Console.WriteLine("Bos Koltuk Sayisi = " + s.BosKoltukOgren());
            
            s.BiletIptal(false);
            Console.WriteLine("Bakiye = " + s.BakiyeOgren());
            Console.WriteLine("Bos Koltuk Sayisi = " + s.BosKoltukOgren());
            */

            //Odev
            //bunu otobus ornegi uzerinde uygula

            Otobus otobus = new Otobus("Metro", 40, "Pazartesi", "15.00", "81FB890", 
                "Duzce-Istanbul", "Berceste", 400, 600);

            Console.WriteLine("Otobus Firmasi = " + otobus.firmaAd);
            Console.WriteLine("Otobus Hareket Saati = " + otobus.saat);
            Console.WriteLine("Otobus Kapasitesi = " + otobus.toplamKoltukSayisi);
            Console.WriteLine("--------------------------------------------");

            otobus.BiletSat(true);
            otobus.BiletSat(true);
            otobus.BiletSat(true);
            otobus.BiletSat(false);
            otobus.BiletSat(false);
            otobus.BiletSat(false);

            otobus.KazancOgren();
            otobus.BosKoltukOgren();

            /*otobus.molaYer = "Yeni duraklama yeri";
            Console.WriteLine("Mola yer = " + otobus.molaYer);
            */

            Console.WriteLine("--------------------------------------------");
            otobus.BiletIptal(true);  
            otobus.BiletIptal(false);

            otobus.KazancOgren();
            otobus.IptalOgren();
            otobus.BosKoltukOgren();
        }
    }
}