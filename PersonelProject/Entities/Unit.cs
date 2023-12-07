namespace PersonelProject.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unit
    {
        public int UnitID { get; set; }

        [StringLength(50)]
        public string UnitName { get; set; }

        [Column(TypeName = "text")]
        public string Explanation { get; set; }
    }
}
