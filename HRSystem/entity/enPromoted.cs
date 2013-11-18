using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enPromoted
    {
        public int promotedID { get; set; }
        public int personalID { get; set; }
        public DateTime updateDate { get; set; }
        public double oldSalary { get; set; }
        public double newSalary { get; set; }
        public int oldPositionID { get; set; }
        public string oldPositionDetail { get; set; }
        public int newPositionID { get; set; }
        public string newPositionDetail { get; set; }
        public string remark { get; set; }
    }
}
