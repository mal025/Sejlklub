using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public class BookingCollectionRepo : IBookingRepo
    {
        public List<Booking> _bookings = new List<Booking>();
        public void Add(Booking booking)
        {
            _bookings.Add(booking);
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }

        public void RemoveByID(int id)
        {
            _bookings.RemoveAll(booking => booking.ID == id);
        }
    }
}
