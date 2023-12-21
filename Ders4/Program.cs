using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4
{
    internal class Program
    {
        /*
        public static void Topla()
        {
            int a = 10; int b = 20;
            Console.WriteLine(a + b);
        }
        public static void Carp()
        {
            int a = 10; int b = 20;
            Console.WriteLine(a * b);
        }
        public static int Bol(int x,int y)
        {
            int bolum = x / y;
            return bolum;
        }
        public static string Birlestir(string ad, string soyAd)
        {
            return ad + " " + soyAd;
        }
        */

        /*
        //asiri Yukleme Overload

        public static int Topla()
        {
            int x = 10; int y = 20;
            Console.WriteLine(x+y);
            return x + y;
        }
        public static int Topla(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }
        */

        /*
        //metotlarda dizi kullanimi

        public static void Yaz(int[] dizi)
        {
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
        }
        */

        /*
        public static int Yaz(string diziAd,int[] dizi)
        {
            Console.WriteLine(diziAd + "nci dizinin elemanlari");

            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
            return dizi.Sum();
        }
        */
       
        //metotlarda string kullanimi

        public static void Yaz(string diziAd, string[] dizi)
        {
            Console.WriteLine(diziAd + " dizisinin elemanlari");
            foreach (string i in dizi)
            {
                Console.WriteLine(i);
            }
        }
          
        static void Main(string[] args)
        {
            /*  
            //ayni boyutta 2 sayi dizi tanimla bunlari topla yeni diziye ata

            Console.WriteLine("Dizi boyutnu gir = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] dizi1 = new int[n];
            int[] dizi2 = new int[n];
            int[] dizi3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1nci dizinin "+ (i + 1) + ".ci Eleman = ");
                dizi1[i]= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2nci dizinin " + (i + 1) + ".ci Eleman = ");
                dizi2[i] = Convert.ToInt32(Console.ReadLine());

                dizi3[i] = dizi1[i] + dizi2[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Toplam dizinin " + (i + 1) + ".ci Eleman = ");
                Console.WriteLine(dizi3[i]);
            }

            foreach (int d in dizi3)
            {
                Console.WriteLine("Toplam = " + d);
            }
            */

            /*
            //kullanicidan alinan N boyutlu sayi dizisinin elemanlarini tersten baska diziye aktar

            Console.WriteLine("Dizi boyutnu gir = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] dizi1 = new int[n];
            int[] dizi2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1nci dizinin " + (i + 1) + ".ci Eleman = ");
                dizi1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int a = 0;
            for (int i = (n-1); i >= 0 ; i--)
            {
                dizi2[i] = dizi1[a];
                a++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("2nci dizinin " + (i + 1) + ".ci Eleman = ");
                Console.WriteLine(dizi2[i]);
            }
            */

            /*
            //2 boyutlu diziler

            string[,] sehirPlaka ={ {"duzce ", "81"},{ "eses ", "26"},{ "ankara ", "06"} };

            for (int i = 0; i < sehirPlaka.GetLength(0); i++)
            {
                for(int j = 0; j < sehirPlaka.GetLength(1); j++)
                {
                    Console.Write(sehirPlaka[i,j]);
                }
                Console.WriteLine();
            }

            foreach (string sp in sehirPlaka)
            {
                Console.WriteLine(sp);
            }
            */

            //Metotlar

            /*
            Topla();
            Carp();
            int sayi = Bol(4, 2);
            Console.WriteLine(sayi);
            Console.WriteLine(Birlestir("Ali", "Veli"));
            */
            /*
            Topla();
            Topla(80, 50);
            */

            /*
            int[] dizi = { 1, 2, 3 };
            int[] dizi2 = { 100, 200, 300 };

            Yaz(dizi);
            Yaz(dizi2);

            Yaz("1", dizi);
            Console.WriteLine("Dizideki elemanlarin toplami = " + Yaz("1",dizi));
            */

            string[] isimler = { "ali", "veli", "hayri" };
                Yaz("Isimler", isimler); 
        }
    }
}
