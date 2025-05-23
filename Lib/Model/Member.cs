﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
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
        public string Password { get; set; }
        public List<Booking> Bookings { get; set; }

        public Member(int age, string gender, string name, int id, string phoneNumber, string email, string userType="user", string password="1234")
        {
            Age = age;
            Gender = gender;
            Name = name;
            ID = id;
            PhoneNumber = phoneNumber;
            Email = email;
            UserType = userType;
            Password = password;
        }
        public Member()
        {

        }

        public void AddBooking(Booking booking) // Adds the booking to the members list of bookings
        {
            Bookings.Add(booking);
        }

        public void RemoveBooking() // Remove a specific booking
        {
        }

    }
}
