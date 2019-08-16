using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class AccomodationType
    {
        public int ID { get; set; }
        public string Name { get; set; }   // hotel room or apartment
        public string Description { get; set; }
    }
}
