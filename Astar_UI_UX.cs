using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


            Grid2D grid2D = new Grid2D(5,5);
            Utils utils = new Utils();
            int XStartLocation = 0;
            int YStartLocation = 0;
            int XEndLocation = 5;
            int YEndLocation = 5;
            Node endNode = new Node();
            Node startNode = new Node();

            foreach (Node node in grid2D.GridNodes)
            {
                if (node.YLocation == YEndLocation && node.XLocation == XEndLocation)
                {
                    endNode = node;
                }
                if (node.YLocation == YStartLocation && node.XLocation == XStartLocation)
                {
                    startNode = node;
                }
            }

            utils.SetHeuristicValues(grid2D.GridNodes,XEndLocation,YEndLocation);

            //utils.FindPath(grid2D, startNode, endNode, XEndLocation, YEndLocation);

            List<Node> path = utils.FindPath(grid2D, startNode, endNode, XEndLocation, YEndLocation);
            String m = "";

            foreach (Node node in path)
            {
                m += (" [ " + node.XLocation.ToString() + " " + node.YLocation.ToString() + " ] \n");
            }

            MessageBox.Show(m);

        }
    }
}
