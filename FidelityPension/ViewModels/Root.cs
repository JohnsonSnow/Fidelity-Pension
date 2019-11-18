using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidelityPension.ViewModels
{
    public class Root
    {
        public List<Dictionary<string, object>> LastFiveTransactionsWebResult { get; set; }
        public Dictionary<string, object> BalanceResult { get; set; }
        public List<Dictionary<string, object>> ContributionDetailsResult { get; set; }
        public double FundI { get; set; }
        public Dictionary<string, object> FundII { get; set; }
        public Dictionary<string, object> FundIII { get; set; }
        public Dictionary<string, object> FundIV { get; set; }
        [JsonIgnore]
        public Dictionary<string, string> JSON { get; set; }
        //public double JSON { get; set; }
    }



}