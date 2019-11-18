namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BANK_BRANCHES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BANK_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SORTCODE { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [StringLength(100)]
        public string ADDRESS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TRANS_ID { get; set; }
    }
}
