using ResourceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor.Graphics
{
    public class MeshRenderComponent : BaseRenderComponent
    {
        private Resource _meshResource;
        public Resource MeshResource { get { return _meshResource; } set { _meshResource = value; } }

        public override string GetName()
        {
            return "MeshRenderComponent";
        }

        public override bool Init(MVCApplication app)
        {
            app.ResourceManager.LoadResource(ref _meshResource);
            return true;
        }
    }
}
