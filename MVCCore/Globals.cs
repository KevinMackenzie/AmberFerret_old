using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore
{
    public static class Globals
    {
        public static IController Controller { get; private set; }
        public static IViewManager ViewManager { get; private set; }
        public static IModelManager ModelManager { get; private set; }
        public static bool Initialized { get; private set; } = false;

        public static void Initialize(IController controller, IViewManager viewManager, IModelManager modelManager)
        {
            Controller = controller;
            ViewManager = viewManager;
            ModelManager = modelManager;
            Initialized = true;
        }
    }
}
