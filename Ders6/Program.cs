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

            Otobus otobus1 = new Otobus("Otobus 1", 20);
            Console.WriteLine("Bakiye = " + otobus1.BakiyeOgren());
            Console.WriteLine("Bos koltuk sayisi = " + otobus1.BosKoltukOgren());
            Console.WriteLine("-------------------------------");

            otobus1.BiletSat(true);
            otobus1.BiletSat(true);
            otobus1.BiletSat(true);
            otobus1.BiletSat(true);

            otobus1.BiletSat(false);
            otobus1.BiletSat(false);

            otobus1.BiletIptal(true);
            otobus1.BiletIptal(false);

            Console.WriteLine("Bakiye = " + otobus1.BakiyeOgren());
            Console.WriteLine("Bos koltuk sayisi = " + otobus1.BosKoltukOgren());
            Console.WriteLine("Satilan koltuk sayisi = " + otobus1.SatilanKoltukOgren());
        }
    }
}