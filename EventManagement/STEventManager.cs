using EventManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement
{
    public class STEventManager : IEventManager
    {
        protected Queue<Event> EventQueue { get; set; } = new Queue<Event>();
        protected Dictionary<string, IEventHandler> EventHandlers { get; set; } = new Dictionary<string, IEventHandler>();

        public void ProcessQueue(TimeSpan maxTime)
        {
            DateTime start = DateTime.UtcNow;

            //process some
            DateTime now = start;
            while((now - start < maxTime) && EventQueue.Count != 0)
            {
                //don't take the time every cycle to avoid spending a lot of time getting the time
                for(int i = 0; i < 5; ++i)
                {
                    if(EventQueue.Count != 0)
                    {
                        var evt = EventQueue.Dequeue();
                        IEventHandler handler = null;
                        if (EventHandlers.ContainsKey(evt.EventType))
                        {
                            handler = EventHandlers[evt.EventType];
                        }
                        if(null == handler)
                        {
                            //no handler; log?
                            continue;
                        }
                        handler.ProcessEvent(evt);
                    }
                    else
                    {
                        break;
                    }
                }
                now = DateTime.UtcNow;
            }
        }

        public void QueueEvent(Event evt)
        {
            EventQueue.Enqueue(evt);
        }

        public void RegisterEventHandler(IEventHandler evtHandler)
        {
            EventHandlers.Add(evtHandler.GetEventType(),evtHandler);
        }
    }
}
