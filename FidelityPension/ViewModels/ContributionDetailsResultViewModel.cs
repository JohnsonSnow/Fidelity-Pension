using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.ViewModels
{
    public class ContributionDetailsResultViewModel
    {
        public string EmployeeContribution { get; set; }
        public string EmployerContribution { get; set; }
        public string EmployerName { get; set; }
        public string AvcContribution { get; set; }
        public string Narration { get; set; }
        public string AvcWithdrawal { get; set; }
        public string ContributionDate { get; set; }
        public string Price { get; set; }
        public string TotalFee { get; set; }
        public string VatFee { get; set; }
        public string ValueDate { get; set; }
        public string Withdrawal { get; set; }
    }
}