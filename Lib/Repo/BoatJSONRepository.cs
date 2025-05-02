using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BoatJSONRepository : IBoatRepo
    {
        protected List<Boat> _boats = new List<Boat>();
        public BoatJSONRepository()
        {
            LoadFile();
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile()
        {
            string path = @"..\..\..\JSON\boats.json";
            string json = File.ReadAllText(path);
            
            _boats = JsonSerializer.Deserialize<List<Boat>>(json);
        }
        public void Add(Boat boat)
        {
            _boats.Add(boat);
            SaveFile();
        }
        public List<Boat> GetAll()
        {
            return _boats;
        }

        public Boat GetByID(int id)
        {
            foreach (Boat boat in _boats)
            {
                if (id == boat.ID)
                {
                    return boat;
                }
            }
            return null;
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile()
        {
            string path = @"..\..\..\JSON\boats.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_boats));
        }
    }
}
