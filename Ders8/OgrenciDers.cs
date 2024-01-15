namespace Ders8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OgrenciDers
    {
        public int OgrenciDersID { get; set; }

        public int? OgrenciID { get; set; }

        public int? DersID { get; set; }

        public int? VizeNot { get; set; }

        public int? FinalNot { get; set; }

        [StringLength(2)]
        public string HarfNot { get; set; }

        public virtual Ders Ders { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }
    }
}
