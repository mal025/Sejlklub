using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Member
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public List<Booking> Booking { get; set; }

        public Member(int age, string gender, string name, int id, string phoneNumber, string email, string userType)
        {
            Age = age;
            Gender = gender;
            Name = name;
            ID = id;
            PhoneNumber = phoneNumber;
            Email = email;
            UserType = userType;
        }
    }
}
