using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Event
    {
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public Member Creator { get; set; }
        public List<Member> Member { get; set; }
        public string Requirements { get; set; }
        public List<Booking> Booking { get; set; }
        public int ID { get; set; }

        public Event(DateTime time, string description, string location, int capacity, Member creator,
                 List<Member> member, string requirements, List<Booking> booking, int id)
        {
            Time = time;
            Description = description;
            Location = location;
            Capacity = capacity;
            Creator = creator;
            Member = member;
            Requirements = requirements;
            Booking = booking;
            ID = id;
        }
    }
}
