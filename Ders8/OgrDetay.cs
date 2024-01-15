namespace Ders8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OgrDetay")]
    public partial class OgrDetay
    {
        [Key]
        public int OgrenciID { get; set; }

        [StringLength(250)]
        public string OgrAdress { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
    }
}
