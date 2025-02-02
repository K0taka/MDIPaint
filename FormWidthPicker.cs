﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void trackBarWidth_ValueChanged(object sender, EventArgs e)
        {
            MainWindow.CurrentWidth = trackBarWidth.Value;
            labelChosen.Text = $"Выбрано: {trackBarWidth.Value}";
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

            // Вычисляем новое значение на основе позиции мыши
            double ratio = (double)e.X / trackBar.Width;
            int newValue = (int)(ratio * (trackBar.Maximum - trackBar.Minimum)) + trackBar.Minimum;

            // Устанавливаем новое значение
            trackBar.Value = newValue;
        }
    }
}
