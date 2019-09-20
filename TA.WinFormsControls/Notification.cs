// This file is part of the TI.DigitalDomeWorks project
// 
// Copyright © 2015-2016 Tigra Networks., all rights reserved.
// 
// File: Notification.cs  Last modified: 2016-09-12@23:15 by Tim Long

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace TA.WinFormsControls
    {
    /// <summary>
    ///     Notification Control
    /// </summary>
    public class Notification : FadeDialog
        {
        #region Windows Form Designer generated code
        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            var resources = new System.Resources.ResourceManager(typeof(Notification));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'ve got email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 72);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(112, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check the web site";
            this.linkLabel1.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Notification
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 88);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Notification";
            this.Text = "Notification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            }
        #endregion

        #region Ctor, init code and dispose
        /// <summary>
        ///     Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        public Notification() : base(true)
            {
            InitializeComponent();
            }

        /// <summary>
        ///     Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="disposing">
        ///     true to release both managed and unmanaged resources; false to release only unmanaged
        ///     resources.
        /// </param>
        protected override void Dispose(bool disposing)
            {
            if (disposing)
                {
                if (components != null)
                    components.Dispose();
                }
            base.Dispose(disposing);
            }
        #endregion // Ctor and init code

        #region Event handler
        private void Notification_Load(object sender, EventArgs e)
            {
            var screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            var screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            Left = screenWidth - Width;
            Top = screenHeight - Height;

            timer1.Enabled = true;

            var link = "http://www.geocities.com/basuabhinaba";
            linkLabel1.Links.Add(0, link.Length, link);
            }

        private void timer1_Tick(object sender, EventArgs e)
            {
            Close();
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            var link = e.Link.LinkData.ToString();
            if (link != null && link.Length > 0)
                Process.Start(link);
            }
        #endregion // Event handler

        #region Designer generated variables
        private IContainer components;
        private Label label1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Timer timer1;
        #endregion
        }
    }