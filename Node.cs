using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar_withUI
{
    public class Node
    {
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public bool IsWalkable { get; set; }
        public double G { get; set; }
        public double H { get; set; }
        public double F { get { return this.G + this.H; } }
        public int TraversalCost { get; set; }
        public NodeState State { get; set; }
        public Node ParentNode { get; set; }
    }

    public enum NodeState { Untested, Open, Closed }
}
