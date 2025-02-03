namespace MDIPaint
{
    partial class FormDocument
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
            this.SuspendLayout();
            // 
            // FormDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.DoubleBuffered = true;
            this.Name = "FormDocument";
            this.Text = "FormDocument";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDocument_FormClosed);
            this.LocationChanged += new System.EventHandler(this.FormDocument_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDocument_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDocument_MouseMove);
            this.Move += new System.EventHandler(this.FormDocument_Move);
            this.Resize += new System.EventHandler(this.FormDocument_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}