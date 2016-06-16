using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagement
{
    namespace Interfaces
    {
        public interface IResourceExtraData
        {
            int GetSize();
        }

        public interface IResourceLoader
        {
            string GetFileExt();
            IResourceExtraData LoadResource(StreamReader inputStream);
        }
    }
}
