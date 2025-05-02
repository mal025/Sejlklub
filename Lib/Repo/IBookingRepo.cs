using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public interface IBookingRepo
    {
        public List<Booking> GetAll();
        public void Add(Booking booking);
        public void RemoveByID(int id);
        public Booking GetByID(int id);


    }
}
