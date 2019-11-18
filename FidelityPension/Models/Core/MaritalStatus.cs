using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class MaritalStatus : BaseEntity
    {
        public string Value { get; set; }
        public string Code { get; set; }
    }
}