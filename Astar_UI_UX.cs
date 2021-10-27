using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astar_withUI
{
    public partial class Astar_UI_UX : Form
    {
        public Astar_UI_UX()
        {
            InitializeComponent();
        }


        private void Astar_UI_UX_Load(object sender, EventArgs e)
        {


            Grid2D grid2D = new Grid2D(5, 5, 2, 1, 4, 4);
            Utils utils = new Utils();


            //int XStartLocation = 0;
            //int YStartLocation = 4;
            //int XEndLocation = 4;
            //int YEndLocation = 4;


            //Node endNode = new Node();
            //Node startNode = new Node();

            utils.SetUpStartEndNodes(grid2D);

            //Trace.WriteLine(grid2D.StartNode.XLocation.ToString() + " " + grid2D.StartNode.YLocation.ToString());
            //Trace.WriteLine(grid2D.EndNode.XLocation.ToString() + " " + grid2D.EndNode.YLocation.ToString());

            //foreach (Node node in grid2D.GridNodes)
            //{
            //    if (node.YLocation == YEndLocation && node.XLocation == XEndLocation)
            //    {
            //        endNode = node;
            //        Trace.WriteLine(endNode.XLocation.ToString() + " " + endNode.YLocation.ToString());
            //        //MessageBox.Show("!!!!!!!!!!!");
            //    }
            //    if (node.YLocation == YStartLocation && node.XLocation == XStartLocation)
            //    {
            //        startNode = node;
            //    }
            //}

            utils.SetHeuristicValues(grid2D);

            //utils.FindPath(grid2D, startNode, endNode, XEndLocation, YEndLocation);

            List<Node> path = utils.FindPath(grid2D, grid2D.StartNode, grid2D.EndNode);
            String m = "";

            foreach (Node node in path)
            {
                //MessageBox.Show("!!!!!!!!!");
                m += (" [ " + node.XLocation.ToString() + " " + node.YLocation.ToString() + " ] \n");
            }

            MessageBox.Show(m);

        }
    }
}
