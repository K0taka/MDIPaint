using System.Windows.Forms;

namespace MDIPaint
{
    partial class PluginDialog
    {
        private System.ComponentModel.IContainer components = null;

        private CheckBox chkAutoMode;
        private ListView pluginsList;
        private ColumnHeader colName;
        private ColumnHeader colAuthor;
        private ColumnHeader colVersion;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.chkAutoMode = new System.Windows.Forms.CheckBox();
            this.pluginsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAutoMode
            // 
            this.chkAutoMode.AutoSize = true;
            this.chkAutoMode.Location = new System.Drawing.Point(12, 12);
            this.chkAutoMode.Name = "chkAutoMode";
            this.chkAutoMode.Size = new System.Drawing.Size(281, 29);
            this.chkAutoMode.TabIndex = 0;
            this.chkAutoMode.Text = "Автоматический режим";
            this.chkAutoMode.UseVisualStyleBackColor = true;
            // 
            // pluginsList
            // 
            this.pluginsList.CheckBoxes = true;
            this.pluginsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAuthor,
            this.colVersion});
            this.pluginsList.FullRowSelect = true;
            this.pluginsList.GridLines = true;
            this.pluginsList.HideSelection = false;
            this.pluginsList.Location = new System.Drawing.Point(12, 42);
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.Size = new System.Drawing.Size(560, 250);
            this.pluginsList.TabIndex = 1;
            this.pluginsList.UseCompatibleStateImageBehavior = false;
            this.pluginsList.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Название";
            this.colName.Width = 200;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "Автор";
            this.colAuthor.Width = 200;
            // 
            // colVersion
            // 
            this.colVersion.Text = "Версия";
            this.colVersion.Width = 100;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(460, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PluginDialog
            // 
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pluginsList);
            this.Controls.Add(this.chkAutoMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление плагинами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}