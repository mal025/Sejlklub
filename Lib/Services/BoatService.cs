using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;
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

        public List<Boat> GetAll()
        {
            return _boatRepo.GetAll();
        }

        public void Add(Boat boat, string path)
        {
            _boatRepo.Add(boat, path);
        }


        public Boat GetByID(int id)
        {
            return _boatRepo.GetByID(id);
        }


    }
}
