using CommunityIS.Service.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Core
{
    public class EventService : IEventService
    {
        protected CommunityContext _context;

        public EventService(CommunityContext context)
        {
            _context = context;
        }

        public void AddEvent(Event @event)
        {
            _context.Events.Add(@event);
            _context.SaveChanges();
        }

        public void DeleteEvent(int eventId)
        {
            var @event = _context.Events.Find(eventId);

            if (@event != null)
            {
                _context.Events.Remove(@event);
                _context.SaveChanges();
            }
        }

        public List<Event> GetAllEvents()
        {
            return _context.Events
                           .Include(e => e.Community)
                           .ToList();
        }



        public Event GetEventById(int eventId)
        {
            return _context.Events.Find(eventId);
        }

        public void UpdateEvent(Event @event)
        {
            _context.Events.Update(@event);
            _context.SaveChanges();
        }
    }

    interface IEventService
    {
        void AddEvent(Event @event);
        void UpdateEvent(Event @event);
        void DeleteEvent(int eventId);
        Event GetEventById(int eventId);
        List<Event> GetAllEvents();

    }
}
