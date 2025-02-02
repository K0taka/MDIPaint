namespace MDIPaint
{
    partial class FormWidthPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Min;
            System.Windows.Forms.Label Max;
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            this.labelChosen = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            Min = new System.Windows.Forms.Label();
            Max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // Min
            // 
            Min.AutoSize = true;
            Min.Location = new System.Drawing.Point(82, 96);
            Min.Name = "Min";
            Min.Size = new System.Drawing.Size(24, 25);
            Min.TabIndex = 1;
            Min.Text = "1";
            // 
            // Max
            // 
            Max.AutoSize = true;
            Max.Location = new System.Drawing.Point(465, 96);
            Max.Name = "Max";
            Max.Size = new System.Drawing.Size(36, 25);
            Max.TabIndex = 2;
            Max.Text = "20";
            // 
            // trackBarWidth
            // 
            this.trackBarWidth.Location = new System.Drawing.Point(70, 43);
            this.trackBarWidth.Maximum = 20;
            this.trackBarWidth.Minimum = 1;
            this.trackBarWidth.Name = "trackBarWidth";
            this.trackBarWidth.Size = new System.Drawing.Size(441, 90);
            this.trackBarWidth.TabIndex = 0;
            this.trackBarWidth.Value = 1;
            this.trackBarWidth.ValueChanged += new System.EventHandler(this.trackBarWidth_ValueChanged);
            // 
            // labelChosen
            // 
            this.labelChosen.AutoSize = true;
            this.labelChosen.Location = new System.Drawing.Point(219, 136);
            this.labelChosen.Name = "labelChosen";
            this.labelChosen.Size = new System.Drawing.Size(125, 25);
            this.labelChosen.TabIndex = 3;
            this.labelChosen.Text = "Выбрано: 1";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(141, 175);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 39);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(309, 175);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 39);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormWidthPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(574, 229);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelChosen);
            this.Controls.Add(Max);
            this.Controls.Add(Min);
            this.Controls.Add(this.trackBarWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormWidthPicker";
            this.Text = "Размер кисти";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label labelChosen;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}