using EventManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement
{
    public class Event
    {
        public enum EventPriority
        {
            NoExceptions,
            High,
            Medium,
            Low
        }
        public DateTime TriggerTime { get; private set; }
        public EventPriority Priority { get; private set; }
        public IEventData EventData { get; private set; }
        public string EventType { get; private set; }

        public Event(string evtType, IEventData evtData, EventPriority priority)
        {
            //trigger time is when the event is created
            TriggerTime = DateTime.UtcNow;

            Priority = priority;
            EventType = evtType;
            EventData = evtData;
        }
    }
}
