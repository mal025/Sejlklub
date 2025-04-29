using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public class BoatCollectionRepo : IBoatRepo
    {
        List<Boat> _boats = new List<Boat>();

        public BoatCollectionRepo()
        {
        }
        public List<Boat> GetAll()
        {
            return _boats;
        }
    }
}
