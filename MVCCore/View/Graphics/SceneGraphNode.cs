using MVCCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pencil.Gaming.MathUtils;
using MVCCore.Model.Actor;

namespace MVCCore.View.Graphics
{
    public enum RenderPass
    {
        //TODO: make opaque and transparent as passes instead of just "actor"
        Sky = 0,
        Static = Sky + 1,
        Actor = Static + 1,
        NotRendered = Actor + 1,
        Last = NotRendered + 1
    }


    public abstract class SceneGraphNode
    {
        public List<SceneGraphNode> ChildNodes = new List<SceneGraphNode>();

        public readonly uint ActorId;
        public readonly string Name;
        public Matrix Transform { get; set; }
        public readonly RenderPass RenderPass;

        public SceneGraphNode(Actor actor, string name, RenderPass renderPass, Matrix transform)
        {
            ActorId = actor.Id;
            Name = name;
            Transform = transform;
            RenderPass = renderPass;
        }

        public void AddChild(SceneGraphNode child)
        {
            ChildNodes.Add(child);
        }
        public void RemoveChild(int actorId)
        {
            for (int i = 0; i < ChildNodes.Count; ++i)
            {
                if (ChildNodes[i].ActorId == actorId)
                    ChildNodes.RemoveAt(i);
            }
        }
        public void RenderChildren(TimeSpan deltaTime)
        {
            foreach (var node in ChildNodes)
            {
                node.PreRender();
                node.Render(deltaTime);
                node.PostRender();
                node.RenderChildren(deltaTime);
            }
        }

        public abstract bool IsVisible();
        public abstract void PostRender();
        public abstract void PreRender();
        public abstract void Render(TimeSpan deltaTime);
    }
}
