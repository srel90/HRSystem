using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enExpenditure
    {
        public int expenditureID { get; set; }
        public int personalID { get; set; }
        public int expenditureType { get; set; }
        public string description { get; set; }
        public string calTax { get; set; }
        public string calSocialTax { get; set; }
        public double amount { get; set; }
    }
}
