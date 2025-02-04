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
    public partial class MainWindow : Form
    {
        public static Color CurrentColor { get; set; }
        public static Color PickedColor { get; set; }
        public static Brushes CurrentBrush { get; private set; }

        public static int CurrentWidth { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            CurrentColor = Color.Black;
            PickedColor = Color.White;
            CurrentBrush = Brushes.Brush;
            CurrentWidth = 1;
            UpdateSaveCommands(this);
            UpdateWindowCommands(this);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new FormAbout();
            frmAbout.ShowDialog();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDocument = new FormDocument();
            frmDocument.MdiParent = this;
            frmDocument.StartPosition = FormStartPosition.WindowsDefaultLocation;
            frmDocument.Show();
        }

        private void toolStripButtonColorBlack_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonColorBlack.Checked)
            {
                CurrentColor = Color.Black;
                toolStripButtonColorGreen.Checked = false;
                toolStripButtonColorRed.Checked = false;
                toolStripButtonColorBlack.Checked = true;
                toolStripButtonPickedColor.Checked = false;
            }
        }

        private void toolStripButtonColorRed_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonColorRed.Checked)
            {
                CurrentColor = Color.Red;
                toolStripButtonColorBlack.Checked = false;
                toolStripButtonColorGreen.Checked = false;
                toolStripButtonColorRed.Checked = true;
                toolStripButtonPickedColor.Checked = false;
            }
        }

        private void toolStripButtonColorGreen_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonColorGreen.Checked)
            {
                CurrentColor = Color.Green;
                toolStripButtonColorBlack.Checked = false;
                toolStripButtonColorRed.Checked = false;
                toolStripButtonColorGreen.Checked = true;
                toolStripButtonPickedColor.Checked = false;
            }
        }

        private void toolStripButtonColorPicker_Click(object sender, EventArgs e)
        {
            var colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                MainWindow.CurrentColor = colorPicker.Color;
                MainWindow.PickedColor = colorPicker.Color;
                toolStripButtonColorBlack.Checked = false;
                toolStripButtonColorRed.Checked = false;
                toolStripButtonColorGreen.Checked = false;
                toolStripButtonPickedColor.BackColor = colorPicker.Color;
                toolStripButtonPickedColor.ForeColor = colorPicker.Color;
                toolStripButtonPickedColor.Checked = true;
            }
        }

        private void toolStripButtonPickedColor_Paint(object sender, PaintEventArgs e)
        {
            if (sender is ToolStripButton button)
            {
                using (Brush brush = new SolidBrush(button.BackColor))
                {
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
                }

                if (button.Checked)
                {
                    using (Pen pen = new Pen(Color.FromArgb(
                                                            255 - MainWindow.PickedColor.R,
                                                            255 - MainWindow.PickedColor.G,
                                                            255 - MainWindow.PickedColor.B
                        ), 2))
                    {
                        Rectangle borderRect = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
                        e.Graphics.DrawRectangle(pen, borderRect);
                    }
                }
            }
        }

        private void toolStripButtonPickedColor_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonPickedColor.Checked)
            {
                CurrentColor = MainWindow.PickedColor;
                toolStripButtonColorBlack.Checked = false;
                toolStripButtonColorRed.Checked = false;
                toolStripButtonColorGreen.Checked = false;
                toolStripButtonPickedColor.Checked = true;
            }
        }

        private void toolStripWidthButton_Click(object sender, EventArgs e)
        {
            var widthPicker = new FormWidthPicker();
            var lastWidth = MainWindow.CurrentWidth;
            widthPicker.StartPosition = FormStartPosition.CenterParent;
            if (widthPicker.ShowDialog() != DialogResult.OK)
            {
                MainWindow.CurrentWidth = lastWidth;
            }
            else
            {
                toolStripWidthLabel.Text = $"Толщина: {CurrentWidth}";
            }
        }

        private void каскадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        public static void UpdateSaveCommands(Form form)
        {
            if (form is MainWindow mw)
            {
                bool hasOpenDocuments = mw.MdiChildren.Any(child => !child.IsDisposed && child.Visible);
                mw.сохранитьToolStripMenuItem.ForeColor = !hasOpenDocuments ? Color.Gray : Color.Black;
                mw.сохранитьКакToolStripMenuItem.ForeColor = !hasOpenDocuments ? Color.Gray : Color.Black;
                mw.сохранитьToolStripMenuItem.Enabled = hasOpenDocuments;
                mw.сохранитьКакToolStripMenuItem.Enabled = hasOpenDocuments;
            }
        }

        private void MainWindow_MdiChildActivate(object sender, EventArgs e)
        {
            UpdateSaveCommands(this);
            UpdateWindowCommands(this);
        }

        public static void UpdateWindowCommands(Form form)
        {
            if (form is MainWindow mw)
            {
                bool hasOpenDocuments = mw.MdiChildren.Any(child => !child.IsDisposed && child.Visible);
                bool hasMinimizedWindows = mw.MdiChildren.Any(window => window.WindowState == FormWindowState.Minimized);
                bool hasNonMinimizedWindows = mw.MdiChildren.Any(window => window.WindowState != FormWindowState.Minimized);

                mw.каскадToolStripMenuItem.Enabled = hasOpenDocuments && hasNonMinimizedWindows;
                mw.слеваНаправоToolStripMenuItem.Enabled = hasOpenDocuments && hasNonMinimizedWindows;
                mw.сверхуВнизToolStripMenuItem.Enabled = hasOpenDocuments && hasNonMinimizedWindows;
                mw.упорядочитьЗначкиToolStripMenuItem.Enabled = hasOpenDocuments && hasMinimizedWindows;

                mw.каскадToolStripMenuItem.ForeColor = hasOpenDocuments && hasNonMinimizedWindows ? Color.Black : Color.Gray;
                mw.слеваНаправоToolStripMenuItem.ForeColor = hasOpenDocuments && hasNonMinimizedWindows ? Color.Black : Color.Gray;
                mw.сверхуВнизToolStripMenuItem.ForeColor = hasOpenDocuments && hasNonMinimizedWindows ? Color.Black : Color.Gray;
                mw.упорядочитьЗначкиToolStripMenuItem.ForeColor = hasOpenDocuments && hasMinimizedWindows ? Color.Black : Color.Gray;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocument.Save(ActiveMdiChild);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocument.SaveAs(ActiveMdiChild);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void OpenFile()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                // Настройка фильтров
                openDialog.Filter = "Изображения (*.bmp;*.jpg;*.jpeg)|*.bmp;*.jpg;*.jpeg|Все файлы (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.Title = "Открыть изображение";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Создаем новый документ и загружаем изображение
                        FormDocument doc = new FormDocument(openDialog.FileName);
                        doc.MdiParent = this;
                        doc.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void размерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormDocument docForm)
            {
                int currentWidth = docForm.Width;
                int currentHeight = docForm.Height;

                using (var dialog = new FormResize(currentHeight, currentWidth))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            docForm.ResizeCanvas(dialog.Width, dialog.Height);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void toolStripButtonBrush_Click(object sender, EventArgs e)
        {
            if (CurrentBrush != Brushes.Brush)
            {
                CurrentBrush = Brushes.Brush;
                toolStripButtonLine.Checked = false;
                toolStripButtonEllipse.Checked = false;
                toolStripButtonEraser.Checked = false;
                toolStripButtonCallout.Checked = false;
            }
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            if (CurrentBrush != Brushes.Line)
            {
                CurrentBrush = Brushes.Line;
                toolStripButtonBrush.Checked = false;
                toolStripButtonEllipse.Checked = false;
                toolStripButtonEraser.Checked = false;
                toolStripButtonCallout.Checked = false;
            }
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            if (CurrentBrush != Brushes.Ellipse)
            {
                CurrentBrush = Brushes.Ellipse;
                toolStripButtonBrush.Checked = false;
                toolStripButtonLine.Checked = false;
                toolStripButtonEraser.Checked = false;
                toolStripButtonCallout.Checked = false;
            }
        }

        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            if (CurrentBrush != Brushes.Eraser)
            {
                CurrentBrush = Brushes.Eraser;
                toolStripButtonBrush.Checked = false;
                toolStripButtonLine.Checked = false;
                toolStripButtonEllipse.Checked = false;
                toolStripButtonCallout.Checked = false;
            }
        }

        private void toolStripButtonCallout_Click(object sender, EventArgs e)
        {
            if (CurrentBrush != Brushes.Callout)
            {
                CurrentBrush = Brushes.Eraser;
                toolStripButtonBrush.Checked = false;
                toolStripButtonLine.Checked = false;
                toolStripButtonEllipse.Checked = false;
                toolStripButtonEraser.Checked = false;
            }
        }
    }
}
