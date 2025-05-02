using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class MemberJSONRepo : IMemberRepo
    {
        protected List<Member> _members = new List<Member>();
        public MemberJSONRepo(string path)
        {
            path += "members.json";
            LoadFile(path);
        }

        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path)
        {
 
            string json = File.ReadAllText(path);

            _members = JsonSerializer.Deserialize<List<Member>>(json);
        }

        public void Add(Member member,string path)
        {
            _members.Add(member);
            SaveFile(path);
        }
        public List<Member> GetAll()
        {
            return _members;
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile(string path)
        {
            path += "members.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_members));
        }

        public Member GetByID(int id)
        {
            foreach (Member member in _members)
            {
                if (id == member.ID)
                {
                    return member;
                }
            }
            return null;
        }
    }
}
