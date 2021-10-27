using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astar_withUI
{
    public class Utils
    {
        public void SetUpStartEndNodes(Grid2D grid2D)
        {
            foreach (Node node in grid2D.GridNodes)
            {
                if (node.YLocation == grid2D.YEndLocation && node.XLocation == grid2D.XEndLocation)
                {
                    grid2D.EndNode = node;
                    //Trace.WriteLine(grid2D.EndNode.XLocation.ToString() + " " + grid2D.EndNode.YLocation.ToString());
                }
                if (node.YLocation == grid2D.YStartLocation && node.XLocation == grid2D.XStartLocation)
                {
                    //Trace.WriteLine(startNode.XLocation.ToString() + " " + startNode.YLocation.ToString());
                    grid2D.StartNode = node;
                }
            }
        }


        //Sets all heuristic values to Node array
        public void SetHeuristicValues(Grid2D grid2D)
        {
            foreach (Node node in grid2D.GridNodes)
            {
                //Euclidean 
                //Trace.WriteLine(node);
                node.H = Math.Sqrt(Math.Pow(grid2D.XEndLocation - node.XLocation, 2) + Math.Pow(grid2D.YEndLocation - node.YLocation, 2));
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
                Trace.WriteLine(currentNode.YLocation.ToString() + " " + currentNode.XLocation.ToString());
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
                    //Trace.WriteLine(nextNode.XLocation.ToString() + " " + nextNode.YLocation.ToString());
                    return true;
                }
                else
                {
                    // Note: Recurses back into Search(Node)
                    if (Search(grid2D, nextNode, XEndLocation, YEndLocation))
                        //Trace.WriteLine(nextNode.XLocation.ToString() + " " + nextNode.YLocation.ToString());
                        return true;
                }
            }
            return false;
        }

        //Starts to find the path from one node to another
        public List<Node> FindPath(Grid2D grid2D, Node startNode, Node endNode)
        {

            List<Node> path = new List<Node>();
            bool success = Search(grid2D, startNode, grid2D.XEndLocation, grid2D.YEndLocation);
            if (success)
            {
                Node node = new Node();
                node = endNode;
                while (node.ParentNode != null)
                {
                    //Trace.WriteLine(node);
                    path.Add(node);
                    node = node.ParentNode;
                }
                path.Reverse();
            }
            return path;
        }
    }
}
