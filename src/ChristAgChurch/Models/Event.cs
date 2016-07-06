using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristAgChurch.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string EventLocation { get; set; }
        public DateTime EventDate { get; set; }
    }
}
