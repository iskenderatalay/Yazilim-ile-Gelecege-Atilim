using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    public class Otobus
    {
        public int bosKoltukSayisi;
        public int toplamKoltukSayisi;
        public int kazanc = 0;
        public int indirimli;
        public int tam;
        public int iptalSayisi = 0;

        public string firmaAd;
        public string gun;
        public string saat;
        public string plaka;
        public string guzergah;
        public string molaYer;

        public Otobus(string firmaAd, int koltukSayisi, string gun, string saat, string plaka,
            string guzergah, string molaYer, int indirimli, int tam)
        {
            this.firmaAd = firmaAd;
            toplamKoltukSayisi = koltukSayisi;
            bosKoltukSayisi = koltukSayisi;
            this.gun = gun;
            this.saat = saat;
            this.plaka = plaka;
            this.guzergah = guzergah;
            this.molaYer = molaYer;
            this.indirimli = indirimli;
            this.tam = tam;
        }

        public void BiletSat(bool indirimliMi)
        {
            if (bosKoltukSayisi > 0)
            {
                bosKoltukSayisi--;
                if (indirimliMi)
                {
                    kazanc = kazanc + indirimli;
                    Console.WriteLine("1 adet indirimli bilet sattin");
                }
                else
                {
                    kazanc = kazanc + tam;
                    Console.WriteLine("1 adet tam bilet sattin");
                }
            }
            else
                Console.WriteLine("Bilet Kalmadi");
        }

        public void BiletIptal(bool indirimliMi)
        {
            iptalSayisi++;
            bosKoltukSayisi++;
            if (indirimliMi)
            {
                kazanc = kazanc -indirimli;
                Console.WriteLine("1 adet indirimli bilet iade edildi");
            }
            else
            {
                kazanc = kazanc - tam;
                Console.WriteLine("1 adet tam bilet iade edildi");
            }
        }

        public void KazancOgren()
        {
            Console.WriteLine("Kazanc = " + kazanc);
        }

        public void BosKoltukOgren()
        {
            Console.WriteLine("Bos Koltuk Sayisi = " + bosKoltukSayisi);
            Console.WriteLine("Satilan Bilet Sayisi = " + (toplamKoltukSayisi - bosKoltukSayisi));
        }

        public void IptalOgren()
        {
            Console.WriteLine("Iade Edilen Bilet Sayisi = " + iptalSayisi);
        }
    }
}