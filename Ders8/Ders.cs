namespace Ders8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;

    public partial class Ders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ders()
        {
            OgrenciDers = new HashSet<OgrenciDers>();
        }

        public int DersID { get; set; }

        [StringLength(10)]
        public string DersKodu { get; set; }

        [StringLength(50)]
        public string DersAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }

        public void DersListele()
        {
            Console.WriteLine("----Dersler----");
            OBSContext context = new OBSContext();
            var dersList = context.Ders.ToList();
            foreach (var d in dersList)
            {
                Console.WriteLine("Ders ID = " + d.DersID + " Ders Kodu = " + d.DersKodu + " Ders Adi = " + d.DersAdi );
            }
        }

        public void DersEkle(Ders ders)
        {
            OBSContext context = new OBSContext();
            context.Ders.Add(ders);
            context.SaveChanges();
            Console.WriteLine("Ders Basariyla Eklendi");
        }

        public void dersSil(int DersID)
        {
            OBSContext context = new OBSContext();
            var silDers = context.Ders.Where(x => x.DersID == DersID).FirstOrDefault();
            context.Ders.Remove(silDers);
            context.SaveChanges();
            Console.WriteLine("Ders Basariyla Silindi");
        }

        public void DersGuncelle(int DersID, string DersKod, string DersAd)
        {
            OBSContext context = new OBSContext();
            var dersGuncelle = context.Ders.Where(x=>x.DersID==DersID).FirstOrDefault();
            dersGuncelle.DersKodu = DersKod;
            dersGuncelle.DersAdi = DersAd;
            context.SaveChanges();
            Console.WriteLine("Ders Basariyla Guncellendi");
        }
    }
}
