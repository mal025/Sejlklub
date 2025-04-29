using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Lib.Repo;

namespace Lib.Services
{
    public class BoatService
    {
        private IBoatRepo _boatRepo;

        public BoatService(IBoatRepo boatRepo)
        {
            _boatRepo = boatRepo;
        }

    }
}
