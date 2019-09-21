// This file is part of the TA.WinForms.Controls project
// Copyright © 2016-2019 Tigra Astronomy, all rights reserved.
// File: FadeDialog.cs  Last modified: 2019-09-21@02:42 by Tim Long
// Licensed under the Tigra MIT License, see https://tigra.mit-license.org/

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TA.WinFormsControls
{
    /// <summary>
    ///     Base class that gives any form that derives from it the effect of slowly appearing and then disapperaing.
    ///     Much like outlook email notification pop-ups
    /// </summary>
    public class FadeDialog : Form
    {
        private readonly bool m_bDisposeAtEnd;
        private IContainer components;
        private bool m_bForceClose;
        private bool m_bShowing = true;
        private Timer m_clock;
        private DialogResult m_origDialogResult;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FadeDialog" /> class.
        /// </summary>
        protected FadeDialog()
        {
            InitializeComponents();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FadeDialog" /> class.
        /// </summary>
        /// <param name="disposeAtEnd">if set to <c>true</c> [dispose at end].</param>
        protected FadeDialog(bool disposeAtEnd)
        {
            m_bDisposeAtEnd = disposeAtEnd;
            InitializeComponents();
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
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void Animate(object sender, EventArgs e)
        {
            if (m_bShowing)
            {
                if (Opacity < 1)
                    Opacity += 0.1;
                else
                    m_clock.Stop();
            }
            else
            {
                if (Opacity > 0)
                    Opacity -= 0.1;
                else
                {
                    m_clock.Stop();
                    m_bForceClose = true;
                    Close();
                    if (m_bDisposeAtEnd)
                        Dispose();
                }
            }
        }

        private void InitializeComponents()
        {
            components = new Container();
            m_clock = new Timer(components);
            m_clock.Interval = 100;
            SuspendLayout();
            //m_clock
            m_clock.Tick += Animate;
            //TransDialog
            Load += TransDialog_Load;
            Closing += TransDialog_Closing;
            ResumeLayout(false);
            PerformLayout();
        }

        private void TransDialog_Closing(object sender, CancelEventArgs e)
        {
            if (!m_bForceClose)
            {
                m_origDialogResult = DialogResult;
                e.Cancel = true;
                m_bShowing = false;
                m_clock.Start();
            }
            else
                DialogResult = m_origDialogResult;
        }

        private void TransDialog_Load(object sender, EventArgs e)
        {
            Opacity = 0.0;
            m_bShowing = true;

            m_clock.Start();
        }
    }
}