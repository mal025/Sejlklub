using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public class MemberCollectionRepo : IMemberRepo
    {
        protected List<Member> _members = new List<Member>();

        public virtual void Add(Member member)
        {
            _members.Add(member);
        }

        public MemberCollectionRepo() // Added mockup members to the member list from chatgpt
        {
            _members.Add(new Member(32, "Male", "Anders Jensen", 1, "+45 20451234", "anders.jensen@example.dk", "user","1234"));
            _members.Add(new Member(28, "Female", "Sofie Hansen", 2, "+45 22556677", "sofie.hansen@example.dk", "admin", "1234"));
            _members.Add(new Member(45, "Male", "Mikkel Sørensen", 3, "+45 26123456", "mikkel.sorensen@example.dk", "user", "1234"));
            _members.Add(new Member(22, "Female", "Emma Møller", 4, "+45 28997733", "emma.moeller@example.dk", "admin", "1234"));
            _members.Add(new Member(37, "Male", "Rasmus Nielsen", 5, "+45 21219876", "rasmus.nielsen@example.dk", "user", "1234"));
            _members.Add(new Member(30, "Female", "Line Kristensen", 6, "+45 30225544", "line.kristensen@example.dk", "user", "1234"));
            _members.Add(new Member(41, "Male", "Thomas Pedersen", 7, "+45 31445566", "thomas.pedersen@example.dk", "user", "1234"));
            _members.Add(new Member(26, "Female", "Freja Andersen", 8, "+45 22334455", "freja.andersen@example.dk", "user", "1234"));
            _members.Add(new Member(34, "Male", "Jonas Thomsen", 9, "+45 40667788", "jonas.thomsen@example.dk", "user", "1234"));
            _members.Add(new Member(29, "Female", "Ida Larsen", 10, "+45 29778866", "ida.larsen@example.dk", "user", "1234"));
            _members.Add(new Member(50, "Male", "Henrik Holm", 11, "+45 23992211", "henrik.holm@example.dk", "user", "1234"));
            _members.Add(new Member(36, "Female", "Camilla Knudsen", 12, "+45 20112233", "camilla.knudsen@example.dk", "user", "1234"));
            _members.Add(new Member(27, "Male", "Nikolaj Kristoffersen", 13, "+45 22446688", "nikolaj.k@example.dk", "user", "1234"));
            _members.Add(new Member(31, "Female", "Maja Iversen", 14, "+45 31889900", "maja.iversen@example.dk", "user", "1234"));
            _members.Add(new Member(38, "Male", "Kasper Bjerregaard", 15, "+45 26665544", "kasper.b@example.dk", "user", "1234"));

        }


        public List<Member> GetAll()
        {
            return _members;
        }
    }
}
