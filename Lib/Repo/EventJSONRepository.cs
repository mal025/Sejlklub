using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class EventJSONRepository : IEventRepo
    {
        protected List<Event> _events = new List<Event>();
        public EventJSONRepository(string path = @"..\Web\JSON\")
        {
            LoadFile(path);
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path)
        {
            string json = File.ReadAllText(path+"events.json");

            _events = JsonSerializer.Deserialize<List<Event>>(json);
        }

        public void Add(Event theEvent, string path = @"..\Web\JSON\")
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
            
            File.WriteAllText(path+"events.json", JsonSerializer.Serialize(_events));
        }

        public Event GetByID(int id)
        {
            foreach(Event theEvent in _events)
            {
                if (id == theEvent.ID)
                {
                    return theEvent;
                }
            }
            
            return null;
        }

    }
}
