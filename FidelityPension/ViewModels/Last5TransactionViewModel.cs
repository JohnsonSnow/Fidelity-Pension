using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.ViewModels
{
    public class Last5TransactionViewModel
    {
        public string EmployeeContribution { get; set; }
        public string EmployerContribution { get; set; }
        public string Narration { get; set; }
        public string OtherContribution { get; set; }
        public string ValueDate { get; set; }
    }
}