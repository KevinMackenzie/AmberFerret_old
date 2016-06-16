using ResourceManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ResourceManagement
{
    public class JsonResourceLoader<ResourceName> : IResourceLoader
    {
        protected string Format;

        protected static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };


        public JsonResourceLoader(string format)
        {
            Format = format;
        }

        public IResourceExtraData LoadResource(StreamReader inputData)
        {
            ResourceName retData = JsonConvert.DeserializeObject<ResourceName>(inputData.ReadToEnd(), SerializerSettings);

            IResourceExtraData retRes = retData as IResourceExtraData;

            if (null == retRes)
            {
                //maybe do something here?
            }
            return retRes;
        }

        public string GetFileExt()
        {
            return Format;
        }
    }
}
