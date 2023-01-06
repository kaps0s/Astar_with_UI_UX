
namespace Astar_withUI
{
    partial class Astar_UI_UX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Astar_Start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GenerateMapButton = new System.Windows.Forms.Button();
            this.yAxisLabel = new System.Windows.Forms.Label();
            this.xxAxisLabel = new System.Windows.Forms.Label();
            this.xAxisComboBox = new System.Windows.Forms.ComboBox();
            this.yAxisComboBox = new System.Windows.Forms.ComboBox();
            this.MapContainerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EndPositionLabel = new System.Windows.Forms.Label();
            this.StartPositionLabel = new System.Windows.Forms.Label();
            this.EndPositionComboBox = new System.Windows.Forms.ComboBox();
            this.StartPostitionComboBox = new System.Windows.Forms.ComboBox();
            this.traversalCostLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.ColorToCostPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabelM = new System.Windows.Forms.Label();
            this.LPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabelL = new System.Windows.Forms.Label();
            this.HPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabelH = new System.Windows.Forms.Label();
            this.FPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabelF = new System.Windows.Forms.Label();
            this.MePictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabelMe = new System.Windows.Forms.Label();
            this.RPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabelR = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AlternativeMapButton = new System.Windows.Forms.Button();
            this.RoadLabel = new System.Windows.Forms.Label();
            this.MeadowLabel = new System.Windows.Forms.Label();
            this.ForestLabel = new System.Windows.Forms.Label();
            this.HillLabel = new System.Windows.Forms.Label();
            this.LakeLabel = new System.Windows.Forms.Label();
            this.MountainLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ColorToCostPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Astar_Start
            // 
            this.Astar_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Astar_Start.Location = new System.Drawing.Point(3, 276);
            this.Astar_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Astar_Start.Name = "Astar_Start";
            this.Astar_Start.Size = new System.Drawing.Size(295, 49);
            this.Astar_Start.TabIndex = 0;
            this.Astar_Start.Text = "A_star";
            this.Astar_Start.UseVisualStyleBackColor = true;
            this.Astar_Start.Click += new System.EventHandler(this.Astar_Start_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GenerateMapButton);
            this.panel1.Controls.Add(this.yAxisLabel);
            this.panel1.Controls.Add(this.xxAxisLabel);
            this.panel1.Controls.Add(this.xAxisComboBox);
            this.panel1.Controls.Add(this.yAxisComboBox);
            this.panel1.Location = new System.Drawing.Point(15, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 310);
            this.panel1.TabIndex = 1;
            // 
            // GenerateMapButton
            // 
            this.GenerateMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.GenerateMapButton.Location = new System.Drawing.Point(3, 249);
            this.GenerateMapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateMapButton.Name = "GenerateMapButton";
            this.GenerateMapButton.Size = new System.Drawing.Size(295, 59);
            this.GenerateMapButton.TabIndex = 4;
            this.GenerateMapButton.Text = "Generate Map";
            this.GenerateMapButton.UseVisualStyleBackColor = true;
            this.GenerateMapButton.Click += new System.EventHandler(this.GenerateMapButton_Click);
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.AutoSize = true;
            this.yAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yAxisLabel.Location = new System.Drawing.Point(96, 149);
            this.yAxisLabel.Name = "yAxisLabel";
            this.yAxisLabel.Size = new System.Drawing.Size(72, 25);
            this.yAxisLabel.TabIndex = 3;
            this.yAxisLabel.Text = "X axis";
            // 
            // xxAxisLabel
            // 
            this.xxAxisLabel.AutoSize = true;
            this.xxAxisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.xxAxisLabel.Location = new System.Drawing.Point(93, 46);
            this.xxAxisLabel.Name = "xxAxisLabel";
            this.xxAxisLabel.Size = new System.Drawing.Size(71, 25);
            this.xxAxisLabel.TabIndex = 2;
            this.xxAxisLabel.Text = "Y axis";
            // 
            // xAxisComboBox
            // 
            this.xAxisComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.xAxisComboBox.FormattingEnabled = true;
            this.xAxisComboBox.Location = new System.Drawing.Point(72, 188);
            this.xAxisComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xAxisComboBox.Name = "xAxisComboBox";
            this.xAxisComboBox.Size = new System.Drawing.Size(121, 33);
            this.xAxisComboBox.TabIndex = 1;
            this.xAxisComboBox.SelectedIndexChanged += new System.EventHandler(this.yAxisComboBox_SelectedIndexChanged);
            // 
            // yAxisComboBox
            // 
            this.yAxisComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yAxisComboBox.FormattingEnabled = true;
            this.yAxisComboBox.Location = new System.Drawing.Point(72, 89);
            this.yAxisComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yAxisComboBox.Name = "yAxisComboBox";
            this.yAxisComboBox.Size = new System.Drawing.Size(121, 33);
            this.yAxisComboBox.TabIndex = 0;
            this.yAxisComboBox.SelectedIndexChanged += new System.EventHandler(this.xAxisComboBox_SelectedIndexChanged);
            // 
            // MapContainerPanel
            // 
            this.MapContainerPanel.Location = new System.Drawing.Point(341, 178);
            this.MapContainerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapContainerPanel.Name = "MapContainerPanel";
            this.MapContainerPanel.Size = new System.Drawing.Size(1536, 739);
            this.MapContainerPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EndPositionLabel);
            this.panel2.Controls.Add(this.StartPositionLabel);
            this.panel2.Controls.Add(this.EndPositionComboBox);
            this.panel2.Controls.Add(this.StartPostitionComboBox);
            this.panel2.Controls.Add(this.Astar_Start);
            this.panel2.Location = new System.Drawing.Point(15, 592);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 327);
            this.panel2.TabIndex = 4;
            // 
            // EndPositionLabel
            // 
            this.EndPositionLabel.AutoSize = true;
            this.EndPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EndPositionLabel.Location = new System.Drawing.Point(64, 148);
            this.EndPositionLabel.Name = "EndPositionLabel";
            this.EndPositionLabel.Size = new System.Drawing.Size(127, 25);
            this.EndPositionLabel.TabIndex = 3;
            this.EndPositionLabel.Text = "EndPosition";
            // 
            // StartPositionLabel
            // 
            this.StartPositionLabel.AutoSize = true;
            this.StartPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StartPositionLabel.Location = new System.Drawing.Point(64, 31);
            this.StartPositionLabel.Name = "StartPositionLabel";
            this.StartPositionLabel.Size = new System.Drawing.Size(130, 25);
            this.StartPositionLabel.TabIndex = 2;
            this.StartPositionLabel.Text = "StartPositon";
            // 
            // EndPositionComboBox
            // 
            this.EndPositionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EndPositionComboBox.FormattingEnabled = true;
            this.EndPositionComboBox.Location = new System.Drawing.Point(69, 192);
            this.EndPositionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndPositionComboBox.Name = "EndPositionComboBox";
            this.EndPositionComboBox.Size = new System.Drawing.Size(121, 33);
            this.EndPositionComboBox.TabIndex = 1;
            this.EndPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.EndPositionComboBox_SelectedIndexChanged);
            // 
            // StartPostitionComboBox
            // 
            this.StartPostitionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StartPostitionComboBox.FormattingEnabled = true;
            this.StartPostitionComboBox.Location = new System.Drawing.Point(69, 78);
            this.StartPostitionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPostitionComboBox.Name = "StartPostitionComboBox";
            this.StartPostitionComboBox.Size = new System.Drawing.Size(121, 33);
            this.StartPostitionComboBox.TabIndex = 0;
            this.StartPostitionComboBox.SelectedIndexChanged += new System.EventHandler(this.StartPostitionComboBox_SelectedIndexChanged);
            // 
            // traversalCostLabel
            // 
            this.traversalCostLabel.AutoSize = true;
            this.traversalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traversalCostLabel.Location = new System.Drawing.Point(12, 43);
            this.traversalCostLabel.Name = "traversalCostLabel";
            this.traversalCostLabel.Size = new System.Drawing.Size(223, 31);
            this.traversalCostLabel.TabIndex = 5;
            this.traversalCostLabel.Text = "Traversal Cost :";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.okButton.Location = new System.Drawing.Point(322, 38);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(97, 37);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ColorToCostPanel
            // 
            this.ColorToCostPanel.Controls.Add(this.MountainLabel);
            this.ColorToCostPanel.Controls.Add(this.LakeLabel);
            this.ColorToCostPanel.Controls.Add(this.HillLabel);
            this.ColorToCostPanel.Controls.Add(this.ForestLabel);
            this.ColorToCostPanel.Controls.Add(this.MeadowLabel);
            this.ColorToCostPanel.Controls.Add(this.RoadLabel);
            this.ColorToCostPanel.Controls.Add(this.label1);
            this.ColorToCostPanel.Controls.Add(this.MPictureBox);
            this.ColorToCostPanel.Controls.Add(this.ColorLabelM);
            this.ColorToCostPanel.Controls.Add(this.LPictureBox);
            this.ColorToCostPanel.Controls.Add(this.ColorLabelL);
            this.ColorToCostPanel.Controls.Add(this.HPictureBox);
            this.ColorToCostPanel.Controls.Add(this.ColorLabelH);
            this.ColorToCostPanel.Controls.Add(this.FPictureBox);
            this.ColorToCostPanel.Controls.Add(this.ColorLabelF);
            this.ColorToCostPanel.Controls.Add(this.MePictureBox);
            this.ColorToCostPanel.Controls.Add(this.ColorLabelMe);
            this.ColorToCostPanel.Controls.Add(this.RPictureBox);
            this.ColorToCostPanel.Controls.Add(this.ColorLabelR);
            this.ColorToCostPanel.Location = new System.Drawing.Point(115, 13);
            this.ColorToCostPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ColorToCostPanel.Name = "ColorToCostPanel";
            this.ColorToCostPanel.Size = new System.Drawing.Size(1715, 151);
            this.ColorToCostPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Costs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MPictureBox
            // 
            this.MPictureBox.Location = new System.Drawing.Point(1459, 66);
            this.MPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MPictureBox.Name = "MPictureBox";
            this.MPictureBox.Size = new System.Drawing.Size(87, 62);
            this.MPictureBox.TabIndex = 11;
            this.MPictureBox.TabStop = false;
            // 
            // ColorLabelM
            // 
            this.ColorLabelM.AutoSize = true;
            this.ColorLabelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ColorLabelM.Location = new System.Drawing.Point(1571, 87);
            this.ColorLabelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabelM.Name = "ColorLabelM";
            this.ColorLabelM.Size = new System.Drawing.Size(70, 25);
            this.ColorLabelM.TabIndex = 10;
            this.ColorLabelM.Text = "label6";
            // 
            // LPictureBox
            // 
            this.LPictureBox.Location = new System.Drawing.Point(1181, 66);
            this.LPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LPictureBox.Name = "LPictureBox";
            this.LPictureBox.Size = new System.Drawing.Size(87, 62);
            this.LPictureBox.TabIndex = 9;
            this.LPictureBox.TabStop = false;
            // 
            // ColorLabelL
            // 
            this.ColorLabelL.AutoSize = true;
            this.ColorLabelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ColorLabelL.Location = new System.Drawing.Point(1293, 87);
            this.ColorLabelL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabelL.Name = "ColorLabelL";
            this.ColorLabelL.Size = new System.Drawing.Size(70, 25);
            this.ColorLabelL.TabIndex = 8;
            this.ColorLabelL.Text = "label5";
            // 
            // HPictureBox
            // 
            this.HPictureBox.Location = new System.Drawing.Point(943, 66);
            this.HPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.HPictureBox.Name = "HPictureBox";
            this.HPictureBox.Size = new System.Drawing.Size(87, 62);
            this.HPictureBox.TabIndex = 7;
            this.HPictureBox.TabStop = false;
            // 
            // ColorLabelH
            // 
            this.ColorLabelH.AutoSize = true;
            this.ColorLabelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ColorLabelH.Location = new System.Drawing.Point(1037, 87);
            this.ColorLabelH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabelH.Name = "ColorLabelH";
            this.ColorLabelH.Size = new System.Drawing.Size(70, 25);
            this.ColorLabelH.TabIndex = 6;
            this.ColorLabelH.Text = "label4";
            // 
            // FPictureBox
            // 
            this.FPictureBox.Location = new System.Drawing.Point(656, 66);
            this.FPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.FPictureBox.Name = "FPictureBox";
            this.FPictureBox.Size = new System.Drawing.Size(87, 62);
            this.FPictureBox.TabIndex = 5;
            this.FPictureBox.TabStop = false;
            // 
            // ColorLabelF
            // 
            this.ColorLabelF.AutoSize = true;
            this.ColorLabelF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ColorLabelF.Location = new System.Drawing.Point(768, 87);
            this.ColorLabelF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabelF.Name = "ColorLabelF";
            this.ColorLabelF.Size = new System.Drawing.Size(70, 25);
            this.ColorLabelF.TabIndex = 4;
            this.ColorLabelF.Text = "label3";
            // 
            // MePictureBox
            // 
            this.MePictureBox.Location = new System.Drawing.Point(373, 66);
            this.MePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MePictureBox.Name = "MePictureBox";
            this.MePictureBox.Size = new System.Drawing.Size(87, 62);
            this.MePictureBox.TabIndex = 3;
            this.MePictureBox.TabStop = false;
            // 
            // ColorLabelMe
            // 
            this.ColorLabelMe.AutoSize = true;
            this.ColorLabelMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ColorLabelMe.Location = new System.Drawing.Point(485, 87);
            this.ColorLabelMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabelMe.Name = "ColorLabelMe";
            this.ColorLabelMe.Size = new System.Drawing.Size(70, 25);
            this.ColorLabelMe.TabIndex = 2;
            this.ColorLabelMe.Text = "label2";
            // 
            // RPictureBox
            // 
            this.RPictureBox.Location = new System.Drawing.Point(117, 66);
            this.RPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.RPictureBox.Name = "RPictureBox";
            this.RPictureBox.Size = new System.Drawing.Size(87, 62);
            this.RPictureBox.TabIndex = 1;
            this.RPictureBox.TabStop = false;
            // 
            // ColorLabelR
            // 
            this.ColorLabelR.AutoSize = true;
            this.ColorLabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabelR.Location = new System.Drawing.Point(229, 87);
            this.ColorLabelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabelR.Name = "ColorLabelR";
            this.ColorLabelR.Size = new System.Drawing.Size(70, 25);
            this.ColorLabelR.TabIndex = 0;
            this.ColorLabelR.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.traversalCostLabel);
            this.panel3.Controls.Add(this.okButton);
            this.panel3.Location = new System.Drawing.Point(762, 919);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 94);
            this.panel3.TabIndex = 8;
            // 
            // AlternativeMapButton
            // 
            this.AlternativeMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AlternativeMapButton.Location = new System.Drawing.Point(18, 935);
            this.AlternativeMapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlternativeMapButton.Name = "AlternativeMapButton";
            this.AlternativeMapButton.Size = new System.Drawing.Size(293, 46);
            this.AlternativeMapButton.TabIndex = 9;
            this.AlternativeMapButton.Text = "EmpathyAstar";
            this.AlternativeMapButton.UseVisualStyleBackColor = true;
            this.AlternativeMapButton.Click += new System.EventHandler(this.AlternativeMapButton_Click);
            // 
            // RoadLabel
            // 
            this.RoadLabel.AutoSize = true;
            this.RoadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoadLabel.Location = new System.Drawing.Point(112, 126);
            this.RoadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoadLabel.Name = "RoadLabel";
            this.RoadLabel.Size = new System.Drawing.Size(70, 25);
            this.RoadLabel.TabIndex = 14;
            this.RoadLabel.Text = "label1";
            // 
            // MeadowLabel
            // 
            this.MeadowLabel.AutoSize = true;
            this.MeadowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeadowLabel.Location = new System.Drawing.Point(368, 126);
            this.MeadowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MeadowLabel.Name = "MeadowLabel";
            this.MeadowLabel.Size = new System.Drawing.Size(70, 25);
            this.MeadowLabel.TabIndex = 15;
            this.MeadowLabel.Text = "label1";
            // 
            // ForestLabel
            // 
            this.ForestLabel.AutoSize = true;
            this.ForestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForestLabel.Location = new System.Drawing.Point(651, 126);
            this.ForestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForestLabel.Name = "ForestLabel";
            this.ForestLabel.Size = new System.Drawing.Size(70, 25);
            this.ForestLabel.TabIndex = 16;
            this.ForestLabel.Text = "label1";
            // 
            // HillLabel
            // 
            this.HillLabel.AutoSize = true;
            this.HillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HillLabel.Location = new System.Drawing.Point(938, 126);
            this.HillLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HillLabel.Name = "HillLabel";
            this.HillLabel.Size = new System.Drawing.Size(70, 25);
            this.HillLabel.TabIndex = 17;
            this.HillLabel.Text = "label1";
            // 
            // LakeLabel
            // 
            this.LakeLabel.AutoSize = true;
            this.LakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LakeLabel.Location = new System.Drawing.Point(1176, 126);
            this.LakeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LakeLabel.Name = "LakeLabel";
            this.LakeLabel.Size = new System.Drawing.Size(70, 25);
            this.LakeLabel.TabIndex = 18;
            this.LakeLabel.Text = "label1";
            // 
            // MountainLabel
            // 
            this.MountainLabel.AutoSize = true;
            this.MountainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MountainLabel.Location = new System.Drawing.Point(1454, 126);
            this.MountainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MountainLabel.Name = "MountainLabel";
            this.MountainLabel.Size = new System.Drawing.Size(70, 25);
            this.MountainLabel.TabIndex = 19;
            this.MountainLabel.Text = "label1";
            // 
            // Astar_UI_UX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AlternativeMapButton);
            this.Controls.Add(this.ColorToCostPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MapContainerPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Astar_UI_UX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astar_UI_UX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Astar_UI_UX_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ColorToCostPanel.ResumeLayout(false);
            this.ColorToCostPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Astar_Start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GenerateMapButton;
        private System.Windows.Forms.Label yAxisLabel;
        private System.Windows.Forms.Label xxAxisLabel;
        private System.Windows.Forms.ComboBox xAxisComboBox;
        private System.Windows.Forms.ComboBox yAxisComboBox;
        public System.Windows.Forms.Panel MapContainerPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EndPositionLabel;
        private System.Windows.Forms.Label StartPositionLabel;
        private System.Windows.Forms.ComboBox EndPositionComboBox;
        private System.Windows.Forms.ComboBox StartPostitionComboBox;
        private System.Windows.Forms.Label traversalCostLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel ColorToCostPanel;
        private System.Windows.Forms.PictureBox MPictureBox;
        private System.Windows.Forms.Label ColorLabelM;
        private System.Windows.Forms.PictureBox LPictureBox;
        private System.Windows.Forms.Label ColorLabelL;
        private System.Windows.Forms.PictureBox HPictureBox;
        private System.Windows.Forms.Label ColorLabelH;
        private System.Windows.Forms.PictureBox FPictureBox;
        private System.Windows.Forms.Label ColorLabelF;
        private System.Windows.Forms.PictureBox MePictureBox;
        private System.Windows.Forms.Label ColorLabelMe;
        private System.Windows.Forms.PictureBox RPictureBox;
        private System.Windows.Forms.Label ColorLabelR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AlternativeMapButton;
        private System.Windows.Forms.Label MeadowLabel;
        private System.Windows.Forms.Label RoadLabel;
        private System.Windows.Forms.Label ForestLabel;
        private System.Windows.Forms.Label HillLabel;
        private System.Windows.Forms.Label LakeLabel;
        private System.Windows.Forms.Label MountainLabel;
    }
}

