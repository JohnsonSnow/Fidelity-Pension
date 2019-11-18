using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class State : BaseEntity
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public string Value { get; set; }
        public string Code { get; set; }

    }
}