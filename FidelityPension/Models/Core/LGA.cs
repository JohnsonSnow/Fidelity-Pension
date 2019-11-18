using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class LGA : BaseEntity
    {
        public string Value { get; set; }
        public string Code { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}