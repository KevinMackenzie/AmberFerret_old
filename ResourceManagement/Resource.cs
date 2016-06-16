using ResourceManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagement
{
    public class Resource
    {
        public IResourceExtraData ExtraData { get; private set; }
        public string ResourcePath { get; private set; }

        public Resource(string resourcePath, IResourceExtraData extraData)
        {
            ExtraData = extraData;
            ResourcePath = resourcePath;
        }
    }
}
