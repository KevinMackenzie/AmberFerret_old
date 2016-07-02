using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCore.Interfaces;

namespace MVCCore.View
{
    public class MultiViewManager : IViewManager
    {
        /// <summary>
        /// This is a list of views in the order they should be rendered
        /// </summary>
        private List<IView> Views = new List<IView>();

        public int AddView(IView view)
        {
            Views.Add(view);
            return Views.Count;
        }

        public IView GetView(int viewIndex)
        {
            return Views[viewIndex];
        }

        public void Render(TimeSpan deltaTime, int viewIndex)
        {
            Views[viewIndex].RenderFrame(deltaTime);
        }

        public void RenderAll(TimeSpan deltaTime)
        {
            foreach(var view in Views)
            {
                view.RenderFrame(deltaTime);
            }
        }
    }
}
