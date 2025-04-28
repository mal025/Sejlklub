using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    internal class Booking
    {


        public Member member { get; set; }
        public List<DateTime> TimeFrame { get; set; }
        public Boat boat { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int ID { get; set; }



    }
}
