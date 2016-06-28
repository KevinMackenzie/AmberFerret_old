using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagement;

namespace MVCCore.Controller
{
    public class GameController : IController
    {
        STEventManager EvtManager { get; set; } = new STEventManager();

        public void ProcessEventQueue(TimeSpan maxTime)
        {
            EvtManager.ProcessQueue(maxTime);
        }

        public void QueueEvent(Event evt)
        {
            EvtManager.QueueEvent(evt);
        }
    }
}
