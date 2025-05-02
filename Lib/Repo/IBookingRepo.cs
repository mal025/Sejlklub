﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public interface IBookingRepo
    {
        public List<Booking> GetAll();
        public void Add(Booking booking, string path);
        public void RemoveByID(int id, string path);
        public Booking GetByID(int id);


    }
}
