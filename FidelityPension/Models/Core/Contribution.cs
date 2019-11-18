using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class Contribution : BaseEntity
    {
        public int TranscationType { get; set; }
        public string Description { get; set; }
        public decimal Deposit { get; set; }
        public decimal Withdrawal { get; set; }
        public decimal Balance { get; set; }
        public decimal CurrentContigencyAmount { get; set; }
        public decimal CurrentRetirementAmount { get; set; }
        public int? WithdrawalFrom { get; set; }
    }
}