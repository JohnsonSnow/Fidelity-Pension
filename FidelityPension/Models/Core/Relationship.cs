﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.Models.Core
{
    public class Relationship : BaseEntity
    {
        public string Value { get; set; }
        public string Code { get; set; }
    }
}