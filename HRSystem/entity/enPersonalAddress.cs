using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.entity
{
    class enPersonalAddress
    {
        public int personalAddressID { get; set; }
        public int personalID { get; set; }
        public string building { get; set; }
        public string room { get; set; }
        public string floor { get; set; }
        public string village { get; set; }
        public string number { get; set; }
        public string lanes { get; set; }
        public string group { get; set; }
        public string road { get; set; }
        public string district { get; set; }
        public string subdistrict { get; set; }
        public string province { get; set; }
        public string postcode { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string ERContact { get; set; }
        public string relation { get; set; }
        public string contactNumber { get; set; }
    }
}
