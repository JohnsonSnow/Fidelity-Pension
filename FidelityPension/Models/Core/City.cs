using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class City : BaseEntity
    {
        public string Value { get; set; }
        public string Code { get; set; }
        public int LGAId { get; set; }
        public virtual LGA LGA { get; set; }
    }
}