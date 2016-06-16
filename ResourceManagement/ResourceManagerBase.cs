using ResourceManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagement
{
    public abstract class ResourceManagerBase
    {
        public string CacheLocation { get; private set; }
        public List<IResourceLoader> ResourceLoaders { get; set; } = new List<IResourceLoader>();
        public List<Resource> Resources { get; protected set; } = new List<Resource>();

        protected IResourceLoader FindAppropriateLoader(string wholePath)
        {
            //the extension is defined as anything past the first period in the file name
            string justExt = "." + wholePath?.Split(new char[] { ',' })?.Last()?.Split(new char[] { '.' }, 2, StringSplitOptions.RemoveEmptyEntries)?.Last();

            foreach (var it in ResourceLoaders)
            {
                if (it.GetFileExt() == justExt)
                    return it;
            }
            return null;
        }

        public Resource GetResource(string path)
        {
            foreach(var res in Resources)
            {
                if (res.ResourcePath == path)
                    return res;
            }
            return null;
        }

        public abstract void LoadResourceCache(string location);
        //this should be overriden to retrieve a StreamReader
        protected abstract StreamReader GetReader(string path);
    }
}
