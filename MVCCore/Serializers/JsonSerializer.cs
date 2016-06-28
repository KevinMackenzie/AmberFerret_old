using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MVCCore.Serializers
{
    public class JsonSerializer : IModelSerializer
    {
        protected static JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public IModel Deserialize(StreamReader inData)
        {
            object retData = JsonConvert.DeserializeObject(inData.ReadToEnd(), SerializerSettings);

            IModel retModel = retData as IModel;

            if (null == retModel)
            {
                //maybe do something here?  throw "DocLoadFailedException"?
            }
            return retModel;
        }

        public string Serialize(IModel model)
        {
            return JsonConvert.SerializeObject(model, SerializerSettings);
        }
    }
}
