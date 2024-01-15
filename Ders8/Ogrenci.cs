namespace Ders8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Ogrenci")]
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            OgrenciDers = new HashSet<OgrenciDers>();
        }

        public int OgrenciID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        public int? OgrNo { get; set; }

        public int? VeliID { get; set; }

        public virtual OgrDetay OgrDetay { get; set; }

        public virtual Veli Veli { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }

        public void OgrenciListele()
        {
            Console.WriteLine("----Öðrenciler----");
            OBSContext context = new OBSContext();
            var ogrenciList = context.Ogrenci.ToList();
            foreach (var o in ogrenciList)
            {
                Console.WriteLine("Öðrenci ID = " + o.OgrenciID + " Adi = " + o.Ad + " Soyad = " + o.Soyad);
            }
        }

        public void OgrenciEkle(Ogrenci ogrenci)
        {
            OBSContext context = new OBSContext();
            context.Ogrenci.Add(ogrenci);
            context.SaveChanges();
            Console.WriteLine("Ogrenci Basariyla Eklendi");
        }

        public void OgrenciGuncelle(int OgrID, string OgrAd, string OgrSoyad)
        {
            OBSContext context = new OBSContext();
            var ogrGuncel = context.Ogrenci.Where(x => x.OgrenciID == OgrID).FirstOrDefault();
            ogrGuncel.Ad = OgrAd;
            ogrGuncel.Soyad = OgrSoyad;
            context.SaveChanges();
            Console.WriteLine("Ogrenci Basariyla Guncellendi");
        }
    }
}
