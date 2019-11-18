namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTRIBUTION")]
    public partial class CONTRIBUTION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string BATCH_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string PIN { get; set; }

        public decimal? EMPLOYEE_CONTRIBUTION { get; set; }

        public decimal? EMPLOYER_CONTRIBUTION { get; set; }

        public DateTime? CONTRIBUTION_DATE { get; set; }

        [StringLength(1)]
        public string POSTED { get; set; }

        public decimal? OTHER_CONTRIBUTION { get; set; }

        [StringLength(1)]
        public string EMPLOYEE_VARIANCE { get; set; }

        [StringLength(1)]
        public string EMPLOYER_VARIANCE { get; set; }

        [StringLength(1)]
        public string OTHER_VARIANCE { get; set; }

        public decimal? OTHER_FEE { get; set; }

        public decimal? TOTAL_UNITS { get; set; }

        public decimal? TOTAL_CONTRIBUTION { get; set; }

        public decimal? TOTAL_FEE { get; set; }

        public decimal? EMPLOYEE_BF { get; set; }

        public decimal? EMPLOYER_BF { get; set; }

        [StringLength(20)]
        public string EMPLOYER_CODE { get; set; }

        public DateTime? PAYMENT_DATE { get; set; }

        public DateTime? TRANS_DATE { get; set; }

        public decimal? SCHEME_ID { get; set; }

        public decimal? WITHDRAWAL { get; set; }

        public decimal? PAYMENT_ID { get; set; }

        public decimal? WITHDRAWAL_VC { get; set; }

        public decimal? PRICE { get; set; }

        public decimal? TRANS_UNITS_R { get; set; }

        public decimal? TRANS_UNITS_V { get; set; }

        public decimal? WITHDRAWAL_AMT { get; set; }

        [StringLength(1)]
        public string TRANS_TYPE { get; set; }

        public decimal? EE_LEGACY { get; set; }

        public decimal? ER_LEGACY { get; set; }

        public DateTime? VALUE_DATE { get; set; }

        public decimal? VAT_FEE { get; set; }

        [StringLength(1)]
        public string RETIREE_DEPOSITE { get; set; }

        public decimal? FUND_ID { get; set; }

        [StringLength(10)]
        public string BRANCH_CODE { get; set; }

        [StringLength(10)]
        public string OLD_PFACODE { get; set; }

        [StringLength(250)]
        public string DESCRIPTION { get; set; }

        [StringLength(15)]
        public string PFC_CODE { get; set; }

        [StringLength(10)]
        public string PFA_CODE { get; set; }

        public decimal? TRANS_UNITS { get; set; }

        [StringLength(1)]
        public string SENT { get; set; }

        public decimal? EMPLOYEE_FEE { get; set; }

        public decimal? EMPLOYER_FEE { get; set; }

        public decimal? POSTED_BY { get; set; }

        public DateTime? POSTED_DATE { get; set; }

        public decimal? USERID { get; set; }

        public decimal? FEE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TRANS_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool ISNOTIFIED { get; set; }

        public DateTime? ISNOTIFIED_DATE { get; set; }

        [StringLength(1)]
        public string CHECKED { get; set; }

        public decimal? CHECKED_BY { get; set; }

        public DateTime? CHECKED_DATE { get; set; }

        [StringLength(1)]
        public string POSTED1 { get; set; }
    }
}
