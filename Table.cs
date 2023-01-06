using Astar_withUI.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using Image = System.Drawing.Image;
using Label = System.Windows.Forms.Label;
using Panel = System.Windows.Forms.Panel;

namespace Astar_withUI
{
    public class Table
    {

        public void SetUpTable(Grid2D grid2D, List<System.Windows.Forms.ComboBox> comboBoxList,
            List<System.Windows.Forms.Panel> panelList, List<System.Windows.Forms.Label> labelList, TableLayoutPanel tableLayoutPanel)
        {
            //tableLayoutPanel.SuspendLayout();
            //tableLayoutPanel.Size = new Size(1536, 739);
            tableLayoutPanel.Size = new Size(1200, 600);
            tableLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            SetUpNotationLabel(tableLayoutPanel, 0, 0, "[N/A]");

            //set up Yaxis and Xaxis position labels
            for (var i = 0; i < grid2D.Rows; i++)
            {
                SetUpNotationLabel(tableLayoutPanel, i + 1, 0, "[" + i.ToString() + "]");
            }

            for (var j = 0; j < grid2D.Columns; j++)
            {
                SetUpNotationLabel(tableLayoutPanel, 0, j + 1, "[" + j.ToString() + "]");
            }


            SetUpTableCells(panelList, comboBoxList, labelList, tableLayoutPanel, grid2D.Rows, grid2D.Columns);
            SetUpTableCellsSize(tableLayoutPanel, grid2D.Rows, grid2D.Columns);
            SetPanelSizeToCellSize(panelList);
            CenterComboboxToPanel(comboBoxList);
            //HorizontallyCenterLabelsToPanel(labelList);
            //tableLayoutPanel.ResumeLayout();
        }


        public void SetUpNotationLabel(TableLayoutPanel tableLayoutPanel, int i, int j, String labelText)
        {
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();

            label1.Text = labelText;
            label1.Font = new Font("Arial", 15, FontStyle.Bold);

            panel1.Controls.Add(label1);

            tableLayoutPanel.Controls.Add(panel1, j, i);
        }


        public void SetUpTableCells(List<Panel> panels, List<ComboBox> comboBoxes, List<Label> labels, TableLayoutPanel tableLayoutPanel, int rows, int columns)
        {
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    Panel panel = new Panel();
                    ComboBox comboBox = new ComboBox();
                    Label label = new Label();

                    panel.Name = "panel" + i.ToString() + j.ToString();
                    comboBox.Name = "comboBox" + i.ToString() + j.ToString();
                    label.Name = "label" + i.ToString() + j.ToString();
                    comboBox.Size = new Size(25, 25);

                    //panel.BackgroundImage = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\Resources\Road.jpg"));
                    //panel.BackgroundImageLayout = ImageLayout.Stretch;
                    panel.BackColor = Color.FromArgb(36, 0, 0, 0);

                    label.Font = new Font("Arial", 15, FontStyle.Bold);
                    label.Visible = false;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    panel.Controls.Add(label);

                    String[] textBoxValues = { "1", "2", "3", "4", "5", "6" };
                    comboBox.Items.AddRange(textBoxValues);
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox.SelectedIndex = 0;
                    panel.Controls.Add(comboBox);

                    tableLayoutPanel.Controls.Add(panel, j + 1, i + 1);
                    panel.Size = tableLayoutPanel.GetControlFromPosition(j + 1, i + 1).Size;

                    panels.Add(panel);
                    comboBoxes.Add(comboBox);
                    labels.Add(label);
                }
            }
        }

        public void SetUpTableCellsSize2(TableLayoutPanel tableLayoutPanel, int rows, int columns)
        {
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, (tableLayoutPanel.Height / (rows + 1)) / 2));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, (tableLayoutPanel.Width / (columns + 1)) / 2));


            for (var i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, (tableLayoutPanel.Height - ((tableLayoutPanel.Height / (columns + 1)) / 2) / (rows))));
            }

            for (var j = 0; j < columns; j++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, tableLayoutPanel.Width - ((tableLayoutPanel.Width / (columns + 1)) / 2) / (columns)));
            }
        }
        public void SetUpTableCellsSize(TableLayoutPanel tableLayoutPanel, int rows, int columns)
        {
            //tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, tableLayoutPanel.Height / (rows + 1)));
            for (var i = 0; i < rows + 1; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, tableLayoutPanel.Height / (rows + 1)));

            }

            for (var j = 0; j < columns + 1; j++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, tableLayoutPanel.Width / (columns + 1)));
            }
        }


        public void CenterComboboxToPanel(List<System.Windows.Forms.ComboBox> comboBoxes)
        {
            foreach (System.Windows.Forms.ComboBox comboBox in comboBoxes) {

                comboBox.Location = new Point(comboBox.Parent.Width - comboBox.Width, 0);
            }
        }


        //public void HorizontallyCenterLabelsToPanel(List<Label> labels)
        //{
        //    foreach (Label label in labels)
        //    {
        //        label.Location = new Point((label.Parent.Width - label.Width) / 2, 0);
        //    }
        //}


        public void SetPanelSizeToCellSize(List<System.Windows.Forms.Panel> panels)
        {
            foreach (System.Windows.Forms.Panel panel in panels)
            {
                panel.Size = panel.Parent.Size;
            }
        }




    }
}
