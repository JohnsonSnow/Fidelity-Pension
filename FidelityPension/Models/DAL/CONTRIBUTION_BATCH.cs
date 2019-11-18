namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRIBUTION_BATCH
    {
        [Key]
        [StringLength(15)]
        public string BATCH_ID { get; set; }

        public decimal? USERID { get; set; }

        public DateTime? CREATED { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [StringLength(1)]
        public string CHECKED { get; set; }

        public decimal? CHECKED_BY { get; set; }

        public DateTime? CHECKED_DATE { get; set; }

        [StringLength(200)]
        public string NARRATION { get; set; }

        public decimal? SCHEME_ID { get; set; }

        public DateTime? CLEARED_DATE { get; set; }

        [StringLength(1)]
        public string BATCH_TYPE { get; set; }

        public decimal? FEECODE { get; set; }

        [StringLength(10)]
        public string BRANCH_CODE { get; set; }

        [StringLength(10)]
        public string PFA_CODE { get; set; }

        [StringLength(10)]
        public string OLD_PFACODE { get; set; }

        [StringLength(15)]
        public string PFC_CODE { get; set; }

        [StringLength(15)]
        public string EMPLOYER_CODE { get; set; }

        public decimal? SCHEDULE_ID { get; set; }

        public decimal? CONT_AMOUNT { get; set; }

        [StringLength(250)]
        public string TXN { get; set; }

        public int? SNO { get; set; }

        [StringLength(10)]
        public string CONTRIBUTION_TYPE { get; set; }

        public decimal? LOADED { get; set; }

        public decimal? PROCCESSED { get; set; }

        [StringLength(15)]
        public string REFNO { get; set; }

        [StringLength(250)]
        public string FILE_NAME { get; set; }

        [StringLength(1)]
        public string LOCKED { get; set; }

        [StringLength(1)]
        public string INTEREST { get; set; }

        public DateTime? INTEREST_DATE { get; set; }

        public decimal? INTEREST_BY { get; set; }
    }
}
