using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    public class Kopek
    {
        public string ad;
        public string renk;
        public string cins;
        public bool acMi;

        public void Havla()
        {
            Console.WriteLine("Hav hav");
        }

        public void KuyrukSalla()
        {
            Console.WriteLine("Kopek kuyruk salliyor");
        }

        public void KopekEkle(string ad, string renk, string cins, bool acMi)
        {
            this.ad = ad;
            this.renk = renk;
            this.cins = cins;
            this.acMi = acMi;
        }

        public void KopekGetir()
        {
            Console.WriteLine(ad + " " + renk + " " + cins + " " + acMi);
        }
    }
}
