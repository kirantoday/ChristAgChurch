using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristAgChurch.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceLocation { get; set; }
        public DateTime ServiceDate { get; set; }
    }
}
