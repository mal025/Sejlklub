﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    interface IBoatRepo
    {
        public List<Boat> GetAll();

    }
}
