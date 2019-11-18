namespace FidelityPension.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_USER
    {
        [Key]
        [StringLength(20)]
        public string USER_ID { get; set; }

        [StringLength(20)]
        public string USER_NAME { get; set; }

        [StringLength(20)]
        public string PASSWORD { get; set; }

        [StringLength(1)]
        public string DAY_1 { get; set; }

        [StringLength(1)]
        public string DAY_2 { get; set; }

        [StringLength(1)]
        public string DAY_3 { get; set; }

        [StringLength(1)]
        public string DAY_4 { get; set; }

        [StringLength(1)]
        public string DAY_5 { get; set; }

        [StringLength(1)]
        public string DAY_6 { get; set; }

        [StringLength(1)]
        public string DAY_7 { get; set; }

        public DateTime? EXPIRES { get; set; }

        [StringLength(1)]
        public string SUPERVISOR { get; set; }

        [StringLength(1)]
        public string USER_LOGIN { get; set; }

        [StringLength(1)]
        public string PASS_FREQ { get; set; }

        public decimal? PASS_DURATION { get; set; }

        [StringLength(60)]
        public string FULL_NAME { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal USERID { get; set; }

        [StringLength(20)]
        public string USERPIN { get; set; }

        [StringLength(20)]
        public string ROLEID { get; set; }

        [StringLength(10)]
        public string TITLE { get; set; }

        [StringLength(25)]
        public string FIRSTNAME { get; set; }

        [StringLength(25)]
        public string LASTNAME { get; set; }

        [StringLength(40)]
        public string COMPANY { get; set; }

        [StringLength(40)]
        public string STREET { get; set; }

        [StringLength(25)]
        public string CITY { get; set; }

        [StringLength(25)]
        public string STATE { get; set; }

        [StringLength(10)]
        public string ZIP { get; set; }

        [StringLength(40)]
        public string COUNTRY { get; set; }

        [StringLength(30)]
        public string PHONE { get; set; }

        [StringLength(30)]
        public string FAX { get; set; }

        [StringLength(80)]
        public string EMAIL { get; set; }

        [StringLength(40)]
        public string HINTQUESTION { get; set; }

        [StringLength(40)]
        public string HINTANSWER { get; set; }

        [StringLength(1)]
        public string PASSCHG_LOGON { get; set; }

        [StringLength(1)]
        public string PASSNO_EXPIRE { get; set; }

        public DateTime? PASSDT_EXPIRE { get; set; }

        public decimal? PIN_MISSED { get; set; }

        [StringLength(1)]
        public string PASSNO_CHANGE { get; set; }

        [StringLength(1)]
        public string USER_DISABLED { get; set; }

        [StringLength(1)]
        public string USER_LOCKED { get; set; }

        public DateTime? LAST_USED { get; set; }

        public DateTime? CREATED { get; set; }

        public DateTime? MODIFIED { get; set; }

        [StringLength(1)]
        public string USER_TYPE { get; set; }

        [StringLength(20)]
        public string ACCOUNT_NUMBER { get; set; }

        public decimal? INVESTOR_ID { get; set; }

        [StringLength(10)]
        public string BRANCH_CODE { get; set; }

        [StringLength(30)]
        public string WORKSTATION { get; set; }

        public DateTime? LAST_PASSWORD_CHANGE_DATE { get; set; }

        public DateTime? DATE_DISABLED { get; set; }
    }
}
