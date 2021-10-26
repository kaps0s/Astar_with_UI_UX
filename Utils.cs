using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar_withUI
{
    public class Utils
    {

        //Sets all heuristic values to Node array
        public void SetHeuristicValues(Node[,] nodes, int endXLocation, int endYLocation)
        {
            foreach (Node node in nodes)
            {
                //Euclidean 
                node.H = Math.Sqrt(Math.Pow(endXLocation - node.XLocation, 2) + Math.Pow(endYLocation - node.YLocation, 2));
            }
        }

        //Returns all adjacemenet nodes of currentNode
        public List<Node> GetAdjacentNodes(Grid2D grid2D,Node currentNode)
        {
            List<Node> adjacentNodes = new List<Node>();

            if (currentNode.YLocation != 0)
            {
                //Adds top node
                adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation, currentNode.YLocation - 1]);

                if (currentNode.XLocation != 0)
                {
                    //Adds top-left node
                    adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation - 1, currentNode.YLocation - 1]);
                }

                if (currentNode.XLocation != grid2D.Columns - 1)
                {
                    //Add top-right node
                    adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation + 1, currentNode.YLocation - 1]);
                }
            }

            if (currentNode.YLocation != grid2D.Rows - 1)
            {
                //Adds bottom node
                adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation, currentNode.YLocation + 1]);

                if (currentNode.XLocation != 0)
                {
                    //Adds bottom left node
                    adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation - 1, currentNode.YLocation + 1]);
                }

                if (currentNode.XLocation != grid2D.Columns - 1)
                {
                    //Adds bottom right node
                    adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation + 1, currentNode.YLocation + 1]);
                }
            }
            if (currentNode.XLocation != 0)
            {
                //Adds left node
                adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation - 1, currentNode.YLocation]);
            }

            if (currentNode.XLocation != grid2D.Columns - 1)
            {
                //Adds right node
                adjacentNodes.Add(grid2D.GridNodes[currentNode.XLocation + 1, currentNode.YLocation]);
            }
            return adjacentNodes;
        }

        //Returns all potentially next nodes of currentNode
        public List<Node> GetAdjacentNextNodes(Grid2D grid2D,Node currentNode)
        {
            List<Node> walkableNodes = new List<Node>();
            List<Node> adjacentNodes = GetAdjacentNodes(grid2D,currentNode);

            foreach (Node neighborNode in adjacentNodes)
            {
                //Ignore non-walkable nodes
                if (!neighborNode.IsWalkable)
                    continue;

                //Ignore already-closed nodes
                if (neighborNode.State == NodeState.Closed)
                    continue;

                // Already-open nodes are only added to the list if their G-value is lower going via this route.
                if (neighborNode.State == NodeState.Open)
                {

                    //float traversalCost = Node.GetTraversalCost(node.Location, node.ParentNode.Location);
                    double gTemp = currentNode.G + neighborNode.G;
                    if (gTemp < neighborNode.G)
                    {
                        neighborNode.ParentNode = currentNode;
                        walkableNodes.Add(neighborNode);
                        neighborNode.G = gTemp;
                    }
                }
                else
                {
                    // If it's untested, set the parent and flag it as 'Open' for consideration
                    neighborNode.ParentNode = currentNode;
                    neighborNode.State = NodeState.Open;
                    walkableNodes.Add(neighborNode);
                    neighborNode.G = currentNode.G + 1;
                }


            }
            return walkableNodes;
        }

        //Searches for the closest path beetween start node and final node
        private bool Search(Grid2D grid2D, Node currentNode, int XEndLocation, int YEndLocation)
        {
            currentNode.State = NodeState.Closed;
            List<Node> nextNodes = GetAdjacentNextNodes(grid2D,currentNode);

            //Sorts all nodes of nextNodes compared to their F value
            nextNodes.Sort((node1, node2) => node1.F.CompareTo(node2.F));

            foreach (Node nextNode in nextNodes)
            {
                if (nextNode.XLocation == XEndLocation && nextNode.YLocation == YEndLocation)
                {
                    return true;
                }
                else
                {
                    // Note: Recurses back into Search(Node)
                    if (Search(grid2D,nextNode, XEndLocation, YEndLocation)) 
                        return true;
                }
            }
            return false;
        }

        //Starts to find the path from one node to another
        public List<Node> FindPath(Grid2D grid2D, Node startNode, Node endNode, int XEndLocation, int YEndLocation)
        {
            List<Node> path = new List<Node>();
            bool success = Search(grid2D, startNode, XEndLocation, YEndLocation);
            if (success)
            {
                Node node = endNode;
                while (node.ParentNode != null)
                {
                    path.Add(node);
                    node = node.ParentNode;
                }
                path.Reverse();
            }
            return path;
        }
    }
}
