using Newtonsoft.Json;
using ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor.Graphics
{
    public class MaterialRenderComponent : BaseRenderComponent
    {
        private Resource _materialResource;
        public Resource MaterialResource { get { return _materialResource; } set { _materialResource = value; } }

        public override string GetName()
        {
            return "MaterialRenderComponent";
        }

        public override bool Init(MVCApplication app)
        {
            app.ResourceManager.LoadResource(ref _materialResource);
            return true;
        }
    }
}
