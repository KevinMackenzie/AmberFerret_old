using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.View
{
    public class HierarchalView : IView
    {
        public SceneGraphNode SceneGraph = new SceneGraphNode();

        public void RenderFrame(TimeSpan deltaTime)
        {
            throw new NotImplementedException();
        }

        public void UpdateFromModel(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
