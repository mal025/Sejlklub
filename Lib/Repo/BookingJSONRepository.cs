using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BookingJSONRepository : IBookingRepo
    {
        public List<Booking> _bookings = new List<Booking>();
        public BookingJSONRepository()
        {
            LoadFile();
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile()
        {
            string path = @"..\..\..\JSON\bookings.json";
            string json = File.ReadAllText(path);

            _bookings = JsonSerializer.Deserialize<List<Booking>>(json);
        }

        public void Add(Booking booking)
        {
            _bookings.Add(booking);
            SaveFile();
        }
        public List<Booking> GetAll()
        {
            return _bookings;
        }
        public void RemoveByID(int id)
        {
            _bookings.RemoveAll(booking => booking.ID == id);
            SaveFile();
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile()
        {
            string path = @"..\..\..\JSON\bookings.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_bookings));
        }
    }
}
