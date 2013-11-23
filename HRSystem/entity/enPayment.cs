using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enPayment
    {
        public int paymentID { get; set; }
        public int personalID { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string payDate { get; set; }
        public double expenditureInc { get; set; }
        public double expenditureDec { get; set; }
        public double leaveDec { get; set; }
        public double lateDec { get; set; }
        public double OTInc { get; set; }
        public double socialTaxDec { get; set; }
        public double taxDec { get; set; }
        public double total { get; set; }
        public double salary { get; set; }
    }
}
