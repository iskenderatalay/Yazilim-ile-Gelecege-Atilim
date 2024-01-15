using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OBSContext context = new OBSContext();

            /*
            Ogrenci o = new Ogrenci();
            o.Ad = "Şeyma";
            o.Soyad = "Ş";
            o.OgrNo = 5678;

            context.Ogrenci.Add(o);
            context.SaveChanges();

            var ogrenciListe = context.Ogrenci.ToList();
            foreach (var ogrenci in ogrenciListe)
            {
                Console.WriteLine("ID: " + ogrenci.OgrenciID + " Ad: " + ogrenci.Ad + " Soyad: " + ogrenci.Soyad);
            }
            */

            /*     
            Ders d = new Ders();
            d.DersAdi = "mat";
            d.DersKodu = "BM203";

            context.Ders.Add(d);
            context.SaveChanges();
            
            var dersListe = context.Ders.ToList();
            foreach (var ders in dersListe)
            {
                Console.WriteLine("ID: " + ders.DersID + " Ad: " + ders.DersAdi + " Kod: " + ders.DersKodu);
            }
            */

            /*
        
            Ogrenci ogr = new Ogrenci();

            Console.WriteLine("Ogrenci adini giriniz ");
            ogr.Ad = Console.ReadLine();
            Console.WriteLine("Ogrenci soyadini giriniz ");
            ogr.Soyad = Console.ReadLine(); 
            Console.WriteLine("Ogrenci numarasini giriniz ");
            ogr.OgrNo= Convert.ToInt32(Console.ReadLine());

            context.Ogrenci.Add(ogr);
            context.SaveChanges();
            */

            /*
            Console.WriteLine("----Öğrenciler----");

            var ogrenciList = context.Ogrenci.ToList();
            foreach (var o in ogrenciList)
            {
                Console.WriteLine("Öğrenci ID = " + o.OgrenciID + " Adi = " + o.Ad + " Soyad = " + o.Soyad);
            }

            Console.WriteLine("----Dersler----");
            
            var dersList = context.Ders.ToList();
            foreach (var d in dersList)
            {
                Console.WriteLine("Ders ID = " + d.DersID + " Ders Adi = " + d.DersAdi);
            }

            OgrenciDers od = new OgrenciDers();
            
            Console.WriteLine("Ögrenci Id = ");
            od.OgrenciID = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ders Id = ");
            od.DersID = Convert.ToInt32(Console.ReadLine());

            context.OgrenciDers.Add(od);
            context.SaveChanges();
            */

            /*
            //Guncelleme Islemi

            var guncelle = context.OgrenciDers.Where(x => x.OgrenciDersID == 4).FirstOrDefault();

            guncelle.VizeNot = 90;
            guncelle.FinalNot = 100;
            guncelle.HarfNot = "AA";

            context.SaveChanges();
            */

            Ogrenci o = new Ogrenci();
            o.OgrenciListele();

            //ogrenci ekleme 

            o.Ad = "Ahmet";
            o.Soyad = "Ak";
            //o.OgrenciEkle(o);

            Ders d = new Ders();
        
            /*
            //ders ekleme

            d.DersAdi = "Kimya";
            d.DersKodu = "K101";
            d.DersEkle(d);
            */

            /*
            //ders silme

            var silDers = context.Ders.Where(x => x.DersID == 1003).FirstOrDefault();
            context.Ders.Remove(silDers);
            context.SaveChanges();   
            */

            //d.dersSil(1005);
            d.DersListele();

            /*
            //Ogrenci Guncelleme 

            o.OgrenciGuncelle(8, "Deneme", "Hahaha");
            */

            /*
            //Ders Guncelleme 

            d.DersGuncelle(2, "Bm909", "SanalDunya");
            d.DersListele();
            */
        }
    }
}
