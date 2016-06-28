using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore.Model
{
    public class GameWorldGraphNode
    {
        public List<GameWorldGraphNode> ChildNodes { set; get; } = new List<GameWorldGraphNode>();
    }
}
