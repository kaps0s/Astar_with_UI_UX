using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astar_withUI
{
    public partial class Astar_UI_UX : Form
    {
        public Grid2D Grid2D { get; set; }
        public Table Table { get; set; }
        public Astar Astar { get; set; }
        List<Panel> PanelList { get; set; }
        List<ComboBox> ComboBoxList { get; set; }
        List<Label> LabelList { get; set; }
        Panel StartPanel { get; set; }
        Panel EndPanel { get; set; }
        TableLayoutPanel TableLayoutPanel { get; set; }
        public bool EmpathyMapBool { get; set; }

        readonly Dictionary<int, Color> Colors = new Dictionary<int, Color>() { 
            {1, Color.FromArgb(36, 0, 0, 0)},
            {2, Color.FromArgb(44, 0, 255, 0)},
            {3, Color.FromArgb(100, 0, 83, 0)},
            {4, Color.FromArgb(100, 146, 195, 0)},
            {5, Color.FromArgb(54, 0, 214, 255)},
            {6, Color.FromArgb(78, 141, 32, 0)},
            {7, Color.FromArgb(0, 0, 0, 0)},
            {8, Color.FromArgb(67, 242, 99, 8)},
            {9, Color.FromArgb(67, 255, 206, 27)}
        };
        public Astar_UI_UX(bool empathyMapBool)
        {
            InitializeComponent();
            EmpathyMapBool = empathyMapBool;
        }


        private void Astar_UI_UX_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            okButton.Visible = false;
            Astar_Start.Enabled = false;
            EmpathyMapBool = false;

            this.WindowState = FormWindowState.Maximized;
            MapContainerPanel.Size = new Size(1250, 650);

            String[] dimensions = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            yAxisComboBox.Items.AddRange(dimensions);
            yAxisComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            xAxisComboBox.Items.AddRange(dimensions);
            xAxisComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            yAxisComboBox.SelectedIndex = yAxisComboBox.Items.Count - 1;
            xAxisComboBox.SelectedIndex = xAxisComboBox.Items.Count - 1;

            StartPostitionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EndPositionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ColorLabelR.Text = "-> 1";
            ColorLabelMe.Text = "-> 2";
            ColorLabelF.Text = "-> 3";
            ColorLabelH.Text = "-> 4";
            ColorLabelL.Text = "-> 5";
            ColorLabelM.Text = "-> 6";

            RPictureBox.BackColor = Colors[1];
            MePictureBox.BackColor = Colors[2];
            FPictureBox.BackColor = Colors[3];
            HPictureBox.BackColor = Colors[4];
            LPictureBox.BackColor = Colors[5];
            MPictureBox.BackColor = Colors[6];

            RoadLabel.Text = "Road";
            MeadowLabel.Text = "Meadow";
            ForestLabel.Text = "Forest";
            HillLabel.Text = "Hill";
            LakeLabel.Text = "Lake";
            MountainLabel.Text = "Mountain";
        }

        private void GenerateMapButton_Click(object sender, EventArgs e)
        {
            MapContainerPanel.Controls.Clear();

            StartPostitionComboBox.Enabled = true;
            EndPositionComboBox.Enabled = true;
            Astar_Start.Enabled = true;

            
            SetUpTableAndAstar(Int32.Parse(yAxisComboBox.Text), Int32.Parse(xAxisComboBox.Text));


            SetUpPositionComboBoxes();
        }

        public void SetUpPositionComboBoxes()
        {
            StartPostitionComboBox.Items.Clear();
            EndPositionComboBox.Items.Clear();
            foreach (Node node in Grid2D.GridNodes)
            {
                EndPositionComboBox.Items.Add("[" + node.YLocation.ToString() + "] " + "[" + node.XLocation.ToString() + "]");
                StartPostitionComboBox.Items.Add("[" + node.YLocation.ToString() + "] " + "[" + node.XLocation.ToString() + "]");
            }

            PanelList[0].BackgroundImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\Start.png"));
            PanelList[0].BackgroundImageLayout = ImageLayout.Stretch;

            //PanelList[0].BackColor = Colors[7];

            PanelList[PanelList.Count - 1].BackgroundImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\End.png"));
            PanelList[PanelList.Count - 1].BackgroundImageLayout = ImageLayout.Stretch;
            //PanelList[PanelList.Count - 1].BackColor = Colors[8];

            StartPanel = PanelList[0];
            EndPanel = PanelList[PanelList.Count - 1];

            StartPostitionComboBox.SelectedIndex = 0;
            EndPositionComboBox.SelectedIndex = EndPositionComboBox.Items.Count - 1;

            Astar_Start.Enabled = true;
        }

        public void SetUpTableAndAstar(int yAxis, int xAxis)
        {
            CreateNewGrid2D(yAxis, xAxis);
            Table = new Table();
            Astar = new Astar();

            setUpTableAndLists();
            SetUpComboBoxesEvent();
            SetUpRandomMap();
        }

        public void CreateNewGrid2D(int yAxis, int xAxis)
        {
            Grid2D = new Grid2D(yAxis, xAxis);
        }

        public void setUpTableAndLists()
        {
            PanelList = new List<System.Windows.Forms.Panel>();
            ComboBoxList = new List<System.Windows.Forms.ComboBox>();
            LabelList = new List<System.Windows.Forms.Label>();
            StartPanel = new Panel();
            EndPanel = new Panel();
            TableLayoutPanel = new TableLayoutPanel();


            Table.SetUpTable(Grid2D, ComboBoxList, PanelList, LabelList, TableLayoutPanel);
            MapContainerPanel.Controls.Add(TableLayoutPanel);
        }


        public void SetUpComboBoxesEvent()
        {
            //change colors and g values
            foreach (ComboBox comboBox in ComboBoxList)
            {
                comboBox.SelectedIndexChanged += new System.EventHandler((object o, EventArgs ev) =>
                {
                    ComboBox cb = (ComboBox)o;
                    if (cb.Text == "1")
                    {
                        cb.Parent.BackColor = Colors[1];
                    }
                    else if (cb.Text == "2")
                    {
                        cb.Parent.BackColor = Colors[2];
                    }
                    else if (cb.Text == "3")
                    {
                        cb.Parent.BackColor = Colors[3];
                    }
                    else if (cb.Text == "4")
                    {
                        cb.Parent.BackColor = Colors[4];
                    }
                    else if (cb.Text == "5")
                    {
                        cb.Parent.BackColor = Colors[5];
                    }
                    else if (cb.Text == "6")
                    {
                        cb.Parent.BackColor = Colors[6];
                    }
                });
            }
        }


        public void SetUpRandomMap()
        {
            Random random = new Random();
            foreach (ComboBox combobox in ComboBoxList)
            {
                combobox.SelectedIndex = random.Next(6);
            }
        }


        private void Astar_Start_Click(object sender, EventArgs e)
        {
            CreateNewGrid2D(Int32.Parse(yAxisComboBox.Text), Int32.Parse(xAxisComboBox.Text));

            Grid2D.YStartLocation = Int32.Parse(StartPostitionComboBox.Text.Substring(1, 1));
            Grid2D.XStartLocation = Int32.Parse(StartPostitionComboBox.Text.Substring(5, 1));
            Grid2D.YEndLocation = Int32.Parse(EndPositionComboBox.Text.Substring(1, 1));
            Grid2D.XEndLocation = Int32.Parse(EndPositionComboBox.Text.Substring(5, 1));

            Grid2D.SetUpStartEndNodes();
            Grid2D.SetHeuristicValues();


            //Set up costs
            SetNodesGValue();

            //Empathy map values
            if (EmpathyMapBool)
            {
                SetNodesGEmpathyValues();
            }

            ShowAstarPath();
        }


        public void SetNodesGValue()
        {
            foreach (Node node in Grid2D.GridNodes)
            {
                switch (ComboBoxList[(node.YLocation * Grid2D.Columns) + node.XLocation].Text)
                {
                    case "1":
                        node.G = 1;
                        break;
                    case "2":
                        node.G = 2;
                        break;
                    case "3":
                        node.G = 3;
                        break;
                    case "4":
                        node.G = 4;
                        break;
                    case "5":
                        node.G = 5;
                        break;
                    case "6":
                        node.G = 6;
                        break;
                }
            }
        }

        public void SetNodesGEmpathyValues()
        {
            foreach (Node node in Grid2D.GridNodes)
            {
                if (ComboBoxList[(node.YLocation * Grid2D.Columns) + node.XLocation].Text == "6")
                {
                    node.G += 4;

                    //top-left
                    try
                    {
                        Grid2D.GridNodes[node.YLocation - 1, node.XLocation - 1].G += 3;
                    }
                    catch { }

                    //top
                    try
                    {
                        Grid2D.GridNodes[node.YLocation - 1, node.XLocation].G += 3;
                    }
                    catch { }

                    //top-right
                    try
                    {
                        Grid2D.GridNodes[node.YLocation - 1, node.XLocation + 1].G += 3;
                    }
                    catch { }

                    //left
                    try
                    {
                        Grid2D.GridNodes[node.YLocation, node.XLocation - 1].G += 3;
                    }
                    catch { }

                    //right
                    try
                    {
                        Grid2D.GridNodes[node.YLocation, node.XLocation + 1].G += 3;
                    }
                    catch { }

                    //left-bottom
                    try
                    {
                        Grid2D.GridNodes[node.YLocation + 1, node.XLocation - 1].G += 3;
                    }
                    catch { }

                    //bottom
                    try
                    {
                        Grid2D.GridNodes[node.YLocation + 1, node.XLocation].G += 3;
                    }
                    catch { }

                    //right-bottom
                    try
                    {
                        Grid2D.GridNodes[node.YLocation + 1, node.XLocation + 1].G += 3;
                    }
                    catch { }
                }


                //Lake - values
                if (ComboBoxList[(node.YLocation * Grid2D.Columns) + node.XLocation].Text == "5")
                {
                    node.G -= 3;
                    double x;
                    //top-left
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation - 1, node.XLocation - 1].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }


                    //top
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation - 1, node.XLocation].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }

                    //top-right
                    try
                    {

                        x = Grid2D.GridNodes[node.YLocation - 1, node.XLocation + 1].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }

                    //left
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation, node.XLocation - 1].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }

                    //right
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation, node.XLocation + 1].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }

                    //left-bottom
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation + 1, node.XLocation - 1].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }

                    //bottom
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation + 1, node.XLocation].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }

                    //right-bottom
                    try
                    {
                        x = Grid2D.GridNodes[node.YLocation + 1, node.XLocation + 1].G;
                        if (x >= 2)
                        {
                            x -= 2;
                        }
                    }
                    catch { }
                }
            }
        }


        public void ShowAstarPath()
        {
            List<Node> path = Astar.FindPath(Grid2D, Grid2D.StartNode, Grid2D.EndNode);
            //String m = "";

            foreach (Node node in path)
            {
                //m += (" [ " + node.YLocation.ToString() + " " + node.XLocation.ToString() + " ] \n");
                PanelList[(node.YLocation * Grid2D.Columns) + node.XLocation].BackColor = Colors[9];
            }
            traversalCostLabel.Text = "Traversal Cost : " + path[path.Count - 1].G.ToString();


            EndPanel.BackColor = Colors[9];
            StartPanel.BackColor = Colors[9];

            StartPanel.BackgroundImage = null;
            EndPanel.BackgroundImage = null;

            Astar_Start.Enabled = false;
            AlternativeMapButton.Enabled = false;
            StartPostitionComboBox.Enabled = false;
            EndPositionComboBox.Enabled = false;
            okButton.Visible = true;


            //SetUpLabels();
            ShowPathLabels(path);
            HideComboxes();
        }
        public void ShowPathLabels(List<Node> path)
        {
            foreach (Node node in path)
            {
                LabelList[(node.YLocation * Grid2D.Columns) + node.XLocation].Text = node.G.ToString();
                LabelList[(node.YLocation * Grid2D.Columns) + node.XLocation].Visible = true;
            }

            LabelList[(Grid2D.StartNode.YLocation * Grid2D.Columns) + Grid2D.StartNode.XLocation].Text = Grid2D.StartNode.G.ToString();
            LabelList[(Grid2D.StartNode.YLocation * Grid2D.Columns) + Grid2D.StartNode.XLocation].Visible = true;
        }
        
        public void HideComboxes()
        {
            foreach (ComboBox comboBox in ComboBoxList)
            {
                comboBox.Visible = false;
            }
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in PanelList)
            {
                int z;
                int x = (panel.Controls[1] as ComboBox).SelectedIndex;
                if (x == 5)
                {
                    z = 4;
                }
                else
                {
                    z = x + 1;
                }
                (panel.Controls[1] as ComboBox).SelectedIndex = z;
                (panel.Controls[1] as ComboBox).SelectedIndex = x;

            }

            int y = StartPostitionComboBox.SelectedIndex;
            StartPostitionComboBox.SelectedIndex = 1;
            StartPostitionComboBox.SelectedIndex = y;

            int w = EndPositionComboBox.SelectedIndex;
            EndPositionComboBox.SelectedIndex = 1;
            EndPositionComboBox.SelectedIndex = w;


            Astar_Start.Enabled = true;
            StartPostitionComboBox.Enabled = true;
            EndPositionComboBox.Enabled = true;
            AlternativeMapButton.Enabled = true;

            traversalCostLabel.Text = "";

            okButton.Visible = false;

            HideLabelsShowComboBoxes();
            EmpathyMapBool = false;

            //StartPanel.BackgroundImage = null;
            //EndPanel.BackgroundImage = null;
        }

        //public void SetUpLabels()
        //{
        //    foreach (Node node in Grid2D.GridNodes)
        //    {
        //        ComboBoxList[(node.YLocation * Grid2D.Rows) + node.XLocation].Visible = false;
        //        LabelList[(node.YLocation * Grid2D.Rows) + node.XLocation].Text = node.G.ToString();
        //        LabelList[(node.YLocation * Grid2D.Rows) + node.XLocation].Visible = true;
        //    }
        //}

        public void HideLabelsShowComboBoxes()
        {
            foreach (ComboBox comboBox in ComboBoxList)
            {
                comboBox.Visible = true;
            }

            foreach (Label label in LabelList)
            {
                label.Visible = false;
            }
        }

        private void StartPostitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPanel.BackgroundImage = null;

            int z;
            int x = (StartPanel.Controls[1] as ComboBox).SelectedIndex;
            if (x == 5)
            {
                z = 4;
            }
            else
            {
                z = x + 1;
            }
            (StartPanel.Controls[1] as ComboBox).SelectedIndex = z;
            (StartPanel.Controls[1] as ComboBox).SelectedIndex = x;
            //int x (sender as ComboBox).SelectedIndex;

            StartPanel = PanelList[(sender as ComboBox).SelectedIndex];


            StartPanel.BackgroundImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\Start.png"));
            StartPanel.BackgroundImageLayout = ImageLayout.Stretch;

            //StartPanel.BackColor = Colors[7];
        }

        private void EndPositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndPanel.BackgroundImage = null;

            int z;
            int x = (EndPanel.Controls[1] as ComboBox).SelectedIndex;
            if (x == 5)
            {
                z = 4;
            }
            else
            {
                z = x + 1;
            }
            (EndPanel.Controls[1] as ComboBox).SelectedIndex = z;
            (EndPanel.Controls[1] as ComboBox).SelectedIndex = x;

            EndPanel = PanelList[(sender as ComboBox).SelectedIndex];

            EndPanel.BackgroundImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\End.png"));
            EndPanel.BackgroundImageLayout = ImageLayout.Stretch;

            //EndPanel.BackColor = Colors[8];
        }

        private void xAxisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPostitionComboBox.Enabled = false;
            EndPositionComboBox.Enabled = false;
            Astar_Start.Enabled = false;
        }

        private void yAxisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartPostitionComboBox.Enabled = false;
            EndPositionComboBox.Enabled = false;
            Astar_Start.Enabled = false;
        }

        private void AlternativeMapButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Lake cells cost (-3) more and all adjacment cells cost (-2) more\nNow Mountain cells cost (+4) more and all adjacment cells cost (+3) more");
            EmpathyMapBool = true;
            Astar_Start.PerformClick();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
