using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor
{
    public interface IActorComponent
    {
        bool Init(MVCApplication app);
        void PostInit(MVCApplication app);
        void Update(MVCApplication app, TimeSpan deltaTime);
        void OnChanged(MVCApplication app);
        string GetName();
    }
}
