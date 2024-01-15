using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ders8
{
    public partial class OBSContext : DbContext
    {
        public OBSContext()
            : base("name=OBSContext")
        {
        }

        public virtual DbSet<Ders> Ders { get; set; }
        public virtual DbSet<OgrDetay> OgrDetay { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<OgrenciDers> OgrenciDers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Veli> Veli { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>()
                .Property(e => e.DersKodu)
                .IsFixedLength();

            modelBuilder.Entity<Ogrenci>()
                .HasOptional(e => e.OgrDetay)
                .WithRequired(e => e.Ogrenci);

            modelBuilder.Entity<OgrenciDers>()
                .Property(e => e.HarfNot)
                .IsFixedLength();

            modelBuilder.Entity<Veli>()
                .Property(e => e.TCNo)
                .IsFixedLength();
        }
    }
}
