// This file is part of the TA.WinForms.Controls project
// Copyright © 2016-2019 Tigra Astronomy, all rights reserved.
// File: LEDIndicator.cs  Last modified: 2019-09-21@02:51 by Tim Long
// Licensed under the Tigra MIT License, see https://tigra.mit-license.org/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TA.WinFormsControls
{
    /// <summary>
    ///     Provides a status indicator modeled on a bi-colour red/green LED lamp. The lamp can be red or green and
    ///     (traffic light colours) and can be steady or can flash with a choice of different cadences.
    /// </summary>
    [DefaultProperty("LabelText")]
    public sealed class LedIndicator : UserControl, ICadencedControl
    {
        private readonly Container components; // required designer variable
        private bool lastState; // True if cadence updates are enabled
        private bool powerOn = true;
        private bool disposed;
        private Label ledLabel;
        private TableLayoutPanel contentLayoutPanel;
        private Panel ledPanel;

        public LedIndicator()
        {
            components = null;
            InitializeComponent(); // This call is required by the Windows.Forms Form Designer.
            Cadence = CadencePattern.SteadyOn;
            StartCadenceUpdates();
        }

        /// <summary>
        ///     Gets or sets the LED cadence bitmap.
        ///     If the cadence has changed and is non-steady and the LED is enabled, then the cadence timer is started.
        /// </summary>
        /// <remarks>
        ///     Implements the <see cref="ICadencedControl.Cadence" /> property.
        /// </remarks>
        [Category("LED Indicator")]
        [DefaultValue(CadencePattern.SteadyOn)]
        [Description(
            "Sets the cadence (blinking pattern) of the LED indicator. Available cadences range from SteadyOff, through a number of alternating patterns of various urgency, to SteadyOn."
        )]
        public CadencePattern Cadence { get; set; }

        /// <summary>
        ///     Sets or reads the 'power status' of the LED
        ///     When the LED is Enabled, it reflects the current colour settings and cadence.
        ///     When disabled, the LED appears off and cadencing is disabled.
        /// </summary>
        [Category("LED Indicator")]
        [DefaultValue(true)]
        [Description(
            "Works like a power switch. When disabled (false), the LED always has the 'off' appearance regardless of colour or cadence settings."
        )]
        public new bool Enabled
            {
            get { return powerOn; }
            set
                {
                if (disposed)
                    throw new ObjectDisposedException("LedIndicator");
                powerOn = value;
                }
            }

        /// <summary>
        ///     Sets the text displayed alongside the indicator
        /// </summary>
        [Category("LED Indicator")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue("LED Indicator")]
        [Description("Sets the text that appears next to the LED indicator.")]
        public string LabelText
            {
            get => ledLabel.Text;
            set => ledLabel.Text = value;
            }

        /// <summary>
        ///     Gets or sets the LED's status (which controls its display colour).
        /// </summary>
        [Category("LED Indicator")]
        [DefaultValue(TrafficLight.Green)]
        [Description(
            "Sets the LEDs status which controls the display colour. LEDs support 'traffic light' colours where Green represents normal status, Yellow represents a warning condition and Red represents an error."
        )]
        public TrafficLight Status { get; set; }

        /// <summary>
        ///     Refreshes the LED display, taking account of the power,
        ///     colour and cadence settings.
        /// </summary>
        /// <param name="newState">The new state of the control's appearance ('on' or 'off').</param>
        /// <remarks>
        ///     Implements the <see cref="ICadencedControl.CadenceUpdate" /> method.
        ///     The <see cref="CadencedControlUpdater" /> always calls this method on the GUI thread.
        /// </remarks>
        public void CadenceUpdate(bool newState)
        {
            if (disposed)
                throw new ObjectDisposedException("Attempt to update a control after it has been disposed.");
            var targetState = newState && powerOn;
            if (targetState == lastState)
                return; // shortcut - try to avoid unnecessary redraws
            lastState = newState; // Remember the new state for next time.
            if (targetState)
                RenderOnAppearance();
            else
                RenderOffAppearance();
        }

        /// <summary>
        ///     Releases all resources used by the <see cref="T:System.ComponentModel.Component" />.
        /// </summary>
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///     Releases the unmanaged resources and optionally releases the managed resources.
        /// </summary>
        /// <param name="fromUserCode">
        ///     true to release both managed and unmanaged resources; false to release only unmanaged
        ///     resources.
        /// </param>
        protected override void Dispose(bool fromUserCode)
        {
            if (!disposed)
            {
                if (fromUserCode)
                {
                    StopCadenceUpdates();
                    if (components != null)
                        components.Dispose();
                    if (ledPanel != null)
                    {
                        ledPanel.Dispose();
                        ledPanel = null;
                    }
                    if (ledLabel != null)
                    {
                        ledLabel.Dispose();
                        ledLabel = null;
                    }
                }
                disposed = true;
            }
            base.Dispose(fromUserCode);
        }

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            this.ledPanel = new System.Windows.Forms.Panel();
            this.ledLabel = new System.Windows.Forms.Label();
            this.contentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contentLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledPanel
            // 
            this.ledPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ledPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ledPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ledPanel.CausesValidation = false;
            this.ledPanel.Location = new System.Drawing.Point(3, 3);
            this.ledPanel.MaximumSize = new System.Drawing.Size(20, 10);
            this.ledPanel.MinimumSize = new System.Drawing.Size(20, 10);
            this.ledPanel.Name = "ledPanel";
            this.ledPanel.Size = new System.Drawing.Size(20, 10);
            this.ledPanel.TabIndex = 0;
            // 
            // ledLabel
            // 
            this.ledLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledLabel.AutoSize = true;
            this.ledLabel.CausesValidation = false;
            this.ledLabel.Location = new System.Drawing.Point(26, 0);
            this.ledLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ledLabel.Name = "ledLabel";
            this.ledLabel.Size = new System.Drawing.Size(72, 16);
            this.ledLabel.TabIndex = 1;
            this.ledLabel.Text = "LED Indicator";
            this.ledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentLayoutPanel
            // 
            this.contentLayoutPanel.AutoSize = true;
            this.contentLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentLayoutPanel.ColumnCount = 2;
            this.contentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.contentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.contentLayoutPanel.Controls.Add(this.ledPanel, 0, 0);
            this.contentLayoutPanel.Controls.Add(this.ledLabel, 1, 0);
            this.contentLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.contentLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.contentLayoutPanel.Name = "contentLayoutPanel";
            this.contentLayoutPanel.RowCount = 1;
            this.contentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentLayoutPanel.Size = new System.Drawing.Size(98, 16);
            this.contentLayoutPanel.TabIndex = 2;
            // 
            // LedIndicator
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.contentLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "LedIndicator";
            this.Size = new System.Drawing.Size(98, 16);
            this.AutoSizeChanged += new System.EventHandler(this.LedIndicator_AutoSizeChanged);
            this.contentLayoutPanel.ResumeLayout(false);
            this.contentLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        ///     Renders the 'power off' appearance of the LED indicator.
        /// </summary>
        private void RenderOffAppearance()
        {
            SetColour(Color.WhiteSmoke);
        }

        /// <summary>
        ///     Renders the 'power on' appearance of the LED indicator. The exact appearance depends on the <see cref="Status" />
        ///     property.
        /// </summary>
        private void RenderOnAppearance()
        {
            switch (Status) // Render the 'power on' appearance according to status.
            {
                case TrafficLight.Green:
                    SetColour(Color.LightGreen);
                    break;
                case TrafficLight.Yellow:
                    SetColour(Color.Orange);
                    break;
                case TrafficLight.Red:
                    SetColour(Color.Red);
                    break;
            }
        }

        /// <summary>
        ///     Sets the colour of the LED.
        ///     If the colour is changed, then the LED's panel control is invalidated to force a re-draw.
        /// </summary>
        /// <param name="newColour">The new led colour.</param>
        private void SetColour(Color newColour)
        {
            if (newColour != ledPanel.BackColor)
            {
                ledPanel.BackColor = newColour;
                ledPanel.Invalidate();
                ledPanel.Update();
            }
        }

        /// <summary>
        ///     Register with the <see cref="CadencedControlUpdater" />.
        /// </summary>
        private void StartCadenceUpdates()
        {
            CadencedControlUpdater.Instance.Add(this);
        }

        /// <summary>
        ///     Unregister from the <see cref="CadencedControlUpdater" />.
        /// </summary>
        private void StopCadenceUpdates()
        {
            CadencedControlUpdater.Instance.Remove(this);
            RenderOffAppearance();
        }

        private void LedIndicator_AutoSizeChanged(object sender, EventArgs e)
        {
            ledLabel.AutoSize = AutoSize;
        }
    }
}