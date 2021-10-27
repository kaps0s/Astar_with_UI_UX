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
        public Grid2D(int rows, int columns,
            int XStartLocation, int YStartLocation, int XEndLocation, int YEndLocation){

            this.XStartLocation = XStartLocation;
            this.XEndLocation = XEndLocation;
            this.YStartLocation = YStartLocation;
            this.YEndLocation = YEndLocation;

            this.Rows = rows;
            this.Columns = columns;

            //Trace.WriteLine(XStartLocation);
            //Trace.WriteLine(XEndLocation);
            //Trace.WriteLine(YStartLocation);
            //Trace.WriteLine(YEndLocation);



            GridNodes = new Node [rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Node node = new Node
                    {
                        XLocation = i,
                        YLocation = j,
                        G = 0,
                        IsWalkable = true,
                        State = NodeState.Untested
                    };

                    if (node.XLocation == this.XStartLocation && node.YLocation == this.YStartLocation)
                    {
                        StartNode = node;
                    }

                    if (node.XLocation == this.XEndLocation && node.YLocation == this.YEndLocation)
                    {
                        EndNode = node;
                    }
                    GridNodes[i, j] = node;
                    //Trace.WriteLine("[" + i.ToString() + "]" + " [" + j.ToString() + "]");
                }
            }
        }
    }


}
