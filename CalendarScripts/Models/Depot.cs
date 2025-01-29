using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScripts.Models
{
    public class Depot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short { get; set; }
        public List<OpeningHours> Openings { get; set; }
    }
}
