﻿using TA.WinFormsControls;

namespace TA.WinForms.Controls.TestApplication
    {
    partial class Form1
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
            this.annunciatorPanel1 = new TA.WinFormsControls.AnnunciatorPanel();
            this.annunciator1 = new TA.WinFormsControls.Annunciator();
            this.annunciator2 = new TA.WinFormsControls.Annunciator();
            this.annunciator3 = new TA.WinFormsControls.Annunciator();
            this.annunciator4 = new TA.WinFormsControls.Annunciator();
            this.annunciator5 = new TA.WinFormsControls.Annunciator();
            this.annunciator6 = new TA.WinFormsControls.Annunciator();
            this.annunciator7 = new TA.WinFormsControls.Annunciator();
            this.NonstandardAnnunciator = new TA.WinFormsControls.Annunciator();
            this.Sequence1 = new TA.WinFormsControls.Annunciator();
            this.ledIndicator1 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator2 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator4 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator5 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator6 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator7 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator3 = new TA.WinFormsControls.LedIndicator();
            this.annunciator8 = new TA.WinFormsControls.Annunciator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.annunciator14 = new TA.WinFormsControls.Annunciator();
            this.annunciator13 = new TA.WinFormsControls.Annunciator();
            this.annunciator12 = new TA.WinFormsControls.Annunciator();
            this.annunciator10 = new TA.WinFormsControls.Annunciator();
            this.annunciator11 = new TA.WinFormsControls.Annunciator();
            this.annunciator9 = new TA.WinFormsControls.Annunciator();
            this.Sequence2 = new TA.WinFormsControls.Annunciator();
            this.Sequence3 = new TA.WinFormsControls.Annunciator();
            this.Sequence4 = new TA.WinFormsControls.Annunciator();
            this.Sequence5 = new TA.WinFormsControls.Annunciator();
            this.Sequence6 = new TA.WinFormsControls.Annunciator();
            this.Sequence7 = new TA.WinFormsControls.Annunciator();
            this.Sequence8 = new TA.WinFormsControls.Annunciator();
            this.annunciatorPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // annunciatorPanel1
            //
            this.annunciatorPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciatorPanel1.Controls.Add(this.annunciator1);
            this.annunciatorPanel1.Controls.Add(this.annunciator2);
            this.annunciatorPanel1.Controls.Add(this.annunciator3);
            this.annunciatorPanel1.Controls.Add(this.annunciator4);
            this.annunciatorPanel1.Controls.Add(this.annunciator5);
            this.annunciatorPanel1.Controls.Add(this.annunciator6);
            this.annunciatorPanel1.Controls.Add(this.annunciator7);
            this.annunciatorPanel1.Controls.Add(this.NonstandardAnnunciator);
            this.annunciatorPanel1.Controls.Add(this.Sequence1);
            this.annunciatorPanel1.Controls.Add(this.Sequence2);
            this.annunciatorPanel1.Controls.Add(this.Sequence3);
            this.annunciatorPanel1.Controls.Add(this.Sequence4);
            this.annunciatorPanel1.Controls.Add(this.Sequence5);
            this.annunciatorPanel1.Controls.Add(this.Sequence6);
            this.annunciatorPanel1.Controls.Add(this.Sequence7);
            this.annunciatorPanel1.Controls.Add(this.Sequence8);
            this.annunciatorPanel1.Location = new System.Drawing.Point(13, 13);
            this.annunciatorPanel1.Name = "annunciatorPanel1";
            this.annunciatorPanel1.Size = new System.Drawing.Size(775, 100);
            this.annunciatorPanel1.TabIndex = 0;
            //
            // annunciator1
            //
            this.annunciator1.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator1.AutoSize = true;
            this.annunciator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator1.Cadence = TA.WinFormsControls.CadencePattern.SteadyOff;
            this.annunciator1.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator1.Location = new System.Drawing.Point(3, 0);
            this.annunciator1.Name = "annunciator1";
            this.annunciator1.Size = new System.Drawing.Size(150, 32);
            this.annunciator1.TabIndex = 0;
            this.annunciator1.Text = "SteadyOff";
            //
            // annunciator2
            //
            this.annunciator2.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator2.AutoSize = true;
            this.annunciator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator2.Cadence = TA.WinFormsControls.CadencePattern.Strobe;
            this.annunciator2.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator2.Location = new System.Drawing.Point(159, 0);
            this.annunciator2.Name = "annunciator2";
            this.annunciator2.Size = new System.Drawing.Size(105, 32);
            this.annunciator2.TabIndex = 1;
            this.annunciator2.Text = "Strobe";
            //
            // annunciator3
            //
            this.annunciator3.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator3.AutoSize = true;
            this.annunciator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator3.Cadence = TA.WinFormsControls.CadencePattern.BlinkAlarm;
            this.annunciator3.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator3.Location = new System.Drawing.Point(270, 0);
            this.annunciator3.Name = "annunciator3";
            this.annunciator3.Size = new System.Drawing.Size(165, 32);
            this.annunciator3.TabIndex = 2;
            this.annunciator3.Text = "BlinkAlarm";
            //
            // annunciator4
            //
            this.annunciator4.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator4.AutoSize = true;
            this.annunciator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator4.Cadence = TA.WinFormsControls.CadencePattern.BlinkFast;
            this.annunciator4.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator4.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator4.Location = new System.Drawing.Point(441, 0);
            this.annunciator4.Name = "annunciator4";
            this.annunciator4.Size = new System.Drawing.Size(150, 32);
            this.annunciator4.TabIndex = 3;
            this.annunciator4.Text = "BlinkFast";
            //
            // annunciator5
            //
            this.annunciator5.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator5.AutoSize = true;
            this.annunciator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator5.Cadence = TA.WinFormsControls.CadencePattern.BlinkSlow;
            this.annunciator5.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator5.ForeColor = System.Drawing.Color.Crimson;
            this.annunciator5.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator5.Location = new System.Drawing.Point(597, 0);
            this.annunciator5.Name = "annunciator5";
            this.annunciator5.Size = new System.Drawing.Size(150, 32);
            this.annunciator5.TabIndex = 7;
            this.annunciator5.Text = "BlinkSlow";
            //
            // annunciator6
            //
            this.annunciator6.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator6.AutoSize = true;
            this.annunciator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator6.Cadence = TA.WinFormsControls.CadencePattern.Wink;
            this.annunciator6.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator6.ForeColor = System.Drawing.Color.Crimson;
            this.annunciator6.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator6.Location = new System.Drawing.Point(3, 32);
            this.annunciator6.Name = "annunciator6";
            this.annunciator6.Size = new System.Drawing.Size(75, 32);
            this.annunciator6.TabIndex = 5;
            this.annunciator6.Text = "Wink";
            //
            // annunciator7
            //
            this.annunciator7.ActiveColor = System.Drawing.Color.Crimson;
            this.annunciator7.AutoSize = true;
            this.annunciator7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator7.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator7.ForeColor = System.Drawing.Color.Crimson;
            this.annunciator7.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator7.Location = new System.Drawing.Point(84, 32);
            this.annunciator7.Name = "annunciator7";
            this.annunciator7.Size = new System.Drawing.Size(135, 32);
            this.annunciator7.TabIndex = 6;
            this.annunciator7.Text = "SteadyOn";
            //
            // NonstandardAnnunciator
            //
            this.NonstandardAnnunciator.ActiveColor = System.Drawing.Color.Crimson;
            this.NonstandardAnnunciator.AutoSize = true;
            this.NonstandardAnnunciator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciatorPanel1.SetFlowBreak(this.NonstandardAnnunciator, true);
            this.NonstandardAnnunciator.Font = new System.Drawing.Font("Consolas", 20F);
            this.NonstandardAnnunciator.ForeColor = System.Drawing.Color.Crimson;
            this.NonstandardAnnunciator.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.NonstandardAnnunciator.Location = new System.Drawing.Point(225, 32);
            this.NonstandardAnnunciator.Name = "NonstandardAnnunciator";
            this.NonstandardAnnunciator.Size = new System.Drawing.Size(300, 32);
            this.NonstandardAnnunciator.TabIndex = 6;
            this.NonstandardAnnunciator.Text = "Nonstandard Cadence";
            //
            // Sequence1
            //
            this.Sequence1.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence1.AutoSize = true;
            this.Sequence1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence1.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence1.Location = new System.Drawing.Point(3, 64);
            this.Sequence1.Name = "Sequence1";
            this.Sequence1.Size = new System.Drawing.Size(35, 37);
            this.Sequence1.TabIndex = 9;
            this.Sequence1.Text = "1";
            //
            // ledIndicator1
            //
            this.ledIndicator1.AutoSize = true;
            this.ledIndicator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator1.Cadence = TA.WinFormsControls.CadencePattern.SteadyOff;
            this.ledIndicator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator1.LabelText = "SteadyOff";
            this.ledIndicator1.Location = new System.Drawing.Point(13, 119);
            this.ledIndicator1.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator1.Name = "ledIndicator1";
            this.ledIndicator1.Size = new System.Drawing.Size(97, 17);
            this.ledIndicator1.TabIndex = 1;
            //
            // ledIndicator2
            //
            this.ledIndicator2.AutoSize = true;
            this.ledIndicator2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator2.Cadence = TA.WinFormsControls.CadencePattern.Strobe;
            this.ledIndicator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator2.LabelText = "Strobe";
            this.ledIndicator2.Location = new System.Drawing.Point(12, 141);
            this.ledIndicator2.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator2.Name = "ledIndicator2";
            this.ledIndicator2.Size = new System.Drawing.Size(76, 17);
            this.ledIndicator2.Status = TA.WinFormsControls.TrafficLight.Red;
            this.ledIndicator2.TabIndex = 2;
            //
            // ledIndicator4
            //
            this.ledIndicator4.AutoSize = true;
            this.ledIndicator4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator4.Cadence = TA.WinFormsControls.CadencePattern.BlinkFast;
            this.ledIndicator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator4.LabelText = "BlinkFast";
            this.ledIndicator4.Location = new System.Drawing.Point(12, 185);
            this.ledIndicator4.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator4.Name = "ledIndicator4";
            this.ledIndicator4.Size = new System.Drawing.Size(91, 17);
            this.ledIndicator4.Status = TA.WinFormsControls.TrafficLight.Yellow;
            this.ledIndicator4.TabIndex = 4;
            //
            // ledIndicator5
            //
            this.ledIndicator5.AutoSize = true;
            this.ledIndicator5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator5.Cadence = TA.WinFormsControls.CadencePattern.BlinkSlow;
            this.ledIndicator5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator5.LabelText = "BlinkSlow";
            this.ledIndicator5.Location = new System.Drawing.Point(12, 207);
            this.ledIndicator5.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator5.Name = "ledIndicator5";
            this.ledIndicator5.Size = new System.Drawing.Size(93, 17);
            this.ledIndicator5.Status = TA.WinFormsControls.TrafficLight.Yellow;
            this.ledIndicator5.TabIndex = 5;
            //
            // ledIndicator6
            //
            this.ledIndicator6.AutoSize = true;
            this.ledIndicator6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator6.Cadence = TA.WinFormsControls.CadencePattern.Wink;
            this.ledIndicator6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator6.LabelText = "Wink";
            this.ledIndicator6.Location = new System.Drawing.Point(12, 229);
            this.ledIndicator6.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator6.Name = "ledIndicator6";
            this.ledIndicator6.Size = new System.Drawing.Size(65, 17);
            this.ledIndicator6.TabIndex = 6;
            //
            // ledIndicator7
            //
            this.ledIndicator7.AutoSize = true;
            this.ledIndicator7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator7.LabelText = "SteadyOn";
            this.ledIndicator7.Location = new System.Drawing.Point(12, 251);
            this.ledIndicator7.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator7.Name = "ledIndicator7";
            this.ledIndicator7.Size = new System.Drawing.Size(97, 17);
            this.ledIndicator7.TabIndex = 7;
            //
            // ledIndicator3
            //
            this.ledIndicator3.AutoSize = true;
            this.ledIndicator3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledIndicator3.Cadence = TA.WinFormsControls.CadencePattern.BlinkAlarm;
            this.ledIndicator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledIndicator3.LabelText = "BlinkAlarm";
            this.ledIndicator3.Location = new System.Drawing.Point(13, 163);
            this.ledIndicator3.Margin = new System.Windows.Forms.Padding(0);
            this.ledIndicator3.Name = "ledIndicator3";
            this.ledIndicator3.Size = new System.Drawing.Size(100, 17);
            this.ledIndicator3.Status = TA.WinFormsControls.TrafficLight.Red;
            this.ledIndicator3.TabIndex = 8;
            //
            // annunciator8
            //
            this.annunciator8.ActiveColor = System.Drawing.Color.Empty;
            this.annunciator8.AutoSize = true;
            this.annunciator8.BackColor = System.Drawing.SystemColors.Control;
            this.annunciator8.Cadence = TA.WinFormsControls.CadencePattern.Offbeat;
            this.annunciator8.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator8.ForeColor = System.Drawing.Color.Gainsboro;
            this.annunciator8.InactiveColor = System.Drawing.Color.Gainsboro;
            this.annunciator8.Location = new System.Drawing.Point(234, 141);
            this.annunciator8.Name = "annunciator8";
            this.annunciator8.Size = new System.Drawing.Size(215, 37);
            this.annunciator8.TabIndex = 9;
            this.annunciator8.Text = "Still Alive";
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.annunciator14);
            this.panel1.Controls.Add(this.annunciator13);
            this.panel1.Controls.Add(this.annunciator12);
            this.panel1.Controls.Add(this.annunciator10);
            this.panel1.Controls.Add(this.annunciator11);
            this.panel1.Controls.Add(this.annunciator9);
            this.panel1.Location = new System.Drawing.Point(231, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 231);
            this.panel1.TabIndex = 10;
            //
            // annunciator14
            //
            this.annunciator14.ActiveColor = System.Drawing.Color.Blue;
            this.annunciator14.AutoSize = true;
            this.annunciator14.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.annunciator14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.annunciator14.Cadence = TA.WinFormsControls.CadencePattern.Pulse4;
            this.annunciator14.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator14.ForeColor = System.Drawing.Color.DimGray;
            this.annunciator14.InactiveColor = System.Drawing.Color.DimGray;
            this.annunciator14.Location = new System.Drawing.Point(373, 44);
            this.annunciator14.Name = "annunciator14";
            this.annunciator14.Size = new System.Drawing.Size(145, 39);
            this.annunciator14.TabIndex = 9;
            this.annunciator14.Text = "4 Pulse";
            //
            // annunciator13
            //
            this.annunciator13.ActiveColor = System.Drawing.Color.Blue;
            this.annunciator13.AutoSize = true;
            this.annunciator13.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.annunciator13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.annunciator13.Cadence = TA.WinFormsControls.CadencePattern.Pulse3;
            this.annunciator13.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator13.ForeColor = System.Drawing.Color.DimGray;
            this.annunciator13.InactiveColor = System.Drawing.Color.DimGray;
            this.annunciator13.Location = new System.Drawing.Point(224, 42);
            this.annunciator13.Name = "annunciator13";
            this.annunciator13.Size = new System.Drawing.Size(145, 39);
            this.annunciator13.TabIndex = 9;
            this.annunciator13.Text = "3 Pulse";
            //
            // annunciator12
            //
            this.annunciator12.ActiveColor = System.Drawing.Color.Blue;
            this.annunciator12.AutoSize = true;
            this.annunciator12.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.annunciator12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.annunciator12.Cadence = TA.WinFormsControls.CadencePattern.Pulse2;
            this.annunciator12.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator12.ForeColor = System.Drawing.Color.DimGray;
            this.annunciator12.InactiveColor = System.Drawing.Color.DimGray;
            this.annunciator12.Location = new System.Drawing.Point(373, 5);
            this.annunciator12.Name = "annunciator12";
            this.annunciator12.Size = new System.Drawing.Size(145, 39);
            this.annunciator12.TabIndex = 9;
            this.annunciator12.Text = "2 Pulse";
            //
            // annunciator10
            //
            this.annunciator10.ActiveColor = System.Drawing.Color.Blue;
            this.annunciator10.AutoSize = true;
            this.annunciator10.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.annunciator10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.annunciator10.Cadence = TA.WinFormsControls.CadencePattern.Pulse1;
            this.annunciator10.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator10.ForeColor = System.Drawing.Color.DimGray;
            this.annunciator10.InactiveColor = System.Drawing.Color.DimGray;
            this.annunciator10.Location = new System.Drawing.Point(224, 5);
            this.annunciator10.Name = "annunciator10";
            this.annunciator10.Size = new System.Drawing.Size(145, 39);
            this.annunciator10.TabIndex = 9;
            this.annunciator10.Text = "1 Pulse";
            //
            // annunciator11
            //
            this.annunciator11.ActiveColor = System.Drawing.Color.Blue;
            this.annunciator11.AutoSize = true;
            this.annunciator11.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.annunciator11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.annunciator11.Cadence = TA.WinFormsControls.CadencePattern.Offbeat;
            this.annunciator11.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator11.ForeColor = System.Drawing.Color.DimGray;
            this.annunciator11.InactiveColor = System.Drawing.Color.DimGray;
            this.annunciator11.Location = new System.Drawing.Point(3, 44);
            this.annunciator11.Name = "annunciator11";
            this.annunciator11.Size = new System.Drawing.Size(217, 39);
            this.annunciator11.TabIndex = 9;
            this.annunciator11.Text = "Still Alive";
            //
            // annunciator9
            //
            this.annunciator9.ActiveColor = System.Drawing.Color.Blue;
            this.annunciator9.AutoSize = true;
            this.annunciator9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.annunciator9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.annunciator9.Cadence = TA.WinFormsControls.CadencePattern.Heartbeat;
            this.annunciator9.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.annunciator9.ForeColor = System.Drawing.Color.DimGray;
            this.annunciator9.InactiveColor = System.Drawing.Color.DimGray;
            this.annunciator9.Location = new System.Drawing.Point(3, 5);
            this.annunciator9.Name = "annunciator9";
            this.annunciator9.Size = new System.Drawing.Size(217, 39);
            this.annunciator9.TabIndex = 9;
            this.annunciator9.Text = "Still Alive";
            //
            // Sequence2
            //
            this.Sequence2.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence2.AutoSize = true;
            this.Sequence2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence2.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence2.Location = new System.Drawing.Point(44, 64);
            this.Sequence2.Name = "Sequence2";
            this.Sequence2.Size = new System.Drawing.Size(35, 37);
            this.Sequence2.TabIndex = 9;
            this.Sequence2.Text = "2";
            //
            // Sequence3
            //
            this.Sequence3.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence3.AutoSize = true;
            this.Sequence3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence3.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence3.Location = new System.Drawing.Point(85, 64);
            this.Sequence3.Name = "Sequence3";
            this.Sequence3.Size = new System.Drawing.Size(35, 37);
            this.Sequence3.TabIndex = 9;
            this.Sequence3.Text = "3";
            //
            // Sequence4
            //
            this.Sequence4.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence4.AutoSize = true;
            this.Sequence4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence4.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence4.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence4.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence4.Location = new System.Drawing.Point(126, 64);
            this.Sequence4.Name = "Sequence4";
            this.Sequence4.Size = new System.Drawing.Size(35, 37);
            this.Sequence4.TabIndex = 9;
            this.Sequence4.Text = "4";
            //
            // Sequence5
            //
            this.Sequence5.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence5.AutoSize = true;
            this.Sequence5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence5.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence5.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence5.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence5.Location = new System.Drawing.Point(167, 64);
            this.Sequence5.Name = "Sequence5";
            this.Sequence5.Size = new System.Drawing.Size(35, 37);
            this.Sequence5.TabIndex = 9;
            this.Sequence5.Text = "5";
            //
            // Sequence6
            //
            this.Sequence6.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence6.AutoSize = true;
            this.Sequence6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence6.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence6.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence6.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence6.Location = new System.Drawing.Point(208, 64);
            this.Sequence6.Name = "Sequence6";
            this.Sequence6.Size = new System.Drawing.Size(35, 37);
            this.Sequence6.TabIndex = 9;
            this.Sequence6.Text = "6";
            //
            // Sequence7
            //
            this.Sequence7.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence7.AutoSize = true;
            this.Sequence7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence7.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence7.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence7.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence7.Location = new System.Drawing.Point(249, 64);
            this.Sequence7.Name = "Sequence7";
            this.Sequence7.Size = new System.Drawing.Size(35, 37);
            this.Sequence7.TabIndex = 9;
            this.Sequence7.Text = "7";
            //
            // Sequence8
            //
            this.Sequence8.ActiveColor = System.Drawing.Color.Yellow;
            this.Sequence8.AutoSize = true;
            this.Sequence8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sequence8.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.Sequence8.ForeColor = System.Drawing.Color.Yellow;
            this.Sequence8.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.Sequence8.Location = new System.Drawing.Point(290, 64);
            this.Sequence8.Name = "Sequence8";
            this.Sequence8.Size = new System.Drawing.Size(35, 37);
            this.Sequence8.TabIndex = 9;
            this.Sequence8.Text = "8";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.annunciator8);
            this.Controls.Add(this.ledIndicator3);
            this.Controls.Add(this.ledIndicator7);
            this.Controls.Add(this.ledIndicator6);
            this.Controls.Add(this.ledIndicator5);
            this.Controls.Add(this.ledIndicator4);
            this.Controls.Add(this.ledIndicator2);
            this.Controls.Add(this.ledIndicator1);
            this.Controls.Add(this.annunciatorPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.annunciatorPanel1.ResumeLayout(false);
            this.annunciatorPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private AnnunciatorPanel annunciatorPanel1;
        private Annunciator annunciator1;
        private Annunciator annunciator2;
        private Annunciator annunciator3;
        private Annunciator annunciator4;
        private Annunciator annunciator6;
        private Annunciator annunciator7;
        private LedIndicator ledIndicator1;
        private LedIndicator ledIndicator2;
        private LedIndicator ledIndicator4;
        private LedIndicator ledIndicator5;
        private LedIndicator ledIndicator6;
        private LedIndicator ledIndicator7;
        private Annunciator annunciator5;
        private LedIndicator ledIndicator3;
        private Annunciator annunciator8;
        private System.Windows.Forms.Panel panel1;
        private Annunciator annunciator14;
        private Annunciator annunciator13;
        private Annunciator annunciator12;
        private Annunciator annunciator10;
        private Annunciator annunciator11;
        private Annunciator annunciator9;
        private Annunciator NonstandardAnnunciator;
        private Annunciator Sequence1;
        private Annunciator Sequence2;
        private Annunciator Sequence3;
        private Annunciator Sequence4;
        private Annunciator Sequence5;
        private Annunciator Sequence6;
        private Annunciator Sequence7;
        private Annunciator Sequence8;
        }
    }

