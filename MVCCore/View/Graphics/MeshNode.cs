using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCore.Model.Actor;
using Pencil.Gaming.MathUtils;
using ResourceManagement;
using Newtonsoft.Json;

namespace MVCCore.View.Graphics
{
    public class MeshNode : RenderedSceneGraphNode
    {
        public Resource MeshData { get; private set; }

        public MeshNode(Actor actor, string name, RenderPass renderPass, Matrix transform, Resource shadingProgram, Resource material, Resource meshData) : base(actor, name, renderPass, transform, shadingProgram, material)
        {
            //TODO: make sure meshData is valid
        }

        public override bool IsVisible()
        {
            throw new NotImplementedException();
        }

        public override void PreRender()
        {
            base.PreRender();
        }

        public override void PostRender()
        {
            throw new NotImplementedException();
        }

        public override void Render(TimeSpan deltaTime)
        {
            throw new NotImplementedException();
        }
    }
}
