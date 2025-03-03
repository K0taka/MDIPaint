﻿using System;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class FormResize : Form
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public FormResize(int h, int w)
        {
            Width = w;
            Height = h;
            InitializeComponent();
            numericUpDownX.Value = w;
            numericUpDownY.Value = h;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Width = (int)numericUpDownX.Value;
            Height = (int)numericUpDownY.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
