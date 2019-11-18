namespace FidelityPension.Models.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AGENT")]
    public partial class AGENT
    {
        [Key]
        [StringLength(15)]
        public string AGENT_CODE { get; set; }

        [Required]
        [StringLength(60)]
        public string AGENT_NAME { get; set; }

        [StringLength(15)]
        public string MOBILE_PHONE { get; set; }

        [StringLength(15)]
        public string HOME_PHONE { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string WEBSITE { get; set; }

        [Column(TypeName = "text")]
        public string PERMANENT_ADDRESS { get; set; }

        [Column(TypeName = "text")]
        public string CORRESPONDENCE_ADDS { get; set; }

        [StringLength(15)]
        public string BRANCH_CODE { get; set; }
    }
}
