using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class EventJSONRepository : IEventRepo
    {
        protected List<Event> _events = new List<Event>();
        public EventJSONRepository(string path)
        {
            LoadFile(path);
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path)
        {
            string json = File.ReadAllText(path+"event.json");

            _events = JsonSerializer.Deserialize<List<Event>>(json);
        }

        public void Add(Event theEvent, string path)
        {
            _events.Add(theEvent);
            SaveFile(path);
        }

        public List<Event> GetAll()
        {
            return _events;
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile(string path)
        {
            
            File.WriteAllText(path+"event.json", JsonSerializer.Serialize(_events));
        }
    }
}
