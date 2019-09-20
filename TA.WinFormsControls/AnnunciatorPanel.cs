﻿// This file is part of the TI.DigitalDomeWorks project
// 
// Copyright © 2015-2016 Tigra Networks., all rights reserved.
// 
// File: AnnunciatorPanel.cs  Last modified: 2016-09-12@23:15 by Tim Long

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TA.WinFormsControls
    {
    /// <summary>
    ///     A panel control for grouping and arranging <see cref="FlowLayoutPanel" /> controls. This control inherits most
    ///     of its behaviour from the <see cref="FlowLayoutPanel" />base class, but provides some defaults that are
    ///     appropriate for use with ASCOM.
    /// </summary>
    public sealed class AnnunciatorPanel : FlowLayoutPanel
        {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AnnunciatorPanel" /> class.
        /// </summary>
        public AnnunciatorPanel()
            {
            BackColor = Color.FromArgb(64, 0, 0);
            }

        /// <summary>
        ///     Releases all resources used by the <see cref="T:System.ComponentModel.Component" />.
        /// </summary>
        public new void Dispose()
            {
            Dispose(true);
            GC.SuppressFinalize(this);
            }
        }
    }