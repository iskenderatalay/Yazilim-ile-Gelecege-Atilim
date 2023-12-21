using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5
{
    internal class Program
    {
        /*
        public static double Hesapla(int kenar1, int kenar2)
        {
            double hip = Math.Sqrt(kenar1*kenar1 + kenar2*kenar2);
            return hip;
        }
        */

        /*       
        public static bool dikUcgen(int kenar1, int kenar2, double kenar3)
        {
            double hip = Math.Sqrt(kenar1 * kenar1 + kenar2 * kenar2);
            if (hip == kenar3)
            {
                Console.WriteLine("Dik ucgendir");
                return true;
            }
            else
            {
                Console.WriteLine("Dik ucgen degildir");
                return false;
            }
        }
        */

        /*
        public static double Hesapla(int sayi)
        {
            int fak = 1;
            if (sayi==0 || sayi==1)
            {
                return 1;
            }
            for(int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            return fak;
        }
        */

       
        public static void kokHesapla(double k1, double k2, double k3)
        {
            double delta=(k2*k2)-(4*k1*k3);
            if(delta < 0)
            {
                Console.WriteLine("Kok Yok");
            }
            if(delta > 0)
            {
                Console.WriteLine("2 Kok Var");
                double kok1 = (-k2 + Math.Sqrt(delta)) / (2 * k1);
                double kok2 = (-k2 - Math.Sqrt(delta)) / (2 * k1);
                Console.WriteLine("Kok 1 = " + kok1);
                Console.WriteLine("Kok 2 = " + kok2);
            }
            if (delta == 0)
            {
                Console.WriteLine("Esit 2 Kok Var");
                double kok1 = (-k2/(2*k1));
                Console.WriteLine("Esit 2 Kok  = " + kok1);
            }
        }      

        /*
        public static void FibonacciHesapla(int sayi)
        {
            int ilkSayi = 0;
            int ikinciSayi = 1;
            int toplam = 0;

            Console.Write(ilkSayi + "\t");
            Console.Write(ikinciSayi + "\t");

            for (int i = 0;i< sayi-2; i++)
            {
                toplam = ilkSayi + ikinciSayi;
                ilkSayi = ikinciSayi;
                ikinciSayi = toplam;
                Console.Write(toplam + "\t");
            }
        }
        */

        static void Main(string[] args)
        {
            /*
            //disaridan parametre olarak bir dik ucgenin 2 kenari verilecek ve hipotenus hesaplat 
            
            Console.WriteLine("Dik ucgenin 1nci kenarini gir = ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dik ucgenin 2nci kenarini gir = ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            double hip = Hesapla(kenar1, kenar2);
            Console.WriteLine("Dik ucgenin hipotenusu = " + hip);
            */

            /*
            //dik kenarlari ve hip verilen ucgenin dik ucgen olup olmadigini geriye donduren fonk 
            
            Console.WriteLine("Dik ucgenin 1nci kenarini gir = ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dik ucgenin 2nci kenarini gir = ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dik ucgenin hip gir = ");
            double kenar3 = Convert.ToDouble(Console.ReadLine());
            dikUcgen(kenar1, kenar2, kenar3);
            */

            /*
            //kullanicidan alinan sayinin faktoriyelini geri donduren fonk
            
            Console.WriteLine("Faktoriyel alinacak sayiyi gir = ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Faktoriyel = " + Hesapla(sayi));
            */

            //ODEV
            //ikinci dereceden bir denklemin koklerini bulan fonk

            Console.WriteLine("2nci derece denklemin 1nci katsayisi =");
            double k1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2nci derece denklemin 2nci katsayisi =");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2nci derece denklemin 3ncu katsayisi =");
            double k3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2nci derece denklemin kokleri =");
            kokHesapla(k1, k2, k3);
         
            /*
            //kullanicidan alinan sayi kadar fibonacci serisini hesaplat
            
            Console.WriteLine("Sayi adedini gir =");
            int sayiAdet= Convert.ToInt32(Console.ReadLine());
            FibonacciHesapla(sayiAdet);
            */
        }
    }
}
