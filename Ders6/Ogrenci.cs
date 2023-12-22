using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    public class Ogrenci
    {
        /*
        public int numara;
        public string ad;
        public string soyad;
        */

        //default degerli tanimlama

        public int numara = 140;
        public string ad="Ali";
        public string soyad="Veli";

        public void Ekle(string ad, string soyad,int numara)
        {
            this.ad = ad;
            this.soyad = soyad; 
            this.numara = numara;
        }
    }
}
