using System;
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
    public partial class FormDocument : Form
    {
        public FormDocument()
        {
            InitializeComponent();
        }


        int oldX, oldY;
        Bitmap bitmap = new Bitmap(400, 400);
        private void FormDocument_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldX = e.X;
                oldY = e.Y;
            }
        }

        private void FormDocument_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var g = Graphics.FromImage(bitmap);
                g.DrawLine(new Pen(MainWindow.CurrentColor, MainWindow.CurrentWidth), oldX, oldY, e.X, e.Y);
                oldX = e.X;
                oldY = e.Y;

                CreateGraphics().DrawImage(bitmap, 0, 0);
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
