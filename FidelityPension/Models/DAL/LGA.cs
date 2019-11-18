namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LGA")]
    public partial class LGA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string STATE_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(60)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TRANSID { get; set; }
    }
}
