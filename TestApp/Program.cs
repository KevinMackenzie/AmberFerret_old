using EventManagement;
using Newtonsoft.Json;
using ResourceManagement;
using ResourceManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {
        public class TestStruct : IResourceExtraData
        {
            public string sString = "testing";
            public int iInt = 5;

            public int GetSize()
            {
                return sString.Length * 2 + 4;
            }

            public override bool Equals(object obj)
            {
                TestStruct rObj = obj as TestStruct;
                if (null == rObj)
                    return false;

                if (sString.Equals(rObj.sString) &&
                    iInt == rObj.iInt)
                    return true;
                return false;
            }
        }

        public static void TestFolderResourceManager()
        {
            Console.WriteLine("========Starting FolderResourceManager Test!========");

            FolderResourceManager resManager = new FolderResourceManager();

            JsonResourceLoader<TestStruct> testLoader = new JsonResourceLoader<TestStruct>(".test.json");
            resManager.ResourceLoaders.Add(testLoader);
            resManager.LoadResourceCache("ResourceFolder/");

            TestStruct str = new TestStruct();

            TestStruct testStr = resManager.GetResource("ResourceFolder/FooBar.test.json").ExtraData as TestStruct;

            if (str.Equals(testStr))
            {
                Console.WriteLine("Test Succeeded");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            Console.WriteLine("========FolderResourceManager Test Complete!========");
        }

        public static void SaveTestFolderResourceCache()
        {
            TestStruct struc = new TestStruct();

            Directory.CreateDirectory("ResourceFolder");
            string retData = JsonConvert.SerializeObject(struc, SerializerSettings);
            var writer = System.IO.File.CreateText("ResourceFolder/FooBar.test.json");
            writer.Write(retData);
            writer.Flush();
        }

        public static void TestSTEventManager()
        {
            Console.WriteLine("========Starting STEventManager Test!========");
            STEventManager evtManager = new STEventManager();
            evtManager.RegisterEventHandler(new STEventManagerTest.TestEventHandler());
            for(int i = 0;i < 50; ++i)
            {
                evtManager.QueueEvent(new Event("TestApp.TestEvent", new STEventManagerTest.TestEventData(), Event.EventPriority.High));
            }
            evtManager.ProcessQueue(TimeSpan.MaxValue);
            Console.WriteLine("========STEventManager Test Complete!========");
        }

        protected static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public static void Main(string[] args)
        {
            TestFolderResourceManager();
            TestSTEventManager();
            Console.Read();
        }
    }
}
