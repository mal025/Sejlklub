using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class EventJSONRepository : EventCollectionRepo
    {
        public EventJSONRepository()
        {
            LoadFile();
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile()
        {
            string path = "events.json";
            string json = File.ReadAllText(path);

            _events = JsonSerializer.Deserialize<List<Event>>(json);
        }

        public override void Add(Event theEvent)
        {
            base.Add(theEvent);
        SaveFile();
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile()
        {
            string path = "events.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_events));
        }
    }
}
