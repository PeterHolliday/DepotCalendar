using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScripts.Models
{
    public class OpeningHours
    {
        public string Day { get; set; }
        public string ClosedFrom { get; set; }
        public string OpensAt { get; set; }
        public string ClosesAt{ get; set; }
        public string ClosedUntil { get; set; }
    }
}
