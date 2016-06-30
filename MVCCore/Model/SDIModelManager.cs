using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model
{
    public class SDIModelManager : IModelManager
    {
        private IModel Model { set; get; }

        private Dictionary<string, IModelSerializer> Serializers { set; get; } = new Dictionary<string, IModelSerializer>();

        public SDIModelManager()
        {
            //add the default JSON serializer
            RegisterSerializer(new Serializers.JsonSerializer(), "json");
        }

        public IModel GetModel(string path)
        {
            return GetModel();
        }

        public IModel GetModel()
        {
            return Model;
        }

        public bool LoadModel(StreamReader stream, string serialierKey = "json")
        {
            //get the serializer
            IModelSerializer serializer;
            bool success = Serializers.TryGetValue(serialierKey, out serializer);
            if (!success)
                return false;

            //this will remove the old model
            Model = serializer.Deserialize(stream);
            if (null == Model)
                return false;

            return true;
        }

        public void RegisterSerializer(IModelSerializer serializer, string key)
        {
            //this ensures that there is a 1:1 ratio of values and keys
            Serializers[key] = serializer;
        }
    }
}
