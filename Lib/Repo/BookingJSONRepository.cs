using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BookingJSONRepository : IBookingRepo
    {
        public List<Booking> _bookings = new List<Booking>();
        public BookingJSONRepository(string path)
        {
            LoadFile(path);
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path)
        {
 
            string json = File.ReadAllText(path+ "bookings.json");

            _bookings = JsonSerializer.Deserialize<List<Booking>>(json);
        }

        public void Add(Booking booking, string path)
        {
            _bookings.Add(booking);
            SaveFile(path);
        }
        public List<Booking> GetAll()
        {
            return _bookings;
        }
        public void RemoveByID(int id, string path)
        {
            _bookings.RemoveAll(booking => booking.ID == id);
            SaveFile(path);
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile(string path)
        {

            File.WriteAllText(path+ "bookings.json", JsonSerializer.Serialize(_bookings));
        }
    }
}
