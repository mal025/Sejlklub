using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public class EventCollectionRepo: IEventRepo
    {
        protected List<Event> _events = new List<Event>();
        public virtual void Add(Event theEvent)
        {
            _events.Add(theEvent);
        }
    }
}
