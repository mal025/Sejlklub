using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public interface IEventRepo
    {
        public List<Event> GetAll();
        public void Add(Event theEvent, string path);
    }
}
