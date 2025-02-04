using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        private string filePath = null;
        private bool isSaved = false;

        public int Width { get { return bitmap.Width; } }
        public int Height { get { return bitmap.Height; } }

        public FormDocument()
        {
            InitializeComponent();
            bitmap = new Bitmap(400, 400);
            ClearBitmap();
            InitializeDocument();
            Text = "Новый";
        }

        public FormDocument(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            LoadBitmap(filePath);
            InitializeDocument();
            Text = Path.GetFileName(filePath);
            isSaved = true;
        }

        private void InitializeDocument()
        {
            AutoScrollMinSize = bitmap.Size;
            Resize += FormDocument_Resize;
        }

        private void LoadBitmap(string path)
        {
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    bitmap = new Bitmap(stream);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Файл не является изображением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch
            {
                MessageBox.Show("Невозможно открыть файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ClearBitmap()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
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
            MainWindow.UpdateWindowCommands(MdiParent);
        }

        private void FormDocument_Resize(object sender, EventArgs e)
        {
            MainWindow.UpdateWindowCommands(MdiParent);
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

        public static void SaveAs(Form fm)
        {
            if (fm is FormDocument fd)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    // Настройка фильтров
                    saveDialog.Filter = "BMP (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
                    saveDialog.FilterIndex = 2;
                    saveDialog.DefaultExt = "jpg";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Определяем формат на основе выбранного фильтра
                        ImageFormat format = ImageFormat.Bmp;
                        if (saveDialog.FilterIndex == 2)
                            format = ImageFormat.Jpeg;

                        // Сохраняем изображение
                        fd.bitmap.Save(saveDialog.FileName, format);

                        // Обновляем путь и состояние
                        fd.filePath = saveDialog.FileName;
                        fd.isSaved = true;

                        // Обновляем заголовок окна
                        fd.Text = Path.GetFileName(fd.filePath);
                    }
                }
            }
        }

        public static void Save(Form fm)
        {
            if (fm is FormDocument fd)
            {
                if (string.IsNullOrEmpty(fd.filePath) || !fd.isSaved)
                {
                    // Если файл не сохранен ранее, вызываем "Сохранить как…"
                    SaveAs(fd);
                }
                else
                {
                    ImageFormat format;
                    string extension = Path.GetExtension(fd.filePath).ToLower();

                    switch (extension)
                    {
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        default:
                            format = ImageFormat.Png;
                            break;
                    }

                    fd.bitmap.Save(fd.filePath, format);
                }
            }
        }

        public void ResizeCanvas(int newWidth, int newHeight)
        {
            if (newWidth <= 0 || newHeight <= 0)
                throw new ArgumentException("Incorrect canvas size");

            Bitmap newBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White);
                if (bitmap != null)
                {
                    g.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                }
            }

            bitmap = newBitmap;
            AutoScrollMinSize = new Size(newWidth, newHeight);
            Invalidate();
        }
    }
}
