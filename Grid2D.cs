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

        public Node[,] GridNodes { get; set; }


        //Fills Gri2D.GridNodes array with Nodes initialized
        public Grid2D(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;

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
                    GridNodes[i, j] = node;
                    Trace.WriteLine("[" + i.ToString() + "]" + " [" + j.ToString() + "]");
                }
            }
        }
    }


}
