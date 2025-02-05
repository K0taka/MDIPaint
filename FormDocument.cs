using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MDIPaint
{
    public partial class FormDocument : Form
    {
        static int created = 1;
        bool isModed = false;
        Point start;
        Point end;
        Bitmap bitmap;
        bool isMoving = false;
        string filePath = null;
        bool isSaved = false;
        bool isDrawing = false;
        Bitmap drawingBitmap = null;

        public int Width { get { return bitmap.Width; } }
        public int Height { get { return bitmap.Height; } }

        public FormDocument()
        {
            InitializeComponent();
            bitmap = new Bitmap(800, 800);
            ClearBitmap();
            InitializeDocument();
            Text = $"Новый {created++}";
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
                using (var tempImage = Image.FromFile(path))
                {
                    if (tempImage.Width > 5000 || tempImage.Height > 5000)
                    {
                        throw new ArgumentException("Изображение слишком большое.");
                    }

                    // Создаем новый Bitmap из загруженного изображения
                    bitmap = new Bitmap(tempImage);
                }
            }
            catch (ArgumentException)
            {
                var parent = MdiParent as MainWindow;
                MessageBox.Show(parent, "Файл не является изображением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (IOException)
            {
                var parent = MdiParent as MainWindow;
                MessageBox.Show(parent, "Файл занят другим процессом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch
            {
                var parent = MdiParent as MainWindow;
                MessageBox.Show(parent, "Невозможно открыть файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (e.Button == MouseButtons.Left)
            {
                MarkAsModified();
                start = AdjustForScroll(e.Location);
                isDrawing = true;
                drawingBitmap?.Dispose();
                drawingBitmap = (Bitmap)bitmap.Clone();
            }
        }

        private void FormDocument_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                end = AdjustForScroll(e.Location);
                if (MainWindow.CurrentBrush == Brushes.Brush)
                {
                    // Рисуем линию на основном холсте
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        DrawLine(g, start, end, MainWindow.CurrentColor, MainWindow.CurrentWidth);
                    }

                    // Обновляем начальную точку для следующего отрезка
                    start = end;
                }
                else if (MainWindow.CurrentBrush == Brushes.Eraser)
                {
                    // Стираем изображение
                    using (var g = Graphics.FromImage(bitmap))
                    {
                        Erase(g, end, MainWindow.CurrentWidth);
                    }

                    // Обновляем начальную точку для следующего отрезка
                    start = end;
                }
                Invalidate();
            }

            int x = e.X - this.AutoScrollPosition.X;
            int y = e.Y - this.AutoScrollPosition.Y;
            if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
            {
                switch (MainWindow.CurrentBrush)
                {
                    case Brushes.Brush:
                        this.Cursor = MainWindow.BrushCursor;
                        break;
                    case Brushes.Eraser:
                        this.Cursor = MainWindow.EraserCursor;
                        break;
                    case Brushes.Line:
                        this.Cursor = MainWindow.LineCursor;
                        break;
                    case Brushes.Ellipse:
                        this.Cursor = MainWindow.EllipseCursor;
                        break;
                    default:
                        this.Cursor = Cursors.Default;
                        break;
                }
            }
            else
            {
                this.Cursor = Cursors.Default;
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
            e.Graphics.DrawImage(bitmap, this.AutoScrollPosition);

            if (isDrawing && drawingBitmap != null && MainWindow.CurrentBrush != Brushes.Brush && MainWindow.CurrentBrush != Brushes.Eraser)
            {
                using (var g = Graphics.FromImage(drawingBitmap))
                {
                    g.Clear(Color.White);
                    g.DrawImage(bitmap, Point.Empty);
                    DrawPreview(g);
                }
                e.Graphics.DrawImage(drawingBitmap, this.AutoScrollPosition);
            }
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
                        fd.isModed = false;

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
                    fd.isModed = false;
                    fd.Text = Path.GetFileName(fd.filePath);
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

        private void FormDocument_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                end = AdjustForScroll(e.Location);
                isDrawing = false;

                // Рисуем фигуру на основном холсте
                using (var g = Graphics.FromImage(bitmap))
                {
                    DrawFinalShape(g);
                }

                drawingBitmap?.Dispose();
                drawingBitmap = null;
                Invalidate();
            }
        }

        private Point AdjustForScroll(Point point)
        {
            return new Point(
                point.X - this.AutoScrollPosition.X,
                point.Y - this.AutoScrollPosition.Y
            );
        }

        private void DrawPreview(Graphics g)
        {
            switch (MainWindow.CurrentBrush)
            {
                case Brushes.Line:
                    DrawLine(g, start, end, MainWindow.CurrentColor, MainWindow.CurrentWidth);
                    break;
                case Brushes.Ellipse:
                    DrawEllipsePreview(g, start, end, MainWindow.CurrentColor, MainWindow.CurrentWidth);
                    break;

            }
        }

        private void DrawFinalShape(Graphics g)
        {
            switch (MainWindow.CurrentBrush)
            {
                case Brushes.Line:
                    DrawLine(g, start, end, MainWindow.CurrentColor, MainWindow.CurrentWidth);
                    break;
                case Brushes.Ellipse:
                    DrawEllipse(g, start, end, MainWindow.CurrentColor, MainWindow.CurrentWidth);
                    break;
            }
        }
        private void DrawLine(Graphics g, Point start, Point end, Color color, float width)
        {
            using (var pen = new Pen(color, width))
            {
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, start, end);
            }
        }

        private void FormDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && isDrawing && Brushes.Brush != MainWindow.CurrentBrush)
            {
                isDrawing = false;
                drawingBitmap?.Dispose();
                drawingBitmap = null;
                Invalidate();
            }
        }

        private void DrawEllipsePreview(Graphics g, Point start, Point end, Color color, float width)
        {
            var rect = GetEllipseRectangle(start, end);

            if (MainWindow.IsFilled)
            {
                // Рисуем закрашенный эллипс для предпросмотра
                using (var brush = new SolidBrush(Color.FromArgb(128, color))) // Полупрозрачный цвет
                {
                    g.FillEllipse(brush, rect);
                }
            }
            else
            {
                // Рисуем только контур для предпросмотра
                using (var pen = new Pen(color, width))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; // Пунктир для предпросмотра
                    g.DrawEllipse(pen, rect);
                }
            }
        }

        private void DrawEllipse(Graphics g, Point start, Point end, Color color, float width)
        {
            var rect = GetEllipseRectangle(start, end);

            if (MainWindow.IsFilled)
            {
                // Рисуем закрашенный эллипс
                using (var brush = new SolidBrush(color))
                {
                    g.FillEllipse(brush, rect);
                }
            }
            else
            {
                // Рисуем только контур
                using (var pen = new Pen(color, width))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    g.DrawEllipse(pen, rect);
                }
            }
        }

        private Rectangle GetEllipseRectangle(Point start, Point end)
        {
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            return new Rectangle(x, y, width, height);
        }

        private void Erase(Graphics g, Point center, float size)
        {
            using (var brush = new SolidBrush(Color.White)) // Заливаем белым цветом
            {
                // Вычисляем координаты квадрата
                float halfSize = size / 2;
                float x = center.X - halfSize;
                float y = center.Y - halfSize;

                // Заливаем квадратную область
                g.FillRectangle(brush, x, y, size, size);
            }
        }
        private void MarkAsModified()
        {
            if (!isModed)
            {
                isModed = true;
                this.Text += "*"; // Добавляем звездочку к заголовку
            }
        }

        private void FormDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            if (isModed)
            {
                var parent = MdiParent as MainWindow;
                result = MessageBox.Show(
                    parent,
                    $"Сохранить изменения в файле {this.Text.TrimEnd('*')}?",
                    "Сохранение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1
                );

                switch (result)
                {
                    case DialogResult.Yes:
                        Save(this); // Сохраняем файл
                        break;
                    case DialogResult.No:
                        // Закрываем без сохранения
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true; // Отменяем закрытие
                        return;
                }
            }
            bitmap?.Dispose();
            bitmap = null;
        }
    }
}
