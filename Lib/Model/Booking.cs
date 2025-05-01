using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class Booking
    {
        public Member Member { get; set; }
        public List<DateTime> TimeFrame { get; set; }
        public Boat Boat { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int ID { get; set; }

        public Booking(Member member, List<DateTime> timeFrame, Boat boat, string description, string type, int iD)
        {
            Member = member;
            TimeFrame = timeFrame;
            Boat = boat;
            Description = description;
            Type = type;
            ID = iD;
        }

        public Booking ()
        {
        }

    }
}
