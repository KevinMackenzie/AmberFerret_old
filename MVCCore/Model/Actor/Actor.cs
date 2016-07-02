using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model.Actor
{
    public class Actor
    {
        public Dictionary<uint, IActorComponent> Components { get; private set; } = new Dictionary<uint, IActorComponent>();
        public uint Id { get; private set; }
        public string Resource { get; private set; }
    }
}
