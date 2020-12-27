using DigitalDairy1.DataAccess_Layer;
using DigitalDairy1.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDairy1.Business_Logic_Layer
{
    class EventServices
    {
        EventDataAccess eventDataAccess;

        public EventServices()
        {
            this.eventDataAccess = new EventDataAccess();
        }
        public List<Event> GetEventsList()
        {
            return this.eventDataAccess.GetAllEvents();
        }
        public int AddNewEvent(string eventName, string importance, string date, string details)
        {

            Event @event = new Event()
            {
                EventName = eventName,
                Importance = importance,
                Date = date,
                Details = details,

            };
            eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.AddNewEvent(@event);
        }
        public int DeleteNewEvent(string eventName, string importance, string date, string details)
        {

            Event @event = new Event()
            {
                EventName = eventName,
                Importance = importance,
                Date = date,
                Details = details,

            };
            eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.AddNewEvent(@event);
        }
        public List<Event> GetProductsListForSearch(string eventName)
        {
            return this.eventDataAccess.GetEventsByEventName(eventName);
        }
    }
}
