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
        int oldX, oldY;
        Bitmap bitmap = new Bitmap(400, 400);
        bool isMoving = false;

        public FormDocument()
        {
            InitializeComponent();
            AutoScrollMinSize = new Size(bitmap.Width, bitmap.Height);
        }
        
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
                int scrollX = this.AutoScrollPosition.X;
                int scrollY = this.AutoScrollPosition.Y;

                var g = Graphics.FromImage(bitmap);
                g.DrawLine(new Pen(MainWindow.CurrentColor, MainWindow.CurrentWidth), oldX - scrollX, oldY - scrollY, e.X - scrollX, e.Y - scrollY); oldX = e.X;
                oldY = e.Y;

                Invalidate();
            }
        }

        private void FormDocument_LocationChanged(object sender, EventArgs e)
        {
            isMoving = false;
            Invalidate();
        }

        private void FormDocument_Move(object sender, EventArgs e)
        {
            isMoving = true;
        }

        private void FormDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.UpdateSaveCommands(MdiParent);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (isMoving)
                return;
            base.OnPaint(e);

            int scrollX = this.AutoScrollPosition.X;
            int scrollY = this.AutoScrollPosition.Y;
            e.Graphics.DrawImage(bitmap, scrollX, scrollY);
        }
    }
}
