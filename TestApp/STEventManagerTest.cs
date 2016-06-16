using EventManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagement;

namespace TestApp
{
    public class STEventManagerTest
    {
        public class TestEventData : IEventData
        {
            public static int Count = 0;
            public int Number = 0;
            public string EvtData = "Test Event Called: ";

            public TestEventData()
            {
                Number = Count++;
            }

            public override string ToString()
            {
                return EvtData + Number;
            }
        }
        public class TestEventHandler : IEventHandler
        {
            public string GetEventType()
            {
                return "TestApp.TestEvent";
            }

            public void ProcessEvent(Event evt)
            {
                var castEvt = evt.EventData as TestEventData;
                if(null == castEvt)
                {
                    Console.WriteLine("Failed to Cast Event Data");
                    return;
                }
                Console.WriteLine(castEvt.ToString());
            }
        }

    }
}
