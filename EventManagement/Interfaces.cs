using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement
{
    namespace Interfaces
    {
        public interface IEventHandler
        {
            string GetEventType();
            void ProcessEvent(Event evt);
        }

        public interface IEventManager
        {
            void QueueEvent(Event evt);
            void ProcessQueue(TimeSpan maxTime);
            void RegisterEventHandler(IEventHandler evtHandler);
        }

        public interface IEventData
        {
            
        }
    }
}
