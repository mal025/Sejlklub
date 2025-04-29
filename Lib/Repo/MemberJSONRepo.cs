//using System.Collections.Generic;
//using System.Text.Json;
//using Lib.Model;

//namespace TinderForPets.Repo
//{
//    public class MemberJSONRepo : MemberCollectionRepo
//    {
//        public MemberJSONRepo()
//        {
//            LoadFile();
//        }

//        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
//        private void LoadFile()
//        {
//            string path = "member.json";
//            string json = File.ReadAllText(path);
            
//            _members = JsonSerializer.Deserialize<List<Member>>(json);
//        }

//        public override void Add(Member member)
//        {
//            base.Add(member);
//            SaveFile();
//        }

//        //denne metode skal kaldes når vi vil putte data i vores JSON
//        private void SaveFile()
//        {
//            string path = "members.json";
//            File.WriteAllText(path, JsonSerializer.Serialize(_members));
//        }
//    }
//}
