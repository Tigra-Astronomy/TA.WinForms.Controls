using System;
using System.Windows.Forms;
using TA.WinFormsControls;

namespace TA.WinForms.Controls.TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var customCadence = (CadencePattern) 0x01545451; // 00000001010101000101010001010001
            NonstandardAnnunciator.Cadence = customCadence;
            var chasePattern = 0x00000001;
            Sequence1.Cadence = (CadencePattern)chasePattern;
            Sequence2.Cadence = (CadencePattern) (chasePattern << 1);
            Sequence3.Cadence = (CadencePattern) (chasePattern << 2);
            Sequence4.Cadence = (CadencePattern) (chasePattern << 3);
            Sequence5.Cadence = (CadencePattern) (chasePattern << 4);
            Sequence6.Cadence = (CadencePattern) (chasePattern << 5);
            Sequence7.Cadence = (CadencePattern) (chasePattern << 6);
            Sequence8.Cadence = (CadencePattern) (chasePattern << 7);
        }
    }
}
