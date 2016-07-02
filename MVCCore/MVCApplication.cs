using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCore.Interfaces;
using ResourceManagement;

namespace MVCCore
{
    public abstract class MVCApplication
    {
        public IModelManager ModelManager { get; set; }
        public ResourceManagerBase ResourceManager { get; set; }

        /// <summary>
        /// This should be used to Initialize: "ModelManager"; "ResourceManager"; "TODO: More"
        /// </summary>
        public abstract void InitMVCCore();

    }
}
