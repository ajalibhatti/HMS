﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class AccomodationPackage
    {
        public int ID { get; set; }
        public int AccomodationTypeID { get; set; }
        public AccomodationType AccomodationType { get; set; }
        public string Name { get; set; }
        public int NoOfRooms { get; set; }
        public decimal FeePerNight { get; set; }
    }
}
