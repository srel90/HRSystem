using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enLeaveRight
    {
        public int leaveRightID { get; set; }
        public int personalID { get; set; }
        public string year { get; set; }
        public string description { get; set; }
        public int leaveAmount { get; set; }
        public int usedLeaveAmount { get; set; }
        public int balanceLeaveAmount { get; set; }
    }
}
