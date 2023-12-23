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
        public int bakiye;
        public int ogrenci = 5;
        public int sivil = 15;
        public int satilanKoltukSayisi;

        public string otobusNo;

        public Otobus(string otobusNo, int koltukSayisi)
        {
            this.otobusNo = otobusNo;
            toplamKoltukSayisi = koltukSayisi;
            bosKoltukSayisi = koltukSayisi;
            bakiye = 0;
            satilanKoltukSayisi = 0;
            Console.WriteLine(otobusNo + " bos koltuk sayisi = " + bosKoltukSayisi);
        }

        public void BiletSat(bool ogrenciMi)
        {
            if (bosKoltukSayisi > 0)
            {
                satilanKoltukSayisi++;
                bosKoltukSayisi--;
                if(ogrenciMi)
                {
                    bakiye = bakiye + ogrenci ;
                }
                else
                {
                    bakiye = bakiye + sivil ;
                }
            }
            else
                Console.WriteLine("Bos Koltuk Yok");
        }

        public void BiletIptal(bool ogrenciMi)
        {
            satilanKoltukSayisi--;
            bosKoltukSayisi++;
            if (ogrenciMi)
            {
                bakiye = bakiye - ogrenci;
            }
            else
                bakiye = bakiye - sivil;
        }

        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }
        public int SatilanKoltukOgren()
        {
            return satilanKoltukSayisi;
        }
        public int BakiyeOgren()
        {
            return bakiye;
        }
    }
}
