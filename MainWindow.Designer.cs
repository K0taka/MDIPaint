namespace MDIPaint
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonColorBlack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColorRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColorGreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPickedColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColorPicker = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripWidthButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripWidthLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBrush = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripDropDownButton();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залитыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSizeUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSizeDown = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(90, 44);
            this.файлToolStripMenuItem.Tag = "F";
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(494, 44);
            this.новыйToolStripMenuItem.Text = "&Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(494, 44);
            this.открытьToolStripMenuItem.Text = "О&ткрыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(491, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(494, 44);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(494, 44);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить &как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(491, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(494, 44);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(124, 44);
            this.рисунокToolStripMenuItem.Text = "&Рисунок";
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(471, 44);
            this.размерХолстаToolStripMenuItem.Text = "Размер &холста...";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.размерХолстаToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(76, 44);
            this.окноToolStripMenuItem.Text = "&Окно";
            // 
            // каскадToolStripMenuItem
            // 
            this.каскадToolStripMenuItem.Name = "каскадToolStripMenuItem";
            this.каскадToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.каскадToolStripMenuItem.Text = "&Каскад";
            this.каскадToolStripMenuItem.Click += new System.EventHandler(this.каскадToolStripMenuItem_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.слеваНаправоToolStripMenuItem.Text = "С&лева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.слеваНаправоToolStripMenuItem_Click);
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.сверхуВнизToolStripMenuItem.Text = "С&верху вниз";
            this.сверхуВнизToolStripMenuItem.Click += new System.EventHandler(this.сверхуВнизToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(407, 44);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "&Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.упорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(126, 44);
            this.справкаToolStripMenuItem.Text = "Спр&авка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(350, 44);
            this.оПрограммеToolStripMenuItem.Text = "О &программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonColorBlack,
            this.toolStripButtonColorRed,
            this.toolStripButtonColorGreen,
            this.toolStripButtonPickedColor,
            this.toolStripButtonColorPicker,
            this.toolStripSeparator3,
            this.toolStripWidthButton,
            this.toolStripWidthLabel,
            this.toolStripSeparator4,
            this.toolStripButtonBrush,
            this.toolStripButtonEraser,
            this.toolStripButtonLine,
            this.toolStripSeparator5,
            this.toolStripButtonEllipse,
            this.toolStripSeparator7,
            this.toolStripSeparator6,
            this.toolStripButtonSizeUp,
            this.toolStripButtonSizeDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 42);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonColorBlack
            // 
            this.toolStripButtonColorBlack.AutoSize = false;
            this.toolStripButtonColorBlack.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonColorBlack.Checked = true;
            this.toolStripButtonColorBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonColorBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorBlack.ForeColor = System.Drawing.Color.Black;
            this.toolStripButtonColorBlack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColorBlack.Image")));
            this.toolStripButtonColorBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorBlack.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButtonColorBlack.Name = "toolStripButtonColorBlack";
            this.toolStripButtonColorBlack.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonColorBlack.Text = "Черный";
            this.toolStripButtonColorBlack.Click += new System.EventHandler(this.toolStripButtonColorBlack_Click);
            // 
            // toolStripButtonColorRed
            // 
            this.toolStripButtonColorRed.AutoSize = false;
            this.toolStripButtonColorRed.BackColor = System.Drawing.Color.Red;
            this.toolStripButtonColorRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColorRed.Image")));
            this.toolStripButtonColorRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorRed.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripButtonColorRed.Name = "toolStripButtonColorRed";
            this.toolStripButtonColorRed.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonColorRed.Text = "Красный";
            this.toolStripButtonColorRed.Click += new System.EventHandler(this.toolStripButtonColorRed_Click);
            // 
            // toolStripButtonColorGreen
            // 
            this.toolStripButtonColorGreen.AutoSize = false;
            this.toolStripButtonColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.toolStripButtonColorGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorGreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColorGreen.Image")));
            this.toolStripButtonColorGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorGreen.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripButtonColorGreen.Name = "toolStripButtonColorGreen";
            this.toolStripButtonColorGreen.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonColorGreen.Text = "Зеленый";
            this.toolStripButtonColorGreen.Click += new System.EventHandler(this.toolStripButtonColorGreen_Click);
            // 
            // toolStripButtonPickedColor
            // 
            this.toolStripButtonPickedColor.AutoSize = false;
            this.toolStripButtonPickedColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPickedColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPickedColor.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripButtonPickedColor.Name = "toolStripButtonPickedColor";
            this.toolStripButtonPickedColor.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonPickedColor.Text = "toolStripButton1";
            this.toolStripButtonPickedColor.ToolTipText = "Ваш цвет";
            this.toolStripButtonPickedColor.Click += new System.EventHandler(this.toolStripButtonPickedColor_Click);
            this.toolStripButtonPickedColor.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButtonPickedColor_Paint);
            // 
            // toolStripButtonColorPicker
            // 
            this.toolStripButtonColorPicker.AutoSize = false;
            this.toolStripButtonColorPicker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColorPicker.Image")));
            this.toolStripButtonColorPicker.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorPicker.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripButtonColorPicker.Name = "toolStripButtonColorPicker";
            this.toolStripButtonColorPicker.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonColorPicker.Text = "Выбрать цвет";
            this.toolStripButtonColorPicker.Click += new System.EventHandler(this.toolStripButtonColorPicker_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripWidthButton
            // 
            this.toolStripWidthButton.AutoSize = false;
            this.toolStripWidthButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripWidthButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripWidthButton.Image")));
            this.toolStripWidthButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripWidthButton.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.toolStripWidthButton.Name = "toolStripWidthButton";
            this.toolStripWidthButton.Size = new System.Drawing.Size(46, 36);
            this.toolStripWidthButton.Text = "Ширина кисти";
            this.toolStripWidthButton.Click += new System.EventHandler(this.toolStripWidthButton_Click);
            // 
            // toolStripWidthLabel
            // 
            this.toolStripWidthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripWidthLabel.Name = "toolStripWidthLabel";
            this.toolStripWidthLabel.Size = new System.Drawing.Size(139, 50);
            this.toolStripWidthLabel.Text = "Толщина: 1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButtonBrush
            // 
            this.toolStripButtonBrush.Checked = true;
            this.toolStripButtonBrush.CheckOnClick = true;
            this.toolStripButtonBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBrush.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBrush.Image")));
            this.toolStripButtonBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrush.Name = "toolStripButtonBrush";
            this.toolStripButtonBrush.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonBrush.Text = "Кисть";
            this.toolStripButtonBrush.Click += new System.EventHandler(this.toolStripButtonBrush_Click);
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.CheckOnClick = true;
            this.toolStripButtonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEraser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEraser.Image")));
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonEraser.Text = "Ластик";
            this.toolStripButtonEraser.Click += new System.EventHandler(this.toolStripButtonEraser_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.CheckOnClick = true;
            this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonLine.Text = "Линия";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEllipse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.залитыйToolStripMenuItem});
            this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(54, 44);
            this.toolStripButtonEllipse.Text = "Эллипс";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(255, 44);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // залитыйToolStripMenuItem
            // 
            this.залитыйToolStripMenuItem.Name = "залитыйToolStripMenuItem";
            this.залитыйToolStripMenuItem.Size = new System.Drawing.Size(255, 44);
            this.залитыйToolStripMenuItem.Text = "Залитый";
            this.залитыйToolStripMenuItem.Click += new System.EventHandler(this.залитыйToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripButtonSizeUp
            // 
            this.toolStripButtonSizeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSizeUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSizeUp.Image")));
            this.toolStripButtonSizeUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSizeUp.Name = "toolStripButtonSizeUp";
            this.toolStripButtonSizeUp.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonSizeUp.Text = "Масштаб+";
            this.toolStripButtonSizeUp.Click += new System.EventHandler(this.toolStripButtonSizeUp_Click);
            // 
            // toolStripButtonSizeDown
            // 
            this.toolStripButtonSizeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSizeDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSizeDown.Image")));
            this.toolStripButtonSizeDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSizeDown.Name = "toolStripButtonSizeDown";
            this.toolStripButtonSizeDown.Size = new System.Drawing.Size(46, 36);
            this.toolStripButtonSizeDown.Text = "Масштаб-";
            this.toolStripButtonSizeDown.Click += new System.EventHandler(this.toolStripButtonSizeDown_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.MdiChildActivate += new System.EventHandler(this.MainWindow_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorBlack;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorRed;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorGreen;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorPicker;
        private System.Windows.Forms.ToolStripButton toolStripButtonPickedColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripWidthLabel;
        private System.Windows.Forms.ToolStripButton toolStripWidthButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrush;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залитыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSizeUp;
        private System.Windows.Forms.ToolStripButton toolStripButtonSizeDown;
    }
}

