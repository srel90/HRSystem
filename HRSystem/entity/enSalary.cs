using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enSalary
    {
        public int salaryID { get; set; }
        public int personalID { get; set; }
        public string bank { get; set; }
        public string accountNumber { get; set; }
        public int calculateType { get; set; }
        public double salary { get; set; }
        public double shiftSalary { get; set; }
        public string calTax { get; set; }
        public string calSocialTax { get; set; }
        public int lateDeduct { get; set; }
        public int leaveDeduct { get; set; }
    }
}
