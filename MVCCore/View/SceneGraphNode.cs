using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.View
{
    public abstract class SceneGraphNode : ISceneGraphNode
    {
        public List<SceneGraphNode> ChildNodes = new List<SceneGraphNode>();

        public abstract void PostRender();
        public abstract void PreRender();
        public abstract void Render(TimeSpan deltaTime);

        public override void RenderChildren(TimeSpan deltaTime)
        {
            foreach(var node in ChildNodes)
            {
                node.PreRender();
                node.Render(deltaTime);
                node.PostRender();
            }
        }
    }
}
