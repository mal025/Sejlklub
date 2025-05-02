using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class EventJSONRepository : IEventRepo
    {
        protected List<Event> _events = new List<Event>();
        public EventJSONRepository()
        {
            LoadFile();
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path= @"..\..\..\JSON\events.json")
        {
            string json = File.ReadAllText(path);

            _events = JsonSerializer.Deserialize<List<Event>>(json);
        }

        public void Add(Event theEvent)
        {
            _events.Add(theEvent);
        SaveFile();
        }

        public List<Event> GetAll()
        {
            return _events;
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile(string path = @"..\..\..\JSON\events.json")
        {
            
            File.WriteAllText(path, JsonSerializer.Serialize(_events));
        }
    }
}
