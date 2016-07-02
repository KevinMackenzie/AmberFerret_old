using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCore.Model.Actor;
using Pencil.Gaming.MathUtils;
using ResourceManagement;

namespace MVCCore.View.Graphics
{
    public abstract class RenderedSceneGraphNode : SceneGraphNode
    {
        //it might be helpful to swap these without recreating the scene graph node
        public Resource ShadingProgram { get; private set; }
        public Resource Material { get; private set; }

        public RenderedSceneGraphNode(Actor actor, string name, RenderPass renderPass, Matrix transform, Resource shadingProgram, Resource material) : base(actor, name, renderPass, transform)
        {
            //TODO: make sure the resources contain valid stuff
        }

        public override void PreRender()
        {
            //TODO: apply shading program
            //var progExtraData = ShadingProgram.ExtraData as 
        }
    }
}
