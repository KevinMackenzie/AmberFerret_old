using MVCCore.View;
using Pencil.Gaming.MathUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor.Graphics
{
    public abstract class BaseRenderComponent : IActorComponent
    {
        public Vector3 Color { get; set; }
        public SceneGraphNode SceneNode { get; private set; }

        public abstract string GetName();
        public virtual void Update(MVCApplication app, TimeSpan deltaTime)
        { }
        public virtual bool Init(MVCApplication app)
        { return true; }

        //TODO: queue event
        public virtual void OnChanged(MVCApplication app)
        {
            throw new NotImplementedException();
        }

        //TODO: queue event
        public virtual void PostInit(MVCApplication app)
        {
            throw new NotImplementedException();
        }

    }
}
