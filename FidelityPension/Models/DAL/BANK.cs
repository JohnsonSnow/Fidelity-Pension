namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANKS")]
    public partial class BANK
    {
        [Key]
        [StringLength(10)]
        public string CODE { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TRANS_ID { get; set; }
    }
}
