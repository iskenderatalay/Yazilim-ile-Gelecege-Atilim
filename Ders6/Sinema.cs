using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6
{
    public class Sinema
    {
        public int toplamKoltukSayisi;
        public int bosKoltukSayisi;
        public string salonNo;
        public int bakiye;

        public int tam = 15;
        public int indirimli = 10;

        /*
        //kurucu metot ayni adla olur
        public Sinema()
        {
            Console.WriteLine("Sinema sinifindan yeni bir nesne olusturuldu");
        }
        */

        public Sinema(string salonNo, int koltukSayisi)
        {
            this.salonNo = salonNo;
            toplamKoltukSayisi = koltukSayisi;
            bosKoltukSayisi = koltukSayisi;
            bakiye = 0;

            Console.WriteLine(salonNo + " " + "de bos koltuk sayisi = " + bosKoltukSayisi);
        }

        public void BiletSat(bool ogrenciMi)
        {
            if(bosKoltukSayisi > 0)
            {
                bosKoltukSayisi -= 1;
                if (ogrenciMi)
                {
                    bakiye = bakiye + indirimli;
                }
                else
                {
                    bakiye = bakiye + tam;
                }
            }
            else
            {
                Console.WriteLine("Bu salonda bos koltuk yok");
            }
        }

        public void BiletIptal(bool ogrenciMi)
        {
            bosKoltukSayisi++;
            if (ogrenciMi)
            {
                bakiye = bakiye - indirimli;
            }
            else
            {
                bakiye = bakiye - tam;
            }
        }

        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }

        public int BakiyeOgren()
        {
            return bakiye;
        }
    }
}