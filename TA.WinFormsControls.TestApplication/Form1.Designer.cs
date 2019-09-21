namespace TA.WinFormsControls.TestApplication
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
            this.ledIndicator1 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator2 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator3 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator4 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator5 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator6 = new TA.WinFormsControls.LedIndicator();
            this.ledIndicator7 = new TA.WinFormsControls.LedIndicator();
            this.annunciatorPanel1.SuspendLayout();
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
            this.annunciatorPanel1.Location = new System.Drawing.Point(13, 13);
            this.annunciatorPanel1.Name = "annunciatorPanel1";
            this.annunciatorPanel1.Size = new System.Drawing.Size(775, 100);
            this.annunciatorPanel1.TabIndex = 0;
            // 
            // annunciator1
            // 
            this.annunciator1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator1.AutoSize = true;
            this.annunciator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator1.Cadence = TA.WinFormsControls.CadencePattern.SteadyOff;
            this.annunciator1.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator1.Location = new System.Drawing.Point(3, 0);
            this.annunciator1.Mute = false;
            this.annunciator1.Name = "annunciator1";
            this.annunciator1.Size = new System.Drawing.Size(150, 32);
            this.annunciator1.TabIndex = 0;
            this.annunciator1.Text = "SteadyOff";
            // 
            // annunciator2
            // 
            this.annunciator2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator2.AutoSize = true;
            this.annunciator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator2.Cadence = TA.WinFormsControls.CadencePattern.Strobe;
            this.annunciator2.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator2.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator2.Location = new System.Drawing.Point(159, 0);
            this.annunciator2.Mute = false;
            this.annunciator2.Name = "annunciator2";
            this.annunciator2.Size = new System.Drawing.Size(105, 32);
            this.annunciator2.TabIndex = 1;
            this.annunciator2.Text = "Strobe";
            // 
            // annunciator3
            // 
            this.annunciator3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator3.AutoSize = true;
            this.annunciator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator3.Cadence = TA.WinFormsControls.CadencePattern.BlinkAlarm;
            this.annunciator3.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator3.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator3.Location = new System.Drawing.Point(270, 0);
            this.annunciator3.Mute = false;
            this.annunciator3.Name = "annunciator3";
            this.annunciator3.Size = new System.Drawing.Size(165, 32);
            this.annunciator3.TabIndex = 2;
            this.annunciator3.Text = "BlinkAlarm";
            // 
            // annunciator4
            // 
            this.annunciator4.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator4.AutoSize = true;
            this.annunciator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator4.Cadence = TA.WinFormsControls.CadencePattern.BlinkFast;
            this.annunciator4.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator4.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator4.Location = new System.Drawing.Point(441, 0);
            this.annunciator4.Mute = false;
            this.annunciator4.Name = "annunciator4";
            this.annunciator4.Size = new System.Drawing.Size(150, 32);
            this.annunciator4.TabIndex = 3;
            this.annunciator4.Text = "BlinkFast";
            // 
            // annunciator5
            // 
            this.annunciator5.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator5.AutoSize = true;
            this.annunciator5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator5.Cadence = TA.WinFormsControls.CadencePattern.BlinkSlow;
            this.annunciator5.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator5.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator5.Location = new System.Drawing.Point(597, 0);
            this.annunciator5.Mute = false;
            this.annunciator5.Name = "annunciator5";
            this.annunciator5.Size = new System.Drawing.Size(150, 32);
            this.annunciator5.TabIndex = 4;
            this.annunciator5.Text = "BlinkSlow";
            // 
            // annunciator6
            // 
            this.annunciator6.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator6.AutoSize = true;
            this.annunciator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator6.Cadence = TA.WinFormsControls.CadencePattern.Wink;
            this.annunciator6.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator6.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator6.Location = new System.Drawing.Point(3, 32);
            this.annunciator6.Mute = false;
            this.annunciator6.Name = "annunciator6";
            this.annunciator6.Size = new System.Drawing.Size(75, 32);
            this.annunciator6.TabIndex = 5;
            this.annunciator6.Text = "Wink";
            // 
            // annunciator7
            // 
            this.annunciator7.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator7.AutoSize = true;
            this.annunciator7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annunciator7.Font = new System.Drawing.Font("Consolas", 20F);
            this.annunciator7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator7.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.annunciator7.Location = new System.Drawing.Point(84, 32);
            this.annunciator7.Mute = false;
            this.annunciator7.Name = "annunciator7";
            this.annunciator7.Size = new System.Drawing.Size(135, 32);
            this.annunciator7.TabIndex = 6;
            this.annunciator7.Text = "SteadyOn";
            // 
            // ledIndicator1
            // 
            this.ledIndicator1.AutoSize = true;
            this.ledIndicator1.Cadence = TA.WinFormsControls.CadencePattern.SteadyOff;
            this.ledIndicator1.LabelText = "SteadyOff";
            this.ledIndicator1.Location = new System.Drawing.Point(13, 119);
            this.ledIndicator1.Name = "ledIndicator1";
            this.ledIndicator1.Size = new System.Drawing.Size(100, 16);
            this.ledIndicator1.TabIndex = 1;
            // 
            // ledIndicator2
            // 
            this.ledIndicator2.AutoSize = true;
            this.ledIndicator2.Cadence = TA.WinFormsControls.CadencePattern.Strobe;
            this.ledIndicator2.LabelText = "Strobe";
            this.ledIndicator2.Location = new System.Drawing.Point(12, 141);
            this.ledIndicator2.Name = "ledIndicator2";
            this.ledIndicator2.Size = new System.Drawing.Size(68, 16);
            this.ledIndicator2.TabIndex = 2;
            // 
            // ledIndicator3
            // 
            this.ledIndicator3.AutoSize = true;
            this.ledIndicator3.Cadence = TA.WinFormsControls.CadencePattern.BlinkAlarm;
            this.ledIndicator3.LabelText = "BlinkAlarm";
            this.ledIndicator3.Location = new System.Drawing.Point(12, 163);
            this.ledIndicator3.Name = "ledIndicator3";
            this.ledIndicator3.Size = new System.Drawing.Size(56, 16);
            this.ledIndicator3.TabIndex = 3;
            // 
            // ledIndicator4
            // 
            this.ledIndicator4.AutoSize = true;
            this.ledIndicator4.Cadence = TA.WinFormsControls.CadencePattern.BlinkFast;
            this.ledIndicator4.LabelText = "BlinkFast";
            this.ledIndicator4.Location = new System.Drawing.Point(12, 185);
            this.ledIndicator4.Name = "ledIndicator4";
            this.ledIndicator4.Size = new System.Drawing.Size(92, 16);
            this.ledIndicator4.TabIndex = 4;
            // 
            // ledIndicator5
            // 
            this.ledIndicator5.AutoSize = true;
            this.ledIndicator5.Cadence = TA.WinFormsControls.CadencePattern.BlinkSlow;
            this.ledIndicator5.LabelText = "BlinkSlow";
            this.ledIndicator5.Location = new System.Drawing.Point(12, 207);
            this.ledIndicator5.Name = "ledIndicator5";
            this.ledIndicator5.Size = new System.Drawing.Size(98, 16);
            this.ledIndicator5.TabIndex = 5;
            // 
            // ledIndicator6
            // 
            this.ledIndicator6.AutoSize = true;
            this.ledIndicator6.Cadence = TA.WinFormsControls.CadencePattern.Wink;
            this.ledIndicator6.LabelText = "Wink";
            this.ledIndicator6.Location = new System.Drawing.Point(12, 229);
            this.ledIndicator6.Name = "ledIndicator6";
            this.ledIndicator6.Size = new System.Drawing.Size(56, 16);
            this.ledIndicator6.TabIndex = 6;
            // 
            // ledIndicator7
            // 
            this.ledIndicator7.AutoSize = true;
            this.ledIndicator7.LabelText = "SteadyOn";
            this.ledIndicator7.Location = new System.Drawing.Point(12, 251);
            this.ledIndicator7.Name = "ledIndicator7";
            this.ledIndicator7.Size = new System.Drawing.Size(100, 16);
            this.ledIndicator7.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ledIndicator7);
            this.Controls.Add(this.ledIndicator6);
            this.Controls.Add(this.ledIndicator5);
            this.Controls.Add(this.ledIndicator4);
            this.Controls.Add(this.ledIndicator3);
            this.Controls.Add(this.ledIndicator2);
            this.Controls.Add(this.ledIndicator1);
            this.Controls.Add(this.annunciatorPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.annunciatorPanel1.ResumeLayout(false);
            this.annunciatorPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private AnnunciatorPanel annunciatorPanel1;
        private Annunciator annunciator1;
        private Annunciator annunciator2;
        private Annunciator annunciator3;
        private Annunciator annunciator4;
        private Annunciator annunciator5;
        private Annunciator annunciator6;
        private Annunciator annunciator7;
        private LedIndicator ledIndicator1;
        private LedIndicator ledIndicator2;
        private LedIndicator ledIndicator3;
        private LedIndicator ledIndicator4;
        private LedIndicator ledIndicator5;
        private LedIndicator ledIndicator6;
        private LedIndicator ledIndicator7;
        }
    }

