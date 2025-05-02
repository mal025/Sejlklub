using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;
using Lib.Repo;

namespace Lib.Services
{
    public class BookingService
    {
        private IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }
        public List<Booking> GetAll()
        {
            return _bookingRepo.GetAll();
        }

        public void Add(Booking booking, string path)
        {
            _bookingRepo.Add(booking, path);
        }
        public void RemoveByID(int id, string path)
        {
            _bookingRepo.RemoveByID(id, path);
        }
    }
}
