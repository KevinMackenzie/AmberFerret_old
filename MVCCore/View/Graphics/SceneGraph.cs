using MVCCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.View.Graphics
{
    public class SceneGraph
    {
        public RootSceneGraphNode RootNode = new RootSceneGraphNode();

        public void Render(TimeSpan deltaTime)
        {
            RootNode.PreRender();
            RootNode.Render(deltaTime);
            RootNode.PostRender();
            RootNode.RenderChildren(deltaTime);
        }

        public void UpdateFromModel(GameModel model)
        {
            var rootNode = model.Graph.RootNode.GetSceneNode();
            if (!(rootNode is RootSceneGraphNode))
                return;//throw something?

            RootNode = rootNode as RootSceneGraphNode;
        }
    }
}
