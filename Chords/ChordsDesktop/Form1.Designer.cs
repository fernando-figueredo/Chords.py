﻿namespace ChordsDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.doAutoScroll = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.recalculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.retrainButton = new System.Windows.Forms.Button();
            this.bigChordLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.correctedChordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trainSeconds = new System.Windows.Forms.NumericUpDown();
            this.selectedChordPanel = new System.Windows.Forms.Panel();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.chartTable = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainSeconds)).BeginInit();
            this.selectedChordPanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            this.chartTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 579);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1495, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(11, 37);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 12, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(787, 382);
            this.mainPanel.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1533, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openFileToolStripMenu
            // 
            this.openFileToolStripMenu.Name = "openFileToolStripMenu";
            this.openFileToolStripMenu.Size = new System.Drawing.Size(137, 26);
            this.openFileToolStripMenu.Text = "Open...";
            this.openFileToolStripMenu.Click += new System.EventHandler(this.OpenFileClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 24);
            this.toolStripMenuItem2.Text = "Machine Learning";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 26);
            this.toolStripMenuItem3.Text = "Change Model...";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Location = new System.Drawing.Point(14, 551);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(175, 20);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "Audio file not loaded yet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please open an audio file";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.playButton);
            this.flowLayoutPanel2.Controls.Add(this.pauseButton);
            this.flowLayoutPanel2.Controls.Add(this.stopButton);
            this.flowLayoutPanel2.Controls.Add(this.doAutoScroll);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 430);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(529, 39);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(2, 2);
            this.playButton.Margin = new System.Windows.Forms.Padding(2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(132, 33);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(138, 2);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(132, 33);
            this.pauseButton.TabIndex = 0;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(274, 2);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(132, 33);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // doAutoScroll
            // 
            this.doAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doAutoScroll.AutoSize = true;
            this.doAutoScroll.Location = new System.Drawing.Point(417, 2);
            this.doAutoScroll.Margin = new System.Windows.Forms.Padding(9, 2, 2, 2);
            this.doAutoScroll.Name = "doAutoScroll";
            this.doAutoScroll.Size = new System.Drawing.Size(104, 33);
            this.doAutoScroll.TabIndex = 1;
            this.doAutoScroll.Text = "Auto Scroll";
            this.doAutoScroll.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.recalculateButton);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(14, 473);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(427, 39);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // recalculateButton
            // 
            this.recalculateButton.Location = new System.Drawing.Point(292, 2);
            this.recalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.recalculateButton.Name = "recalculateButton";
            this.recalculateButton.Size = new System.Drawing.Size(133, 32);
            this.recalculateButton.TabIndex = 0;
            this.recalculateButton.Text = "Recalculate";
            this.recalculateButton.UseVisualStyleBackColor = true;
            this.recalculateButton.Click += new System.EventHandler(this.RecalculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ms";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 5);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 27);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time Window Length:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.retrainButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bigChordLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.correctedChordTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.trainSeconds, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 14, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 431);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // retrainButton
            // 
            this.retrainButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.retrainButton.Location = new System.Drawing.Point(162, 390);
            this.retrainButton.Name = "retrainButton";
            this.retrainButton.Size = new System.Drawing.Size(89, 38);
            this.retrainButton.TabIndex = 10;
            this.retrainButton.Text = "Train";
            this.retrainButton.UseVisualStyleBackColor = true;
            this.retrainButton.Click += new System.EventHandler(this.RetrainButton_Click);
            // 
            // bigChordLabel
            // 
            this.bigChordLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.bigChordLabel, 3);
            this.bigChordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigChordLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigChordLabel.Location = new System.Drawing.Point(2, 43);
            this.bigChordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigChordLabel.Name = "bigChordLabel";
            this.bigChordLabel.Size = new System.Drawing.Size(250, 301);
            this.bigChordLabel.TabIndex = 1;
            this.bigChordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected Chord";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(163, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Correct";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CorrectChordButton_Click);
            // 
            // correctedChordTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.correctedChordTextBox, 2);
            this.correctedChordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctedChordTextBox.Location = new System.Drawing.Point(2, 351);
            this.correctedChordTextBox.Margin = new System.Windows.Forms.Padding(2, 7, 2, 2);
            this.correctedChordTextBox.Name = "correctedChordTextBox";
            this.correctedChordTextBox.Size = new System.Drawing.Size(148, 27);
            this.correctedChordTextBox.TabIndex = 3;
            this.correctedChordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seconds";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainSeconds
            // 
            this.trainSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainSeconds.Location = new System.Drawing.Point(79, 396);
            this.trainSeconds.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.trainSeconds.Name = "trainSeconds";
            this.trainSeconds.Size = new System.Drawing.Size(70, 27);
            this.trainSeconds.TabIndex = 13;
            // 
            // selectedChordPanel
            // 
            this.selectedChordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedChordPanel.Controls.Add(this.tableLayoutPanel1);
            this.selectedChordPanel.Location = new System.Drawing.Point(819, 37);
            this.selectedChordPanel.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.selectedChordPanel.Name = "selectedChordPanel";
            this.selectedChordPanel.Size = new System.Drawing.Size(254, 432);
            this.selectedChordPanel.TabIndex = 10;
            // 
            // chartPanel
            // 
            this.chartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPanel.Controls.Add(this.chartTable);
            this.chartPanel.Location = new System.Drawing.Point(1097, 37);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(413, 431);
            this.chartPanel.TabIndex = 11;
            // 
            // chartTable
            // 
            this.chartTable.ColumnCount = 14;
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.chartTable.Controls.Add(this.label9, 3, 2);
            this.chartTable.Controls.Add(this.label10, 4, 2);
            this.chartTable.Controls.Add(this.label11, 5, 2);
            this.chartTable.Controls.Add(this.label12, 6, 2);
            this.chartTable.Controls.Add(this.label13, 7, 2);
            this.chartTable.Controls.Add(this.label14, 8, 2);
            this.chartTable.Controls.Add(this.label15, 9, 2);
            this.chartTable.Controls.Add(this.label16, 10, 2);
            this.chartTable.Controls.Add(this.label17, 11, 2);
            this.chartTable.Controls.Add(this.label18, 12, 2);
            this.chartTable.Controls.Add(this.label6, 1, 2);
            this.chartTable.Controls.Add(this.label7, 2, 2);
            this.chartTable.Controls.Add(this.label19, 0, 1);
            this.chartTable.Controls.Add(this.label20, 0, 0);
            this.chartTable.Location = new System.Drawing.Point(0, 0);
            this.chartTable.Name = "chartTable";
            this.chartTable.RowCount = 3;
            this.chartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.chartTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.chartTable.Size = new System.Drawing.Size(411, 431);
            this.chartTable.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "D#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "E";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "F";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 40);
            this.label13.TabIndex = 5;
            this.label13.Text = "F#";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "G";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(263, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 40);
            this.label15.TabIndex = 7;
            this.label15.Text = "G#";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "A";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(319, 387);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 40);
            this.label17.TabIndex = 9;
            this.label17.Text = "A#";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(347, 387);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "C#";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 43);
            this.label19.Name = "label19";
            this.chartTable.SetRowSpan(this.label19, 2);
            this.label19.Size = new System.Drawing.Size(30, 388);
            this.label19.TabIndex = 13;
            this.label19.Text = " P    o   w    e   r";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.chartTable.SetColumnSpan(this.label20, 14);
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(405, 43);
            this.label20.TabIndex = 14;
            this.label20.Text = "Pitch Class Profile";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 632);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.selectedChordPanel);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Chords - Machine Learning detection of guitar chords";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainSeconds)).EndInit();
            this.selectedChordPanel.ResumeLayout(false);
            this.chartPanel.ResumeLayout(false);
            this.chartTable.ResumeLayout(false);
            this.chartTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenu;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox doAutoScroll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button recalculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bigChordLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox correctedChordTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button retrainButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown trainSeconds;
        private System.Windows.Forms.Panel selectedChordPanel;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.TableLayoutPanel chartTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel rt;
        private System.Windows.Forms.TableLayoutPanel t;
        private System.Windows.Forms.TableLayoutPanel tab;
    }
}

