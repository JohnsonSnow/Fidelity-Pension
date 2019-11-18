namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPLOYER_DETAILS
    {
        [Key]
        [StringLength(20)]
        public string RCNO { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ADDRESS { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CORRESPONDENCE_ADDS { get; set; }

        [StringLength(40)]
        public string EMAIL_ADDS { get; set; }

        [StringLength(50)]
        public string WEBSITE_ADDS { get; set; }

        [StringLength(10)]
        public string INDUSTRY { get; set; }

        [StringLength(10)]
        public string BUSINESS_TYPE { get; set; }

        [Required]
        [StringLength(15)]
        public string EMPLOYER_ID { get; set; }

        [StringLength(40)]
        public string PHONE { get; set; }

        [StringLength(60)]
        public string CONTACT { get; set; }

        public bool ER_PFC_CHECK { get; set; }

        [StringLength(15)]
        public string ER_PFC_BATCH { get; set; }

        [StringLength(10)]
        public string SECTOR { get; set; }

        [StringLength(20)]
        public string SUBSECTOR { get; set; }

        [StringLength(1)]
        public string STATUS { get; set; }

        public decimal? RETIREMENT_AGE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TRANSID { get; set; }

        public DateTime? ENTRY_DATE { get; set; }

        [StringLength(1)]
        public string EMAIL_ONLY { get; set; }

        public int? STMT_OPTION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Sequence_Identity { get; set; }

        public bool IsAccountAssigned { get; set; }

        public DateTime? IsAccountAssigned_Date { get; set; }
    }
}
