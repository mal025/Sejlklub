using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BoatJSONRepository : BoatCollectionRepo
    {
        public BoatJSONRepository()
        {
            LoadFile();
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile()
        {
            string path = "boats.json";
            string json = File.ReadAllText(path);
            
            _boats = JsonSerializer.Deserialize<List<Boat>>(json);
        }

        public override void Add(Boat boat)
        {
            base.Add(boat);
            //Debug.WriteLine("Successfully Added");
            SaveFile();
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile()
        {
            string path = "boats.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_boats));
        }
    }
}
