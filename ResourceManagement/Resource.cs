using Newtonsoft.Json;
using ResourceManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagement
{
    public class Resource
    {
        [JsonIgnore]
        public IResourceExtraData ExtraData { get; private set; }
        public string ResourcePath { get; private set; }

        public Resource(string resourcePath, IResourceExtraData extraData)
        {
            ExtraData = extraData;
            ResourcePath = resourcePath;
        }

        public bool IsExtraDataType<T>() where T : IResourceExtraData
        {
            //this could be more graceful (better null checks maybe?)
            try
            {
                return ExtraData.GetType() is T;
            }
            catch
            {
                return false;
            }
        }
    }
}
