﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enWork
    {
        public int workID { get; set; }
        public int personalID { get; set; }
        public int partyID { get; set; }
        public int departmentID { get; set; }
        public int positionID { get; set; }
        public int personalTypeID { get; set; }
        public string level { get; set; }
        public int workStatus { get; set; }
        public string startDate { get; set; }
        public string resignDate { get; set; }
        public string taxNumber { get; set; }
        public string idCard { get; set; }
        public string issueDate { get; set; }
        public string expireDate { get; set; }
        public string issueAddress { get; set; }
        public string idCardAddress { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
    }
}
