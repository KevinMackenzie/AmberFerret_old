using MVCCore.Interfaces;
using MVCCore.Model;
using MVCCore.View.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.View
{
    public class HierarchalView : IView
    {
        public SceneGraph Scene { get; private set; } = new SceneGraph();

        public void RenderFrame(TimeSpan deltaTime)
        {
            Scene.Render(deltaTime);
        }

        public void UpdateFromModel(IModel model)
        {
            if (!(model is GameModel))
                return;//throw something?

            GameModel gModel = model as GameModel;
            Scene.UpdateFromModel(gModel);
        }
    }
}
