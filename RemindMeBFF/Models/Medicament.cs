using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemindMeBFF.Models
{
    public class Frequency
    {
        public int times { get; set; }
        public string repeat_every { get; set; }
    }

    public class Medicament
    {
        public int id { get; set; }
        public string name { get; set; }
        public string about { get; set; }
        public string tips { get; set; }
        public string photo { get; set; }
        public List<string> medicament_type { get; set; }
        public Frequency frequency { get; set; }
    }
}
