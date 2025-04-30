using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BookingJSONRepository : BookingCollectionRepo
    {
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

        public override void Add(Booking booking)
        {
            base.Add(booking);
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
