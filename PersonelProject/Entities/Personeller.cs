namespace PersonelProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personeller")]
    public partial class Personeller
    {
        [Key]
        public int PersonelD { get; set; }

        public int? UnitID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public bool? IsActive { get; set; }
    }
}
