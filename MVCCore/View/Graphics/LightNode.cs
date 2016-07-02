using Pencil.Gaming.MathUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.View.Graphics
{
    public struct LightProperties
    {
        Vector3 Attenuation;
        float Range;
        float Falloff;
        float Theta;
        float Phi;
    }

    public class LightNode : SceneGraphNode
    {
        public override void PostRender() { }

        public override void PreRender() { }

        public override void Render(TimeSpan deltaTime) { }
    }
}
