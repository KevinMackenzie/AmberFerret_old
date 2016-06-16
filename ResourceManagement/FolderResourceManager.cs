using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagement
{
    public class FolderResourceManager : ResourceManagerBase
    {

        public override void LoadResourceCache(string location)
        {
            if(!Directory.Exists(location))
            {
                //do something extra here?
                throw new DirectoryNotFoundException();
            }
            //get a directory listing
            string[] files = Directory.GetFiles(location);
            foreach(var file in files)
            {
                Resource res = new Resource(file, FindAppropriateLoader(file)?.LoadResource(GetReader(file)));
                Resources.Add(res);
            }
        }

        protected override StreamReader GetReader(string path)
        {
            if(File.Exists(path))
            {
                //is this completely correct?
                return new StreamReader(new FileStream(path,FileMode.Open));
            }
            return null;
        }
    }
}
