using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enTimeTable
    {
        public int timeTableID { get; set; }
        public string personalCard { get; set; }
        public string timetable { get; set; }
        public string onduty { get; set; }
        public string offduty { get; set; }
        public string clockIn { get; set; }
        public string clockOut { get; set; }
    }
}
