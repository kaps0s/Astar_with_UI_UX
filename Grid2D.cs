using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar_withUI
{
    public class Grid2D
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int XStartLocation { get; set; }
        public int YStartLocation { get; set; }
        public int XEndLocation { get; set; }
        public int YEndLocation { get; set; }
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public Node[,] GridNodes { get; set; }


        //Fills Gri2D.GridNodes array with Nodes initialized
        public Grid2D(int rows, int columns){


            this.Rows = rows;
            this.Columns = columns;


            GridNodes = new Node [rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Node node = new Node
                    {
                        XLocation = j,
                        YLocation = i,
                        IsWalkable = true,
                        State = NodeState.Untested
                    };

                    GridNodes[i, j] = node;
                }
            }
        }


        public void SetUpStartEndNodes()
        {
            foreach (Node node in GridNodes)
            {
                if (node.XLocation == XEndLocation && node.YLocation == YEndLocation)
                {
                    EndNode = node;
                }
                if (node.XLocation == XStartLocation && node.YLocation == YStartLocation)
                {
                    StartNode = node;
                }
            }
        }

        //Sets all heuristic values to Node array
        public void SetHeuristicValues()
        {
            foreach (Node node in GridNodes)
            {
                //Euclidean 
                node.H = Math.Sqrt(Math.Pow(YEndLocation - node.YLocation, 2) + Math.Pow(XEndLocation - node.XLocation, 2));
            }
        }
    }




}
