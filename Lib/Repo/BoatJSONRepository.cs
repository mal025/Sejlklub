using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BoatJSONRepository : IBoatRepo
    {
        protected List<Boat> _boats = new List<Boat>();
        public BoatJSONRepository(string path)
        {

            LoadFile(path);
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path)
        {

            string json = File.ReadAllText(path + "boats.json");
            
            _boats = JsonSerializer.Deserialize<List<Boat>>(json);
        }
        public void Add(Boat boat, string path)
        {
            _boats.Add(boat);
            SaveFile(path);
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
        private void SaveFile(string path)
        {

            File.WriteAllText(path + "boats.json", JsonSerializer.Serialize(_boats));
        }
    }
}
