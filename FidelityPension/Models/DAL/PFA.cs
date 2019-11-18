namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PFA")]
    public partial class PFA
    {
        [Required]
        [StringLength(20)]
        public string PFA_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PFA_NAME { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string PFA_ADDRESS { get; set; }

        [StringLength(60)]
        public string PFA_PHONE { get; set; }

        [StringLength(80)]
        public string PFA_EMAIL { get; set; }

        [StringLength(100)]
        public string PFA_LOGO { get; set; }

        [StringLength(80)]
        public string CONTACT_PERSON { get; set; }

        [StringLength(60)]
        public string CONTACT_PHONE { get; set; }

        [StringLength(80)]
        public string CONTACT_EMAIL { get; set; }

        [StringLength(80)]
        public string WEBSITE { get; set; }

        [Key]
        public long TRANSID { get; set; }
    }
}
