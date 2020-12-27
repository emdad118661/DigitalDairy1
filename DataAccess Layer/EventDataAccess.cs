using DigitalDairy1.Etities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalDairy1.DataAccess_Layer
{
    class EventDataAccess
    {
        DataAccess dataAccess;
        public EventDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Event> GetAllEvents()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event @event = new Event();
                @event.EventNo  = (int)reader["EventNo"];
                @event.EventName = reader["EventName"].ToString();
                @event.Importance = reader["Importance"].ToString();
                @event.Date = reader["Date"].ToString();
                @event.Details = reader["Details"].ToString();
                
                events.Add(@event);
            }
            return events;
        }
        public Event GetProduct(int id)
        {
            string sql = "SELECT * FROM Products WHERE ProductId=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Event @event = new Event();
            @event.EventNo = (int)reader["EventNo"];
            @event.EventName = reader["EventName"].ToString();
            @event.Importance = reader["Importance"].ToString();
            @event.Date = reader["Date"].ToString();
            @event.Details = reader["Details"].ToString();
            
            return @event;
        }

        internal List<Event> GetEventsByEventName(object eventName)
        {
            throw new NotImplementedException();
        }

        public int AddNewEvent(Event @event)
        {
            string sql = "INSERT INTO Events(EventName,Importance,Date,Details) VALUES('" + @event.EventNo + "'," + @event.EventName + "," + @event.Importance + "," + @event.Date + "," + @event.Details + ")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int DeleteNewEvent(Event @event)
        {
            string sql = "DELETE INTO Events(EventName,Importance,Date,Details) VALUES('" + @event.EventNo + "'," + @event.EventName + "," + @event.Importance + "," + @event.Date + "," + @event.Details + ")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public List<Event> GetEventsByEventName(string eventName)
        {
            string sql = "SELECT * FROM Products WHERE EventName LIKE '" + eventName + "%'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                Event @event = new Event();
                @event.EventNo = (int)reader["EventNo"];
                @event.EventName = reader["EventName"].ToString();
                @event.Importance = reader["Importance"].ToString();
                @event.Date = reader["Date"].ToString();
                @event.Details = reader["Details"].ToString();
               
                events.Add(@event);
            }
            return events;
        }
    }
}
