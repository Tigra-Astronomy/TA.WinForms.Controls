// This file is part of the TI.DigitalDomeWorks project
// 
// Copyright � 2015-2016 Tigra Networks., all rights reserved.
// 
// File: ICadencedControl.cs  Last modified: 2016-09-12@23:15 by Tim Long

namespace TA.WinFormsControls
    {
    /// <summary>
    ///     Defines the members necessary for a control to register and be managed by the
    ///     <see cref="CadenceManager" /> singleton.
    /// </summary>
    public interface ICadencedControl
        {
        /// <summary>
        ///     Gets or sets the cadence (blink pattern) of the control.
        ///     Different cadence patterns imply different levels of urgency or severity.
        /// </summary>
        /// <value>The cadence pattern.</value>
        CadencePattern Cadence { get; set; }

        /// <summary>
        ///     Updates the control's display.
        ///     <see cref="CadenceManager" /> always calls this method on the GUI thread so that control updates are thread-safe.
        /// </summary>
        void CadenceUpdate(bool newState);
        }
    }