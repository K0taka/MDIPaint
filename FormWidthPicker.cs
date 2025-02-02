using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class FormWidthPicker : Form
    {
        public FormWidthPicker()
        {
            InitializeComponent();
            trackBarWidth.Value = MainWindow.CurrentWidth;
        }

        private void trackBarWidth_ValueChanged(object sender, EventArgs e)
        {
            MainWindow.CurrentWidth = trackBarWidth.Value;
            labelChosen.Text = $"Выбрано: {trackBarWidth.Value}";
            trackBarWidth.Value = MainWindow.CurrentWidth;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        private void trackBarWidth_MouseDown(object sender, MouseEventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            int thumbWidth = GetThumbWidth(trackBar);

            int trackStart = thumbWidth / 2;
            int trackEnd = trackBar.Width - thumbWidth / 2;
            int trackLength = trackEnd - trackStart;

            int correctedX = e.X - trackStart;
            correctedX = Math.Max(0, Math.Min(correctedX, trackLength));

            double ratio = (double)correctedX / trackLength;
            trackBar.Value = (int)Math.Round(ratio * (trackBar.Maximum - trackBar.Minimum)) + trackBar.Minimum;
        }

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);

        private int GetThumbWidth(TrackBar trackBar)
        {
            const int SM_CXHTHUMB = 10;
            return GetSystemMetrics(SM_CXHTHUMB);
        }
    }
}
