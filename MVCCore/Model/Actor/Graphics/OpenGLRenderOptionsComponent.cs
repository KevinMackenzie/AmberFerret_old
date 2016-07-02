using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor.Graphics
{
    public class OpenGLRenderOptionsComponent : IActorComponent
    {
        //TODO: Find the default rendering options
        static OpenGLRenderOptionsComponent DefaultRenderingOptions = new OpenGLRenderOptionsComponent { EnableStencil = true };

        //TODO: add all possible OpenGL Rendering Options
        public bool EnableStencil { get; set; }

        public void ApplyOptions()
        {
            //TODO: apply all possible OpenGL Rendering Options
        }

        public string GetName()
        {
            return "OpenGLRenderOptionsComponent";
        }
        public bool Init(MVCApplication app)
        {
            return true;
        }
        public void OnChanged(MVCApplication app)
        {  }
        public void PostInit(MVCApplication app)
        {  }
        public void Update(MVCApplication app, TimeSpan deltaTime)
        {  }
    }
}
