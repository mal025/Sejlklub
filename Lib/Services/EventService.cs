using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;
using Lib.Repo;

namespace Lib.Services
{
    public class EventService
    {
        private IEventRepo _eventRepo;
        public EventService(IEventRepo eventRepo)
        {
            _eventRepo = eventRepo;
        }

        public List<Event> GetAll()
        {
            return _eventRepo.GetAll();
        }
        public void Add(Event theEvent, string path)
        {
            _eventRepo.Add(theEvent, path);
        }

        public Event GetByID(int id)
        {
            return _eventRepo.GetByID(id);
        }
    }
}
